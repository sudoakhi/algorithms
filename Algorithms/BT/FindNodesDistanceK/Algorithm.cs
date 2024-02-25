// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BT.FindNodesDistanceK
{
    public static class Algorithm
    {
        public static List<int> Run(BinaryTreeNode root, int target, int k)
        {
            var result = new List<int>();
            var queue = new Queue<BinaryTreeNode>();
            var nodeParentMap = new Dictionary<BinaryTreeNode, BinaryTreeNode>();
            BinaryTreeNode targetNode = null;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                if(currentNode.Value == target)
                {
                    targetNode = currentNode;
                }

                if(currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                    nodeParentMap.Add(currentNode.Left, currentNode);
                }

                if(currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                    nodeParentMap.Add(currentNode.Right, currentNode);
                }
            }

            var isNodeVisited = new Dictionary<BinaryTreeNode, int>();
            queue.Enqueue(targetNode);
            var lengthFromTargetNode = 0;
            while (queue.Count > 0)
            {
                var queueCount = queue.Count;
                for(var i=0; i< queueCount; i++)
                {
                    var currentNode = queue.Dequeue();
                    isNodeVisited[currentNode] = 1;
                    if(lengthFromTargetNode == k)
                    {
                        result.Add(currentNode.Value);
                    }

                    if(currentNode.Left != null && isNodeVisited.GetValueOrDefault(currentNode.Left, 0) == 0)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if(currentNode.Right != null && isNodeVisited.GetValueOrDefault(currentNode.Right, 0) == 0)
                    {
                        queue.Enqueue(currentNode.Right);
                    }

                    if(nodeParentMap.TryGetValue(currentNode, out var value) && isNodeVisited.GetValueOrDefault(nodeParentMap[currentNode], 0) == 0)
                    {
                        queue.Enqueue(value);
                    }
                }

                lengthFromTargetNode++;
                if(lengthFromTargetNode > k)
                {
                    break;
                }
            }

            return result;
        }
    }
}
