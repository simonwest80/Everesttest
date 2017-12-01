using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;

namespace build_toc
{
    class Program
    {
        static void Main(string[] args)
        {

            var conv = new PascalCaseNamingConvention();
            string res = conv.Apply("layout");

            TocEntry tocRoot = TocEntry.BuildToc("{{site.baseurl}}/", @"C:\everest-docs\docs-src\index.md");
            tocRoot.SaveForGijgoTree(@"C:\everest-docs\docs-src\toc.json");
        }
    }
}
