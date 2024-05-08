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

namespace LeetCode.Algorithms.MinimumDepthOfBinaryTree;

/// <inheritdoc />
public class MinimumDepthOfBinaryTreeBreadthFirstSearch : IMinimumDepthOfBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MinDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var minDepth = int.MaxValue;

        var nodeDepthQueue = new Queue<(TreeNode node, int depth)>();

        nodeDepthQueue.Enqueue((root, 1));

        while (nodeDepthQueue.Count > 0)
        {
            var (node, depth) = nodeDepthQueue.Dequeue();

            if (depth > minDepth)
            {
                continue;
            }

            if (node.left == null && node.right == null)
            {
                minDepth = Math.Min(minDepth, depth);
            }

            if (node.left != null)
            {
                nodeDepthQueue.Enqueue((node.left, depth + 1));
            }

            if (node.right != null)
            {
                nodeDepthQueue.Enqueue((node.right, depth + 1));
            }
        }

        return minDepth;
    }
}