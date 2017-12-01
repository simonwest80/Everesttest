using HtmlAgilityPack;
using ReverseMarkdown;
using ReverseMarkdown.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chm2jekyll.SourceProducer
{
    class SpanEx : ConverterBase
    {
        public SpanEx(Converter converter) : base(converter)
        {
        }

        public override string Convert(HtmlNode node)
        {
            string styleVal = node.GetAttributeValue("style", null)?.Replace(" ", "").Trim();
            string classVal = node.GetAttributeValue("class", null);
            if ((classVal != null && classVal.StartsWith("hcp")) ||
                (styleVal != null && styleVal.Contains("font-weight:bold")))
            {
                string postfix = "";
                string prefix = "";
                if (node.InnerText.EndsWith(" "))
                    postfix = " ";
                if (node.InnerText.StartsWith(" "))
                    prefix = " ";

                return $"{prefix}**{node.InnerText.Trim()}**{postfix}";
            }

            return this.TreatChildren(node);
        }
    }
}
