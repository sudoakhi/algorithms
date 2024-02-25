namespace Algorithms.BT
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Parent { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
            Parent = null;
            Left = null;
            Right = null;
        }
    }
}
