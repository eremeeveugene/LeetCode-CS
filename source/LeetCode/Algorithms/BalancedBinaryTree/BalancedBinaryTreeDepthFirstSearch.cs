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

namespace LeetCode.Algorithms.BalancedBinaryTree;

/// <inheritdoc />
public class BalancedBinaryTreeDepthFirstSearch : IBalancedBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(log n) for a balanced tree, O(n) for a skewed tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsBalanced(TreeNode? root)
    {
        return root == null || IsBalanced(root, out _);
    }

    private static bool IsBalanced(TreeNode? root, out int height)
    {
        if (root == null)
        {
            height = 0;

            return true;
        }

        var leftIsBalanced = IsBalanced(root.left, out var leftHeight);
        var rightIsBalanced = IsBalanced(root.right, out var rightHeight);

        height = 1 + Math.Max(leftHeight, rightHeight);

        if (!leftIsBalanced || !rightIsBalanced)
        {
            return false;
        }

        return Math.Abs(leftHeight - rightHeight) <= 1;
    }
}