using chm2jekyll.CHMParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace chm2jekyll.SourceProducer
{
    class Producer
    {
        ProducerEnv _env = new ProducerEnv();
        public void Generate(Parser parser, string outputFolder, string shortsFile = null)
        {
            UpdateEnvironmentObject(parser, outputFolder);

            Dictionary<string, string> shortNames = null;
            if (!string.IsNullOrEmpty(shortsFile))
                shortNames = ReadShortNames(shortsFile);

            //=============================================================
            //First iteration
            // - generate final folder structure
            // - copy topics
            //
            var batch = new ExecutionBatch
            {
                Type = ExecutionType.EnumTOC,
                Processors = { new FoldersGenerator(_env.DestinationFolder, shortNames), new HtmlTopicsGenerator(parser) }
            };
            parser.Execute(new ExecutionBatch[] { batch });

            UpdateEnvironmentObject(parser, outputFolder);

            //=============================================================
            //Second iteration
            // - fix topic path in TOC (*.hhc) file
            var hhpGenerator = new HHPGenerator(parser, _env.ProjectFolder);
            batch = new ExecutionBatch
            {
                Type = ExecutionType.EnumTOC,
                Processors = { hhpGenerator }
            };
            parser.Execute(new ExecutionBatch[] { batch });

            //=============================================================
            //Third iteration
            // - fix topic path in Index (*.hhk) file
            batch = new ExecutionBatch
            {
                Type = ExecutionType.EnumIndex,
                Processors = { hhpGenerator }
            };
            parser.Execute(new ExecutionBatch[] { batch });

            //=============================================================
            //4th iteration
            // - copy unreferneced (niether in toc nor in index) files into misc folder
            batch = new ExecutionBatch
            {
                Type = ExecutionType.EnumSrcFiles,
                Processors = { hhpGenerator }
            };
            parser.Execute(new ExecutionBatch[] { batch });

            hhpGenerator.FixRefs();
            hhpGenerator.Save(parser, "Project title");
            parser.TOC.Save(_env.HHCFullName);
            parser.Index.Save(_env.HHKFullName);

            //=============================================================
            //5th iteration
            // - generate index.md files
            batch = new ExecutionBatch
            {
                Type = ExecutionType.EnumTOC,
                Processors = { new IndexMdGenerator() }
            };
            parser.Execute(new ExecutionBatch[] { batch });

            //=============================================================
            //6th iteration
            // - generate *.md files for TOC and remove original html (?)
            batch = new ExecutionBatch
            {
                Type = ExecutionType.EnumTOC,
                Processors = { new MdConverter(hhpGenerator.PopupResources) }
            };
            parser.Execute(new ExecutionBatch[] { batch });

            //=============================================================
            //7th iteration
            // - generate *.md files for Index and remove original html (?)
            batch = new ExecutionBatch
            {
                Type = ExecutionType.EnumIndex,
                Processors = { new MdConverter(hhpGenerator.PopupResources) }
            };
            parser.Execute(new ExecutionBatch[] { batch });

            //=============================================================
            //7th iteration
            // - enumerate rest *.htm and generate *.md files remove original htm (?)
            var mdGenerator = new MdConverter(hhpGenerator.PopupResources);
            IEnumerable<string> files = Directory.EnumerateFiles(outputFolder, "*.htm", SearchOption.AllDirectories);
            //enumerate all files in the folder
            foreach (var f in files)
                mdGenerator.ProcessFile(f);

            // copy files
            // fix TOC
            // fix Index
            // copy unreferenced files to misc
            // generate HHP
            // generate HHC
            // generate HHK
            // fix links images, css, javascript
            // copy images to local folders
            // generate index.md
            // genreate md placeholders (or convert to md?)
        }

        private Dictionary<string, string> ReadShortNames(string shortsFile)
        {
            var names = new Dictionary<string, string>();

            string[] lines = File.ReadAllLines(shortsFile);
            foreach(string line in lines)
            {
                string[] parts = line.Split(',');
                if (names.ContainsKey(parts[0]))
                {
                    if (string.Compare(names[parts[0]], parts[1], true) == 0)
                        continue;

                    Console.WriteLine($"Diff vals for the same key {parts[0]}");

                }
                names.Add(parts[0], parts[1]);
            }
            return names;
        }

        private string GetProjectFolder(Parser parser, string outputFolder)
        {
            // if there is only single folder in the root then created project files inside of it- either destination folder or generate HHP
            if (parser.TOC.RootEntry.Childs.Count == 1
                && parser.TOC.RootEntry.Childs[0].IsSection
                && parser.TOC.RootEntry.Childs[0].Context.ContainsKey(EntryContextType.folderFullPath))
            {
                return parser.TOC.RootEntry.Childs[0].Context[EntryContextType.folderFullPath];
            }
            return outputFolder;
        }

        private void UpdateEnvironmentObject(Parser parser, string outputFolder, string projectTitle = null)
        {
            _env.DestinationFolder = outputFolder;
            _env.CHMFullName = parser.CHMFilePath;
            _env.CHMFileName = Path.GetFileName(_env.CHMFullName);
            _env.ProjectTitle = projectTitle;
            _env.ProjectFolder = GetProjectFolder(parser, outputFolder);
            _env.HHPFullName = _env.ProjectFolder + Path.GetFileNameWithoutExtension(_env.CHMFileName) + ".hhp";
            _env.HHCFullName = _env.ProjectFolder + Path.GetFileNameWithoutExtension(_env.CHMFileName) + ".hhc";
            _env.HHKFullName = _env.ProjectFolder + Path.GetFileNameWithoutExtension(_env.CHMFileName) + ".hhk";
        }
    }
}
