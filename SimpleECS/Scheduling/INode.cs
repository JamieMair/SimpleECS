using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Scheduling
{
    public interface INode
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public INodeCollection GetParents();

        public INodeCollection GetChildren();
    }
}
