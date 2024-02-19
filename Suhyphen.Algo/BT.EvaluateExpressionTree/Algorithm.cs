using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.BT.EvaluateExpressionTree
{
    public sealed class Algorithm
    {
        public static int EvaluateExpressionTree(BinaryTreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            if (root._value >= 0)
            {
                return root._value;
            }

            var leftValue = EvaluateExpressionTree(root._left);
            var rightValue = EvaluateExpressionTree(root._right);
            if(root._value == -1)
            {
                return leftValue + rightValue;
            } else if(root._value == -2) 
            {
                return leftValue - rightValue;
            } else if(root._value == -3)
            {
                return leftValue/rightValue;
            }
            return leftValue * rightValue;
        }
    }
}
