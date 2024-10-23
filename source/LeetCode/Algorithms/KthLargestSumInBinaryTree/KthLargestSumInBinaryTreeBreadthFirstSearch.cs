// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.KthLargestSumInBinaryTree;

/// <inheritdoc />
public class KthLargestSumInBinaryTreeBreadthFirstSearch : IKthLargestSumInBinaryTree
{
    public long KthLargestLevelSum(TreeNode root, int k)
    {
        var nodesQueue = new Queue<TreeNode>();

        nodesQueue.Enqueue(root);

        var sumsPriorityQueue = new PriorityQueue<long, long>();

        while (nodesQueue.Count > 0)
        {
            var levelCount = nodesQueue.Count;

            long sum = 0;

            for (var j = 0; j < levelCount; j++)
            {
                var node = nodesQueue.Dequeue();

                sum += node.val;

                if (node.left != null)
                {
                    nodesQueue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    nodesQueue.Enqueue(node.right);
                }
            }

            sumsPriorityQueue.Enqueue(sum, sum);

            if (sumsPriorityQueue.Count > k)
            {
                sumsPriorityQueue.Dequeue();
            }
        }

        if (sumsPriorityQueue.Count < k)
        {
            return -1;
        }

        return sumsPriorityQueue.Dequeue();
    }
}