using SimpleECS.Factories;
using System.Collections.Generic;
using System.Linq;

namespace SimpleECS.Scheduling
{
    public class Pipeline : IPipeline
    {
        #region Fields
        private INodeFactory _nodeFactory;
        private Dictionary<int, INode> _nodes { get; set; }
        public INode RootNode { get; set; }
        public INode EndNode { get; set; }
        #endregion

        #region Constructor
        public Pipeline(INodeFactory nodeFactory)
        {
            _nodeFactory = nodeFactory;
        }
        #endregion


        #region Methods

        private void addNode(INode node)
        {
            _nodes.Add(node.ID, node);
        }
        public INode GetNode(int id)
        {
            if (_nodes.ContainsKey(id))
                return _nodes[id];
            else
                return null;
        }

        #region Add Nodes
        public INode AddConnectedNode(INodeCollection parentNodes, INodeCollection childNodes)
        {
            var node = _nodeFactory.CreateConnectedNode(parentNodes, childNodes);
            addNode(node);
            return node;
        }
        public INode AddConnectedNode(INode parentNode, INodeCollection childNodes)
        {
            var node = _nodeFactory.CreateConnectedNode(parentNode, childNodes);
            addNode(node);
            return node;
        }
        public INode AddConnectedNode(INode parentNode, INode childNode)
        {
            var node = _nodeFactory.CreateConnectedNode(parentNode, childNode);
            addNode(node);
            return node;
        }
        public INode AddConnectedNode(INode parentNode)
        {
            var node = _nodeFactory.CreateConnectedNode(parentNode);
            addNode(node);
            return node;
        }
        public INode AddConnectedNode(INodeCollection parentNode)
        {
            var node = _nodeFactory.CreateConnectedNode(parentNode);
            addNode(node);
            return node;
        }
        public INode CreateRootNode()
        {
            // TODO: Add warning for overwriting the root node
            var node = _nodeFactory.CreateNode();
            addNode(node);
            node.Title = "Root Node";
            RootNode = node;
            return node;
        }
        public INode InsertEndNode()
        {
            // TODO: Add warning for overwriting the end node
            // Find all leaf nodes and connect them all to the end node.
            var leaves = _nodes.Values.Where(x => x.GetChildren().IsEmpty());
            var parentCollection = _nodeFactory.CreateCollectionFromNodes(leaves.ToArray());
            var endNode = AddConnectedNode(parentCollection);
            endNode.Title = "End";
            EndNode = endNode;
            return endNode;
        }
        #endregion
        #endregion
    }
}
