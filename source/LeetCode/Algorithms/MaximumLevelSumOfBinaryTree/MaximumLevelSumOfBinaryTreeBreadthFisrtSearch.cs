// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.MaximumLevelSumOfBinaryTree;

/// <inheritdoc />
public sealed class MaximumLevelSumOfBinaryTree1 : IMaximumLevelSumOfBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n), where n is the number of nodes in the binary tree
    ///     Space complexity - O(w), where w is the maximum width of the tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxLevelSum(TreeNode root)
    {
        var maxSum = int.MinValue;
        var minLevel = 1;
        var level = 1;

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var count = queue.Count;

            var sum = 0;

            for (var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();

                sum += node.val;

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                minLevel = level;
            }

            level++;
        }

        return minLevel;
    }
}