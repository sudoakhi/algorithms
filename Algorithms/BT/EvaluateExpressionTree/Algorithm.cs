using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BT.EvaluateExpressionTree
{
    public static class Algorithm
    {
        public static int Run(BinaryTreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            if(root.Value >= 0)
            {
                return root.Value;
            }

            var leftValue = Run(root.Left);
            var rightValue = Run(root.Right);
            if(root.Value == -1)
            {
                return leftValue + rightValue;
            }
            else if(root.Value == -2)
            {
                return leftValue - rightValue;
            }
            else if(root.Value == -3)
            {
                return leftValue / rightValue;
            }
            return leftValue * rightValue;
        }
    }
}
