using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Scheduling
{
    public interface INode
    {
        public int ID { get; set; }
        public ICollection<INode> Children { get; set; }
    }
}
