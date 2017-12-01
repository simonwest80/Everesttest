using chm2jekyll.CHMParser;
using System;
using System.Collections.Generic;
using System.Text;

namespace chm2jekyll.Interfaces
{
    interface IFileProcessor : IProcessor
    {
        void ProcessFile(string fileFullPath);
    }
}
