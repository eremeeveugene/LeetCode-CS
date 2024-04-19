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
public class MaximumDepthOfBinaryTreeDepthFirstSearch : IMaximumDepthOfBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(log n) for a balanced tree, O(n) for a skewed tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepth(TreeNode? root)
    {
        return root == null ? 0 : GetDepth(root, 1);
    }

    private static int GetDepth(TreeNode? root, int depth)
    {
        if (root == null || (root.left == null && root.right == null))
        {
            return depth;
        }

        depth++;

        return Math.Max(GetDepth(root.left, depth), GetDepth(root.right, depth));
    }
}