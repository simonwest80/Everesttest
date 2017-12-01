using HtmlAgilityPack;
using ReverseMarkdown;
using ReverseMarkdown.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chm2jekyll.SourceProducer
{
    public class PEx
            : ConverterBase
    {
        public PEx(Converter converter) : base(converter)
        {
            //this.Converter.Register("p", this);
        }

        public override string Convert(HtmlNode node)
        {
            string content = this.TreatChildren(node).Trim();
            if (string.IsNullOrEmpty(content))
                return string.Empty;

            bool isTipText = false;

            //make bold if needed
            var attr = node.Attributes.FirstOrDefault(x => string.Compare(x.Name, "class") == 0);
            if (attr != null)
            {
                if(!content.Contains("see_also") && (attr.Value.Contains("hcp1") || attr.Value.Contains("hcp2") || attr.Value.Contains("Tip-Note-Heading")))
                    content = $"**{content}**";

                if (attr.Value.Contains("Tip-Note-Text"))
                {
                    content = $": {content}";
                    isTipText = true;
                }
            }

            string indentation = IndentationFor(node, isTipText);
            var result = indentation + content + Environment.NewLine;
            return result;
        }

        private string IndentationFor(HtmlNode node, bool isTipText)
        {
            int length = node.Ancestors("ol").Count() + node.Ancestors("ul").Count();
            return node.ParentNode.Name.ToLowerInvariant() == "li" && node.ParentNode.FirstChild != node
                ? new string(' ', length * 4)
                : (isTipText ? "" : Environment.NewLine + Environment.NewLine);
        }
    }
}

