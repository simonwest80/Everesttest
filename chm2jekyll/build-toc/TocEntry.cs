using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace build_toc
{

    public class TopicHeader
    {
        [YamlMember(Alias = "layout", ApplyNamingConventions = false)]
        public string Layout { set; get; }

        [YamlMember(Alias = "title", ApplyNamingConventions = false)]
        public string Title { set; get; }
        [YamlMember(Alias = "sections", ApplyNamingConventions = false)]
        public List<string> Sections { set; get; }
        [YamlMember(Alias = "sorted_pages", ApplyNamingConventions = false)]
        public List<string> Pages { set; get; }
    }


    class TocEntry
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Url { set; get; }
        public List<TocEntry> Childs { set; get; } = new List<TocEntry>();

        static int _autoId = 0;

        public TocEntry()
        {
            Id = _autoId++;
        }
        public bool ShouldSerializeChilds()
        {
            return Childs.Count > 0;
        }

        public static TocEntry BuildToc(string parentUrl, string index)
        {
            var res = new TocEntry();
            string indexFolder = Path.GetDirectoryName(index) + Path.DirectorySeparatorChar;

            TopicHeader header = ParseYaml(index);
            res.Title = header.Title ?? "Unknown title";
            res.Url = parentUrl + "index.html";

            if(header.Pages != null)
            {
                foreach(var pageName in header.Pages)
                {
                    TopicHeader pageHeader = ParseYaml(indexFolder + pageName + ".md");
                    res.Childs.Add(new TocEntry
                    {
                        //Parent = res,
                        Title = pageHeader.Title ?? pageName,
                        Url = parentUrl + pageName + ".html"
                    });
                }
            }

            if (header.Sections != null)
            {
                foreach (var sectionName in header.Sections)
                {
                    string sectionIndex = indexFolder + sectionName + Path.DirectorySeparatorChar + "index.md";
                    if (!File.Exists(sectionIndex))
                    {
                        Console.WriteLine($"WARN: Cannot find section index: {sectionIndex}");
                        continue;
                    }

                    TocEntry secEntry = BuildToc(parentUrl + sectionName + "/", sectionIndex);
                    res.Childs.Add(secEntry);
                }
            }

            return res;
        }

        internal void SaveForGijgoTree(string tocFile)
        {
            string jsonText = JsonConvert.SerializeObject(this.Childs, new JsonSerializerSettings { ContractResolver = CustomDataContractResolver.Instance });
            File.WriteAllText(tocFile, $"---{Environment.NewLine}layout: null{Environment.NewLine}---{Environment.NewLine}");
            File.AppendAllText(tocFile, jsonText);
        }

        static TopicHeader ParseYaml(string filePath)
        {
            try
            {
                string yamlText = string.Empty;

                //read yaml from the top of MD file
                IEnumerable<string> lines = File.ReadLines(filePath).Skip(1); //skip first "---"
                foreach (string yamlLine in lines)
                {
                    if ("---" == yamlLine)
                        break;
                    yamlText += yamlLine + Environment.NewLine;
                }

                //parse yaml looking for sections and sorted_pages
                var deserializer = new DeserializerBuilder()
                    //.WithNamingConvention(new PascalCaseNamingConvention())
                    .Build();

                var r = new StringReader(yamlText);
                var yamlObject = deserializer.Deserialize<TopicHeader>(r);
                return yamlObject;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Failed to pasrse YAML {filePath}");
                throw;
            }
        }

        public class CustomDataContractResolver : DefaultContractResolver
        {
            public static readonly CustomDataContractResolver Instance = new CustomDataContractResolver();

            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
            {
                var property = base.CreateProperty(member, memberSerialization);
                if (property.DeclaringType == typeof(TocEntry))
                {
                    if (property.PropertyName.Equals("Title", StringComparison.OrdinalIgnoreCase))
                        property.PropertyName = "text";
                    if (property.PropertyName.Equals("Id", StringComparison.OrdinalIgnoreCase))
                        property.PropertyName = "id";
                    if (property.PropertyName.Equals("Url", StringComparison.OrdinalIgnoreCase))
                        property.PropertyName = "url";
                    if (property.PropertyName.Equals("Childs", StringComparison.OrdinalIgnoreCase))
                        property.PropertyName = "children";
                }
                return property;
            }
        }
    }
}
