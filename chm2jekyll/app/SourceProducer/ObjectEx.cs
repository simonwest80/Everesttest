using HtmlAgilityPack;
using ReverseMarkdown;
using ReverseMarkdown.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chm2jekyll.SourceProducer
{
    class ObjectEx : ConverterBase
    {
        public ObjectEx(Converter converter) : base(converter)
        {
        }

        public override string Convert(HtmlNode node)
        {
            return Environment.NewLine + Environment.NewLine + node.OuterHtml;
        }
    }
}
