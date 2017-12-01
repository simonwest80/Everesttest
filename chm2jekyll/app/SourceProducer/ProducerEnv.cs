using System;
using System.Collections.Generic;
using System.Text;

namespace chm2jekyll.SourceProducer
{
    class ProducerEnv
    {
        public string DestinationFolder { set; get; }
        public string CHMFullName { set; get; }
        public string CHMFileName { set; get; }
        public string ProjectFolder { set; get; }
        public string HHPFullName { set; get; }
        public string HHCFullName { set; get; }
        public string HHKFullName { set; get; }
        public string ProjectTitle { set; get; }
    }
}
