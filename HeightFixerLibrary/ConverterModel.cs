using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightFixerLibrary
{
    public class ConverterModel
    {
        public string InputPath { get; set; }
        public string OutputPath { get; set; }
        public string[] InputText { get; set; }
        public StreamWriter OutputFile { get; set; }
        public Dictionary<string, string> NewText { get; set; }
    }
}
