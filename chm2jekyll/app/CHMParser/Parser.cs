using chm2jekyll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;

namespace chm2jekyll.CHMParser
{
    class Parser
    {
        string _extractCHMFolder;
        public Sitemap TOC { private set; get; } = new Sitemap();
        public Sitemap Index { private set; get; } = new Sitemap();
        public string CHMFilePath { set; get; }
        public Dictionary<string, string> Aliases { private set; get; } = new Dictionary<string, string>();

        public void Parse(string chmFilePath)
        {
            CHMFilePath = chmFilePath;

            //extract CHM file
            ChmlsWrapper.ExtractInfo info = ChmlsWrapper.ExtractCHM(chmFilePath);
            /*ChmlsWrapper.ExtractInfo info = new ChmlsWrapper.ExtractInfo
            {
                Folder = @"C:\Users\Administrator\AppData\Local\Temp\1\ldxxl4sa.yea\",
                ContextALI = "working-with-everest.ali",
                ContextH = "working-with-everest.h"
            };*/
            _extractCHMFolder = info.Folder;

            //read TOC
            ReadTOC();

            //read Index
            ReadIndex();

            //read mapping IDs
            ReadContextMapping(info.Folder + info.ContextALI);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);

        internal void CopyTopic(string topicFilename, string destinationFilePath)
        {
            //CopyFile(_extractCHMFolder + topicFilename, destinationFilePath, true);
            File.Copy(_extractCHMFolder + topicFilename, destinationFilePath, true);
        }

        public void Execute(IEnumerable<ExecutionBatch> batches)
        {
            batches.ToList().ForEach(b => RunBatch(b));
        }
        private void RunBatch(ExecutionBatch batch)
        {
            Console.WriteLine($"Starting batch: {batch.Type}");
            switch (batch.Type)
            {
                case ExecutionType.EnumTOC:
                    EnumSitemap(TOC, batch.Processors, batch.Type);
                    break;
                case ExecutionType.EnumIndex:
                    EnumSitemap(Index, batch.Processors, batch.Type);
                    break;
                case ExecutionType.EnumSrcFiles:
                    EnumSourceFiles(batch.Processors);
                    break;
                default:
                    throw new Exception($"Unexpected batch type {batch.Type}");
            }
        }

        private void EnumSourceFiles(List<IProcessor> processors)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(_extractCHMFolder, "*.*", SearchOption.AllDirectories);
            
            //enumerate all files in the folder
            files.ToList().ForEach(f =>
            {
                processors.ForEach(p => { (p as IFileProcessor)?.ProcessFile(f); });
            });
        }
        private static void EnumSitemap(Sitemap sitemap, List<IProcessor> processors, ExecutionType batchType)
        {
            sitemap.EnumerateEntries(
                null,
                e =>
                {
                    processors.ForEach(p =>
                    {
                        if (batchType == ExecutionType.EnumIndex)
                        {
                            (p as ISitemapEntryProcessor)?.OnEntry(e);
                        }
                        else
                        {
                            if (e.IsSection)
                                (p as ISectionProcessor)?.ProcessSection(e);
                            if (e.IsTopic)
                                (p as ITopicProcessor)?.ProcessTopic(e);
                        }
                    });
                },
                null);
        }
        private void ReadContextMapping(string contextALI)
        {
            if (File.Exists(contextALI))
            {
                string[] lines = File.ReadAllLines(contextALI);
                foreach (string line in lines)
                {
                    //helpid353=zzuser_code_everest_login.htm
                    string[] parts = line.Split('=');
                    Aliases.Add(parts[0].Substring(6), parts[1].Trim());
                }
            }
            else
            {
                Console.WriteLine($"WARN: ALI file does not exist: {contextALI}");
            }
        }
        private void ReadIndex()
        {
            string indexFilePath = FindSingleFile("*.hhk", false);
            if(!string.IsNullOrEmpty(indexFilePath))
                Index.Parse(indexFilePath);
        }
        private void ReadTOC()
        {
            string tocFilePath = FindSingleFile("*.hhc");
            TOC.Parse(tocFilePath);
        }
        private string FindSingleFile(string mask, bool throwException = true)
        {
            string[] files = Directory.GetFiles(_extractCHMFolder, mask);
            if (files.Length > 1)
                throw new Exception($"More than one {mask} file found: {string.Join(",", files)}");

            if (files.Length == 0)
                if (throwException)
                    throw new Exception($"{mask} file is not found");
                else
                    return null;

            return files[0];
        }

    }
}
