namespace Trash
{
    using Antlr4.Runtime.Tree;
    using AntlrJson;
    using LanguageServer;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.Json;

    class Command
    {
        public string Help()
        {
            using (Stream stream = this.GetType().Assembly.GetManifestResourceStream("trrename.readme.md"))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public void Execute(Config config)
        {
            string lines = null;
            if (!(config.File != null && config.File != ""))
            {
                if (config.Verbose)
                {
                    System.Console.Error.WriteLine("reading from stdin");
                }
                for (; ; )
                {
                    lines = System.Console.In.ReadToEnd();
                    if (lines != null && lines != "") break;
                }
            }
            else
            {
                if (config.Verbose)
                {
                    System.Console.Error.WriteLine("reading from file >>>" + config.File + "<<<");
                }
                lines = File.ReadAllText(config.File);
            }
            var serializeOptions = new JsonSerializerOptions();
            serializeOptions.Converters.Add(new ParseTreeConverter());
            serializeOptions.WriteIndented = true;
            var data = JsonSerializer.Deserialize<ParsingResultSet[]>(lines, serializeOptions);
            var results = new List<ParsingResultSet>();
            foreach (var parse_info in data)
            {
                var text = parse_info.Text;
                var fn = parse_info.FileName;
                var atrees = parse_info.Nodes;
                var parser = parse_info.Parser;
                var lexer = parse_info.Lexer;
                var tokstream = parse_info.Stream;
                var doc = Docs.Class1.CreateDoc(parse_info);
                doc.ParseTree = null;
                doc.Changed = true;
                ParsingResults ref_pd = ParsingResultsFactory.Create(doc);
                ref_pd.ParseTree = null;
                //ref_pd.Changed = true;
                _ = new Module().GetQuickInfo(0, doc);
                //Compile(workspace);

                var l1 = config.RenameMap.Split(';').ToList();
                var rename_map = new Dictionary<string, string>();
                foreach (var l in l1)
                {
                    var l2 = l.Split(',').ToList();
                    if (l2.Count != 2)
                        throw new System.Exception("Rename map not correct. '"
                            + l
                            + "' doesn't have correct number of commans, should be 'oldval,newval'.");
                    rename_map[l2[0]] = l2[1];
                }

                System.Collections.Generic.Dictionary<string, string> res = null;
                res = LanguageServer.Transform.Rename(rename_map, doc);
                if (res != null && res.Count > 0)
                {
                    var pr = ParsingResultsFactory.Create(doc);
                    Docs.Class1.EnactEdits(res);
                    IParseTree pt = pr.ParseTree;
                    var tuple = new ParsingResultSet()
                    {
                        Text = doc.Code,
                        FileName = doc.FullPath,
                        Stream = pr.TokStream,
                        Nodes = new IParseTree[] { pt },
                        Lexer = pr.Lexer,
                        Parser = pr.Parser
                    };
                    results.Add(tuple);
                }
                else
                {
                    System.Console.Error.WriteLine("Warning: No changes in "
                        + doc.FullPath
                        + " with rename map " + config.RenameMap);
                    results.Add(parse_info);
                }
            }
            string js1 = JsonSerializer.Serialize(results.ToArray(), serializeOptions);
            System.Console.Write(js1);

            //org.eclipse.wst.xml.xpath2.processor.Engine engine = new org.eclipse.wst.xml.xpath2.processor.Engine();
            //IParseTree root = atrees.First().Root();
            //var ate = new AntlrTreeEditing.AntlrDOM.ConvertToDOM();
            //using (AntlrTreeEditing.AntlrDOM.AntlrDynamicContext dynamicContext = ate.Try(root, parser))
            //{
            //    var nodes = engine.parseExpression(expr,
            //            new StaticContextBuilder()).evaluate(dynamicContext, new object[] { dynamicContext.Document })
            //        .Select(x => (x.NativeValue as AntlrTreeEditing.AntlrDOM.AntlrElement).AntlrIParseTree as TerminalNodeImpl).ToList();

            //    System.Collections.Generic.Dictionary<string, string> results = null;
            //    if (nodes != null && nodes.Count > 0)
            //    {
            //        results = LanguageServer.Transform.Rename(nodes, to_sym, doc);
            //    }
            //    if (results != null && results.Count > 0)
            //    {
            //        Docs.Class1.EnactEdits(results);
            //        var pr = ParsingResultsFactory.Create(doc);
            //        IParseTree pt = pr.ParseTree;
            //        var tuple = new ParsingResultSet()
            //        {
            //            Text = doc.Code,
            //            FileName = doc.FullPath,
            //            Stream = pr.TokStream,
            //            Nodes = new IParseTree[] { pt },
            //            Lexer = pr.Lexer,
            //            Parser = pr.Parser
            //        };
            //        string js1 = JsonSerializer.Serialize(tuple, serializeOptions);
            //        System.Console.WriteLine(js1);
            //    }
            //    else
            //    {
            //        System.Console.WriteLine(lines);
            //    }
            //}
        }
    }
}
