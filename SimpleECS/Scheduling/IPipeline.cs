using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Scheduling
{
    public interface IPipeline
    {
        public INode GetNode(int id);
        public INode AddConnectedNode(INodeCollection parentNodes, INodeCollection childNodes);
        public INode AddConnectedNode(INode parentNode, INodeCollection childNodes);
        public INode AddConnectedNode(INode parentNode, INode childNode);
        public INode AddConnectedNode(INode parentNode);
        public INode CreateRootNode();
        public INode InsertEndNode();
    }
}
