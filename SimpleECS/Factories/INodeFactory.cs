using SimpleECS.Scheduling;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Factories
{
    public interface INodeFactory
    {
        public INode CreateNode();
        public INode CreateConnectedNode(INodeCollection parentNodes, INodeCollection childNodes);
        public INode CreateConnectedNode(INode parentNode, INodeCollection childNodes);
        public INode CreateConnectedNode(INode parentNode, INode childNode);
        public INode CreateConnectedNode(INode parentNode);
        public INode CreateConnectedNode(INodeCollection parentNode);

        public INodeCollection CreateCollectionFromNodes(params INode[] nodes);
    }
}
