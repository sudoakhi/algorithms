using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.BT_EvaluateExpressionTree
{
    internal class Algorithm
    {
        public static int EvaluateExpressionTree(BinaryTreeNode root)
        {
            if(root.Value >= 0)
            {
                return root.Value;
            }

            int leftValue = EvaluateExpressionTree(root.Left);
            int rightValue = EvaluateExpressionTree(root.Right);
            if(root.Value == -1)
            {
                return leftValue + rightValue;
            } else if(root.Value == -2) 
            {
                return leftValue - rightValue;
            } else if(root.Value == -3)
            {
                return leftValue/rightValue;
            }
            return leftValue * rightValue;
        }
    }
}
