namespace Trash
{
    using Antlr4.Runtime;
    using Antlr4.Runtime.Tree;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using Document = Workspaces.Document;
    using Workspace = Workspaces.Workspace;

    public class Grun
    {
        Config config;

        public Grun(Config co)
        {
            config = co;
        }

        public List<Document> Grammars { get; set; }

        public List<Document> ImportGrammars { get; set; }

        public List<Document> SupportCode { get; set; }

        private static string JoinArguments(IEnumerable<string> arguments)
        {
            if (arguments == null)
                throw new ArgumentNullException("arguments");

            StringBuilder builder = new StringBuilder();
            foreach (string argument in arguments)
            {
                if (builder.Length > 0)
                    builder.Append(' ');

                if (argument.IndexOfAny(new[] { '"', ' ' }) < 0)
                {
                    builder.Append(argument);
                    continue;
                }

                // escape a backslash appearing before a quote
                string arg = argument.Replace("\\\"", "\\\\\"");
                // escape double quotes
                arg = arg.Replace("\"", "\\\"");

                // wrap the argument in outer quotes
                builder.Append('"').Append(arg).Append('"');
            }

            return builder.ToString();
        }

        private void HandleOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            System.Console.WriteLine(e.Data);
        }

        public void ReadWorkspace(string csproj)
        {
        }

        public void CreateMsbuildWorkspace(Workspace workspace)
        {
        }

        public void Run()
        {
            try
            {
                var data = new List<AntlrJson.ParsingResultSet>();
                string txt = config.Input;
                if (config.Input == null && (config.Files == null || config.Files.Count() == 0))
                {
                    string lines = null;
                    for (; ; )
                    {
                        lines = System.Console.In.ReadToEnd();
                        if (lines != null && lines != "") break;
                    }
                    txt = lines;
                    Doit(txt);
                }
                else if (config.Input != null)
                {
                    txt = config.Input;
                    Doit(txt);
                }
                else if (config.Files != null)
                {
                    foreach (var file in config.Files)
                    {
                        try
                        {
                            txt = File.ReadAllText(file);
                        }
                        catch
                        {
                            txt = file;
                        }
                        Doit(txt);
                    }
                }
            }
            finally
            {
            }
        }

        void Doit(string txt)
        {
            string path = config.ParserLocation != null ? config.ParserLocation
                : Environment.CurrentDirectory + Path.DirectorySeparatorChar;
            path = path.Replace("\\", "/");
            if (!path.EndsWith("/")) path = path + "/";
            var full_path = path + "Generated\\bin\\Debug\\net6.0\\";
            var exists = File.Exists(full_path + "Test.dll");
            if (!exists) full_path = path + "bin\\Debug\\net6.0\\";
            full_path = Path.GetFullPath(full_path);
            Assembly asm1 = Assembly.LoadFile(full_path + "Antlr4.Runtime.Standard.dll");
            Assembly asm = Assembly.LoadFile(full_path + "Test.dll");
            var xxxxxx = asm1.GetTypes();
            Type[] types = asm.GetTypes();
            Type type = asm.GetType("Program");
            var methods = type.GetMethods();
            {
                MethodInfo methodInfo = type.GetMethod("SetupParse2");
                object[] parm = new object[] { txt };
                var res = methodInfo.Invoke(null, parm);
            }
	        // Set perf.
	        var r2 = type.GetProperty("Parser").GetValue(null, new object[0]);
            var parser = r2 as Parser;
            parser.Profile = true;
            {
                MethodInfo methodInfo = type.GetMethod("Parse2");
                object[] parm = new object[] { };
                DateTime before = DateTime.Now;
                var res = methodInfo.Invoke(null, parm);
                DateTime after = DateTime.Now;
                System.Console.Error.WriteLine("Time to parse: " + (after - before));
                System.Console.WriteLine(
                   "Decision"
                   + "\t" + "Rule"
                   + "\t" + "Invocations"
                   + "\t" + "Time"
                   + "\t" + "Total-k"
                   + "\t" + "Max-k"
                   + "\t" + "Fallback"
                   + "\t" + "Ambiguities"
                   + "\t" + "Errors"
                   );
                for (int i = 0; i < parser.ParseInfo.getDecisionInfo().Length; i++)
                {
                    var r = parser.ParseInfo.getDecisionInfo()[i];
                    var decision = r.decision;
                    var atn = parser.Atn;
                    var state = atn.decisionToState[decision];
                    var rule_index = state.ruleIndex;
                    var rule_name = parser.RuleNames[rule_index];
                    System.Console.WriteLine(
                        decision
                        + "\t" + rule_name
                        + "\t" + r.invocations
                        + "\t" + r.timeInPrediction
                        + "\t" + r.LL_TotalLook
                        + "\t" + r.LL_MaxLook
                        + "\t" + r.LL_Fallback
                        + "\t" + r.ambiguities.Count
                        + "\t" + r.errors.Count
                        );
                }
            }
        }
    }
}
