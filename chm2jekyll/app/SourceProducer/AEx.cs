
using HtmlAgilityPack;
using ReverseMarkdown;
using ReverseMarkdown.Converters;

namespace chm2jekyll.SourceProducer
{
	public class AEx
		: ConverterBase
	{
		public AEx(Converter converter)
			: base(converter)
		{
		}

		public override string Convert(HtmlNode node)
		{
			string name = this.TreatChildren(node);

			string href = node.GetAttributeValue("href", string.Empty);
			string target = node.GetAttributeValue("target", string.Empty);
			string id = node.GetAttributeValue("id", string.Empty);
            string title = this.ExtractTitle(node);
			title = title.Length > 0 ? string.Format(" \"{0}\"", title) : "";

			var result =  string.Format("[{0}]({1}{2})", name, href, title);
            if (!string.IsNullOrEmpty(target) || !string.IsNullOrEmpty(id))
            {
                result += "{:";
                if(!string.IsNullOrEmpty(target))
                    result +=  "target=\"" + target + "\" ";

                if (!string.IsNullOrEmpty(id))
                    result += "id=\"" + id + "\"";

                result += "}";
            }
            return result;
		}
	}
}
