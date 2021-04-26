namespace suhyphen.Algo.FindSuccessorInBinaryTree
{
    internal class BinaryTreeNode
    {
        internal int Value;
        internal BinaryTreeNode Parent;
        internal BinaryTreeNode Left;
        internal BinaryTreeNode Right;

        public BinaryTreeNode(int value)
        {
            Value = value;
            Parent = null;
            Left = null;
            Right = null;
        }
    }
}
