using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace chm2jekyll.CHMParser
{
    /// <summary>
    /// Wrapper for Free Pascal chmls.exe
    /// </summary>
    class ChmlsWrapper
    {
        public class ExtractInfo
        {
            public string Folder { set;  get; }
            public string ContextALI{ set; get; }
            public string ContextH { set; get; }
        }



        /// <summary>
        /// Extract chm into specified folder by running chtmls.exe <paramref name="chmPath"/> <paramref name="dstFolder"/>
        /// </summary>
        /// <param name="chmPath">Full path to a CHM file</param>
        /// <param name="dstFolder">Folder to extract CHM content to. Argument is optional, tem folder is created if not specified</param>
        /// <returns>Path to the folder CHM was extracted to</returns>
        public static ExtractInfo ExtractCHM(string chmPath, string dstFolder = null)
        {
            if (string.IsNullOrEmpty(dstFolder))
                dstFolder = GetTemporaryDirectory();

            Console.WriteLine($"Extracting CHM into {dstFolder}...");

            Process chmls = new Process();
            chmls.StartInfo.FileName = "chmls.exe";
            chmls.StartInfo.Arguments = $"extractall \"{chmPath}\" \"{dstFolder}\"";
            chmls.StartInfo.UseShellExecute = false;
            chmls.StartInfo.RedirectStandardOutput = true;
            chmls.Start();

            Console.WriteLine(chmls.StandardOutput.ReadToEnd());

            chmls.WaitForExit();

            if (chmls.ExitCode != 0)
                throw new Exception("Failed to extract CHM");

            chmls.StartInfo.WorkingDirectory = dstFolder;
            chmls.StartInfo.Arguments = $"extractalias \"{chmPath}\"";
            chmls.Start();

            Console.WriteLine(chmls.StandardOutput.ReadToEnd());

            chmls.WaitForExit();

            if (chmls.ExitCode != 0)
                throw new Exception("Failed to extract alias");

            //move alias files into destination folder
            string contextFileBaseName = Path.GetFileNameWithoutExtension(chmPath);
            string srcPath = Path.GetDirectoryName(chmPath) + "\\";
            string aliFileName = contextFileBaseName + ".ali";
            string hFileName = contextFileBaseName + ".h";

            if (File.Exists(srcPath + aliFileName))
            {
                File.Move(srcPath + aliFileName, dstFolder + "\\" + aliFileName);
                File.Move(srcPath + hFileName, dstFolder + "\\" + hFileName);
            }


            return new ExtractInfo
            {
                Folder = dstFolder,
                ContextALI = aliFileName,
                ContextH = hFileName
            };
        }

        private static string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            tempDirectory += Path.DirectorySeparatorChar;

            Directory.CreateDirectory(tempDirectory);

            return tempDirectory;
        }
    }
}
