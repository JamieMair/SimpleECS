using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Scheduling
{
    public class Pipeline : IPipeline
    {
        private ICollection<INode> Nodes { get; set; }
        public INode RootNode { get; set; }
        public INode EndNode { get; set; }

    }
}
