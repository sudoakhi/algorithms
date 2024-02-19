namespace Suhyphen.Algo.Common
{
    public sealed class BinaryTreeNode
    {
        internal int _value;
        internal BinaryTreeNode _parent;
        internal BinaryTreeNode _left;
        internal BinaryTreeNode _right;

        public BinaryTreeNode(int value)
        {
            _value = value;
            _parent = null;
            _left = null;
            _right = null;
        }
    }
}
