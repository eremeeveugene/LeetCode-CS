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

namespace LeetCode.Algorithms.MaximumDepthOfBinaryTree;

/// <inheritdoc />
public class MaximumDepthOfBinaryTreeBreadthFirstSearch : IMaximumDepthOfBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var maxDepth = 0;

        var queue = new Queue<(TreeNode, int)>();

        queue.Enqueue((root, 1));

        while (queue.Count > 0)
        {
            var (treeNode, depth) = queue.Dequeue();

            if (treeNode.left == null && treeNode.right == null)
            {
                maxDepth = Math.Max(maxDepth, depth);
            }
            else
            {
                depth++;

                if (treeNode.left != null)
                {
                    queue.Enqueue((treeNode.left, depth));
                }

                if (treeNode.right != null)
                {
                    queue.Enqueue((treeNode.right, depth));
                }
            }
        }

        return maxDepth;
    }
}