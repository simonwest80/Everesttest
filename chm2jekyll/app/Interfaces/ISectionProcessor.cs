using chm2jekyll.CHMParser;
using System;
using System.Collections.Generic;
using System.Text;

namespace chm2jekyll.Interfaces
{
    interface ISectionProcessor : IProcessor
    {
        void ProcessSection(SitemapEntry entry);
    }
}
