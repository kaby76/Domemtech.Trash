using CommandLine;

namespace Trash
{
    public class Config
    {
        [Option('f', "file", Required = false)]
        public string File { get; set; }

        [Option('t', "type", Required = false, Default = "antlr4")]
        public string Type { get; set; }

        [Option('v', "verbose", Required = false)]
        public bool Verbose { get; set; }
    }
}
