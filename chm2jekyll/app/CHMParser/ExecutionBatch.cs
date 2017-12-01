using chm2jekyll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace chm2jekyll.CHMParser
{
    enum ExecutionType
    {
        EnumTOC,
        EnumIndex,
        EnumSrcFiles
    };

    class ExecutionBatch
    {
        public string Name { set; get; }
        public ExecutionType Type { set;get;}
        public List<IProcessor> Processors { set; get; } = new List<IProcessor>();
    }
}
