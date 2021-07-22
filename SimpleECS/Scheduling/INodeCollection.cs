using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Scheduling
{
    public interface INodeCollection : IEnumerable<INode>
    {
        public bool IsEmpty();
    }
}
