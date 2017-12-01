using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace rename
{
    // "C:\temp\ba" "C:\everest-docs\chm2jekyll\rename\ba-rename.txt"
    // "c:\temp\sp" "C:\everest-docs\chm2jekyll\rename\sp-rename.txt"
    // "c:\temp\pos" "C:\everest-docs\chm2jekyll\rename\pos-rename.txt"
    // "c:\temp\acc" "C:\everest-docs\chm2jekyll\rename\acc-rename.txt"
    // "c:\temp\utl" "C:\everest-docs\chm2jekyll\rename\utl-rename.txt"
    class Program
    {
        static Dictionary<string, string> _renames = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            InitRenames(args[1]);

            string[] exts = { ".html", ".md", ".hhc", ".hhk", ".hhp" };

            IEnumerable<string> files = Directory.EnumerateFiles(args[0], "*.*", SearchOption.AllDirectories);
            foreach(string file in files)
            {
                //rename in content
                if (exts.Contains(Path.GetExtension(file).ToLower()))
                {
                    var lines = File.ReadAllLines(file);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        foreach (var rn in _renames)
                        {
                            //replace whole word only
                            Regex rx = new Regex($"\\b{rn.Key}\\b");
                            lines[i] = rx.Replace(lines[i], rn.Value);
                            lines[i] = lines[i].Replace("‘", "'");
                            lines[i] = lines[i].Replace("’", "'");
                            lines[i] = lines[i].Replace("“", "\"");
                            lines[i] = lines[i].Replace("”", "\"");
                        }
                    }
                    File.WriteAllLines(file, lines);
                }

                //rename the file
                string name = Path.GetFileNameWithoutExtension(file).ToLower();
                if(_renames.ContainsKey(name))
                {
                    Console.WriteLine($"Renaming [{name}] => [{_renames[name]}]");
                    File.Move(file, file.Replace(name, _renames[name]));
                }
            }
        }

        private static void InitRenames(string inputFile)
        {
            IEnumerable<string> lines = File.ReadAllLines(inputFile);
            foreach(var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(',');
                _renames.Add(parts[0].ToLower(), parts[1].ToLower());
            }

            Boolean reuse = false;
            var keys = _renames.Select(x => x.Key);
            foreach(var key in keys)
            {
                foreach(var curKey in keys)
                {
                    if(curKey.IndexOf(key) >= 0 && string.Compare(key, curKey) != 0)
                    {
                        Console.WriteLine($"WARN: key reuse: {key} and {curKey}");
                        reuse = true;
                    }
                }
            }

            if(reuse)
            {
                Console.WriteLine("Presee ENTER to continue or Ctrl+C to stop..");
                Console.ReadLine();
            }
        }
    }
}
