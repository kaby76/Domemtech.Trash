namespace AntlrJson
{
    using Antlr4.Runtime;
    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime.Tree;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using AltAntlr;

    public class ParseTreeConverter : JsonConverter<ParsingResultSet[]>
    {
        public ParseTreeConverter()
        {
        }

        private static string Capitalized(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public override bool CanConvert(Type typeToConvert) => true;

        public override ParsingResultSet[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
            reader.Read();
            List<ParsingResultSet> results = new List<ParsingResultSet>();
            while (reader.TokenType == JsonTokenType.StartObject)
            {
                if (!(reader.TokenType == JsonTokenType.StartObject)) throw new JsonException();
                reader.Read();
                string file_name = "";
                string text = null;
                string parser_grammarFileName = null;
                string lexer_grammarFileName = null;
                List<string> mode_names = new List<string>();
                List<string> channel_names = new List<string>();
                List<string> lexer_rule_names = new List<string>();
                List<string> literal_names = new List<string>();
                List<string> symbolic_names = new List<string>();
                Dictionary<string, int> token_type_map = new Dictionary<string, int>();
                List<string> parser_rule_names = new List<string>();
                Dictionary<int, IParseTree> nodes = new Dictionary<int, IParseTree>();
                List<MyToken> list_of_tokens = new List<MyToken>();
                List<IParseTree> result = new List<IParseTree>();
                List<int> parents = new List<int>();
                List<int> type_of_nodes = new List<int>();
                while (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string pn = reader.GetString();
                    reader.Read();
                    if (pn == "FileName")
                    {
                        file_name = reader.GetString();
                        reader.Read();
                    }
                    else if (pn == "Text")
                    {
                        text = reader.GetString();
                        reader.Read();
                    }
                    else if (pn == "IdentityOfParser")
                    {
                        parser_grammarFileName = reader.GetString();
                        reader.Read();
                    }
                    else if (pn == "IdentityOfLexer")
                    {
                        lexer_grammarFileName = reader.GetString();
                        reader.Read();
                    }
                    else if (pn == "Tokens")
                    {
                        if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
                        reader.Read();
                        int token_index = 0;
                        while (reader.TokenType == JsonTokenType.Number)
                        {
                            var type = reader.GetInt32();
                            reader.Read();
                            var start = reader.GetInt32();
                            reader.Read();
                            var stop = reader.GetInt32();
                            reader.Read();
                            var line = reader.GetInt32();
                            reader.Read();
                            var column = reader.GetInt32();
                            reader.Read();
                            var channel = reader.GetInt32();
                            reader.Read();
                            var token = new MyToken();
                            token.Type = type;
                            token.StartIndex = start;
                            token.StopIndex = stop;
                            token.Line = line;
                            token.Column = column;
                            token.Channel = channel;
                            token.TokenIndex = token_index++;
                            list_of_tokens.Add(token);
                        }
                        reader.Read();
                    }
                    else if (pn == "ModeNames")
                    {
                        if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
                        reader.Read();
                        while (reader.TokenType == JsonTokenType.String || reader.TokenType == JsonTokenType.Null)
                        {
                            mode_names.Add(reader.GetString());
                            reader.Read();
                        }

                        reader.Read();
                    }
                    else if (pn == "ChannelNames")
                    {
                        if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
                        reader.Read();
                        while (reader.TokenType == JsonTokenType.String)
                        {
                            channel_names.Add(reader.GetString());
                            reader.Read();
                        }
                        reader.Read();
                    }
                    else if (pn == "LiteralNames")
                    {
                        if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
                        reader.Read();
                        while (reader.TokenType == JsonTokenType.String || reader.TokenType == JsonTokenType.Null)
                        {
                            literal_names.Add(reader.GetString());
                            reader.Read();
                        }
                        reader.Read();
                    }
                    else if (pn == "SymbolicNames")
                    {
                        if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
                        reader.Read();
                        while (reader.TokenType == JsonTokenType.String || reader.TokenType == JsonTokenType.Null)
                        {
                            symbolic_names.Add(reader.GetString());
                            reader.Read();
                        }
                        reader.Read();
                    }
                    else if (pn == "LexerRuleNames")
                    {
                        if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
                        reader.Read();
                        while (reader.TokenType == JsonTokenType.String || reader.TokenType == JsonTokenType.Null)
                        {
                            lexer_rule_names.Add(reader.GetString());
                            reader.Read();
                        }
                        reader.Read();
                    }
                    else if (pn == "ParserRuleNames")
                    {
                        if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
                        reader.Read();
                        while (reader.TokenType == JsonTokenType.String || reader.TokenType == JsonTokenType.Null)
                        {
                            var name = reader.GetString();
                            parser_rule_names.Add(name);
                            reader.Read();
                        }
                        reader.Read();
                    }
                    else if (pn == "TokenTypeMap")
                    {
                        if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
                        reader.Read();
                        while (reader.TokenType == JsonTokenType.String || reader.TokenType == JsonTokenType.Null)
                        {
                            var name = reader.GetString();
                            reader.Read();
                            var tt = reader.GetInt32();
                            reader.Read();
                            token_type_map[name] = tt;
                        }
                        reader.Read();
                    }
                    else if (pn == "Nodes")
                    {
                        List<IParseTree> list_of_nodes = new List<IParseTree>();
                        if (!(reader.TokenType == JsonTokenType.StartArray)) throw new JsonException();
                        reader.Read();
                        while (reader.TokenType == JsonTokenType.Number)
                        {
                            int parent = reader.GetInt32();
                            parents.Add(parent);
                            reader.Read();
                            int type_of_node = reader.GetInt32();
                            type_of_nodes.Add(type_of_node);
                            reader.Read();
                        }
                        reader.Read();
                    }
                    else
                        throw new JsonException();
                }
                if (!(reader.TokenType == JsonTokenType.EndObject)) throw new JsonException();
                reader.Read();
                var vocab = new Vocabulary(literal_names.ToArray(), symbolic_names.ToArray());
                MyTokenStream out_token_stream = new MyTokenStream();
                out_token_stream.Text = text;
                MyLexer lexer = new MyLexer(null);
                MyParser parser = new MyParser(out_token_stream);
                MyCharStream fake_char_stream = new MyCharStream();
                fake_char_stream.SourceName = file_name;
                fake_char_stream.Text = text;
                out_token_stream._tokenSource = lexer;
                lexer.TokenStream = out_token_stream;
                lexer._inputstream = fake_char_stream;
                foreach (var t in list_of_tokens)
                {
                    t.TokenSource = lexer;
                    t.InputStream = lexer.InputStream;
                    t.Text = out_token_stream.Text.Substring(t.StartIndex, t.StopIndex - t.StartIndex + 1);
                    out_token_stream.Add(t);
                }
                parser._vocabulary = vocab;
                parser._grammarFileName = parser_grammarFileName;
                parser._ruleNames = parser_rule_names.ToArray();
                lexer._vocabulary = vocab;
                lexer._grammarFileName = lexer_grammarFileName;
                lexer._ruleNames = lexer_rule_names.ToArray();
                lexer._tokenTypeMap = token_type_map;
                lexer._modeNames = mode_names.ToArray();
                lexer.Tokens = out_token_stream.GetTokens();
                lexer._channelNames = channel_names.ToArray();
                int current = 1;
                for (int k = 0; k < parents.Count; ++k)
                {
                    var parent = parents[k];
                    var type_of_node = type_of_nodes[k];
                    var parent_node = parent > 0 ? nodes[parent] as MyParserRuleContext : null;
                    if (type_of_node < 1000000)
                    {
                        MyParserRuleContext foo = new MyParserRuleContext(parent_node, 0)
                        {
                            _ruleIndex = type_of_node
                        };
                        nodes[current] = foo;
                        if (parent_node == null)
                        {
                            result.Add(foo);
                        }
                        else
                        {
                            parent_node.AddChild((Antlr4.Runtime.RuleContext)foo);
                        }
                    }
                    else
                    {
                        var index = type_of_node - 1000000;
                        var symbol = out_token_stream.Get(index);
                        var foo = new MyTerminalNodeImpl(symbol);
                        nodes[current] = foo;
                        foo.Parent = parent_node;
                        if (parent_node == null)
                        {
                            result.Add(foo);
                        }
                        else
                        {
                            parent_node.AddChild(foo);
                        }
                    }
                    current++;
                }
                foreach (var n in result)
                {
                    Reset(n, parser, lexer, out_token_stream, fake_char_stream);
                }
                var res = new AntlrJson.ParsingResultSet()
                {
                    FileName = fake_char_stream.SourceName,
                    Stream = out_token_stream,
                    Nodes = result.ToArray(),
                    Lexer = lexer,
                    Parser = parser,
                    Text = text
                };
                results.Add(res);
            }
            reader.Read();

            return results.ToArray();
        }

        
        private void Reset(IParseTree tree, MyParser parser, MyLexer lexer, MyTokenStream ts, MyCharStream cs)
        {
            if (tree is AltAntlr.MyTerminalNodeImpl l)
            {
                l.Parser = parser;
                l.Lexer = lexer;
                l.TokenStream = ts;
                l.InputStream = cs;
                var t = l.Payload as AltAntlr.MyToken;
                l.Start = t.TokenIndex;
                l.Stop = t.TokenIndex;
                l._sourceInterval = new Antlr4.Runtime.Misc.Interval(t.TokenIndex, t.TokenIndex);
            }
            else if (tree is AltAntlr.MyParserRuleContext p)
            {
                p.Parser = parser;
                p.Lexer = lexer;
                p.TokenStream = ts;
                p.InputStream = cs;
                var res = p.SourceInterval;
                if (p.ChildCount > 0)
                {
                    int min = int.MaxValue;
                    int max = int.MinValue;
                    for (int i = 0; i < tree.ChildCount; ++i)
                    {
                        var c = tree.GetChild(i);
                        Reset(c, parser, lexer, ts, cs);
                        min = Math.Min(min, c.SourceInterval.a);
                        max = Math.Max(max, c.SourceInterval.b);
                    }
                    res = new Interval(min, max);
                }
                else
                {
                    res = new Interval(int.MaxValue, -1);
                }
                p._sourceInterval = res;
            }
        }

        public override void Write(Utf8JsonWriter writer, ParsingResultSet[] data, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            foreach (var tuple in data)
            {
                writer.WriteStartObject();

                if (tuple.FileName != null)
                {
                    writer.WritePropertyName("FileName");
                    writer.WriteStringValue(tuple.FileName);
                }

                if (tuple.Text != null)
                {
                    writer.WritePropertyName("Text");
                    writer.WriteStringValue(tuple.Text);
                }

                if (tuple.Parser != null && tuple.Parser.GrammarFileName != null)
                {
                    writer.WritePropertyName("IdentityOfParser");
                    writer.WriteStringValue(tuple.Parser.GrammarFileName);
                }

                if (tuple.Lexer != null && tuple.Lexer.GrammarFileName != null)
                {
                    writer.WritePropertyName("IdentityOfLexer");
                    writer.WriteStringValue(tuple.Lexer.GrammarFileName);
                }

                if (tuple.Stream != null)
                {
                    writer.WritePropertyName("Tokens");
                    writer.WriteStartArray();
                    var in_token_stream = tuple.Stream as ITokenStream;
                    in_token_stream.Seek(0);
                    for (int i = 0; i < in_token_stream.Size; ++i)
                    {
                        var token = in_token_stream.Get(i);
                        writer.WriteNumberValue(token.Type);
                        writer.WriteNumberValue(token.StartIndex);
                        writer.WriteNumberValue(token.StopIndex);
                        writer.WriteNumberValue(token.Line);
                        writer.WriteNumberValue(token.Column);
                        writer.WriteNumberValue(token.Channel);
                        if (token.Type == Antlr4.Runtime.TokenConstants.EOF) break;
                    }
                    writer.WriteEndArray();
                }

                if (tuple.Lexer != null)
                {
                    writer.WritePropertyName("ModeNames");
                    writer.WriteStartArray();
                    var lexer = tuple.Lexer as Lexer;
                    foreach (var n in lexer.ModeNames)
                    {
                        writer.WriteStringValue(n);
                    }
                    writer.WriteEndArray();
                    writer.WritePropertyName("ChannelNames");
                    writer.WriteStartArray();
                    foreach (var n in lexer.ChannelNames)
                    {
                        writer.WriteStringValue(n);
                    }
                    writer.WriteEndArray();

                    writer.WritePropertyName("LiteralNames");
                    writer.WriteStartArray();
                    // ROYAL PAIN IN THE ASS ANTLR HIDING.
                    var vocab = lexer.Vocabulary;
                    var vocab_type = vocab.GetType();
                    FieldInfo myFieldInfo1 = vocab_type.GetField("literalNames",
                        BindingFlags.NonPublic | BindingFlags.Instance);
                    var literal_names = myFieldInfo1.GetValue(vocab) as string[];
                    FieldInfo myFieldInfo2 = vocab_type.GetField("symbolicNames",
                        BindingFlags.NonPublic | BindingFlags.Instance);
                    var symbolic_names = myFieldInfo2.GetValue(vocab) as string[];
                    foreach (var n in literal_names)
                    {
                        writer.WriteStringValue(n);
                    }
                    writer.WriteEndArray();
                    writer.WritePropertyName("SymbolicNames");
                    writer.WriteStartArray();
                    foreach (var n in symbolic_names)
                    {
                        writer.WriteStringValue(n);
                    }
                    writer.WriteEndArray();

                    writer.WritePropertyName("LexerRuleNames");
                    writer.WriteStartArray();
                    foreach (var n in lexer.RuleNames)
                    {
                        writer.WriteStringValue(n);
                    }
                    writer.WriteEndArray();
                    writer.WritePropertyName("TokenTypeMap");
                    writer.WriteStartArray();
                    foreach (var pair in lexer.TokenTypeMap)
                    {
                        writer.WriteStringValue(pair.Key);
                        writer.WriteNumberValue(pair.Value);
                    }
                    writer.WriteEndArray();
                }
                if (tuple.Parser != null)
                {
                    writer.WritePropertyName("ParserRuleNames");
                    writer.WriteStartArray();
                    var parser = tuple.Parser as Parser;
                    foreach (var n in parser.RuleNames)
                    {
                        writer.WriteStringValue(n);
                    }
                    writer.WriteEndArray();
                }

                if (tuple.Nodes != null && tuple.Nodes.Any())
                {
                    writer.WritePropertyName("Nodes");
                    writer.WriteStartArray();
                    Stack<IParseTree> stack = new Stack<IParseTree>();
                    foreach (var node in tuple.Nodes) stack.Push(node as IParseTree);
                    Dictionary<IParseTree, int> preorder = new Dictionary<IParseTree, int>();
                    int number = 1;
                    while (stack.Any())
                    {
                        var node = stack.Pop();
                        preorder[node] = number++;
                        if (node is ParserRuleContext n)
                        {
                            if (n.Parent != null)
                            {
                                // Note, the node may have a parent, but the tree that is being serialized may be
                                // a sub tree. If there is no key for the node, write out zero.
                                if (preorder.ContainsKey(n.Parent))
                                    writer.WriteNumberValue(preorder[n.Parent]);
                                else
                                    writer.WriteNumberValue(0);
                            }
                            else
                                writer.WriteNumberValue(0);
                            var type = n.RuleIndex;
                            writer.WriteNumberValue(type);
                            if (n.children != null)
                            {
                                foreach (var c in n.children.Reverse())
                                {
                                    stack.Push(c);
                                }
                            }
                        }
                        else if (node is TerminalNodeImpl t)
                        {
                            if (t.Parent != null)
                            {
                                if (preorder.ContainsKey(t.Parent))
                                    writer.WriteNumberValue(preorder[t.Parent]);
                                else
                                    writer.WriteNumberValue(0);
                            }
                            else
                                writer.WriteNumberValue(0);
                            var type = t.Symbol.TokenIndex + 1000000;
                            writer.WriteNumberValue(type);
                        }
                    }
                    writer.WriteEndArray();
                }

                writer.WriteEndObject();
            }
            writer.WriteEndArray();
        }
    }
}

