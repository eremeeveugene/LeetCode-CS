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

namespace LeetCode.Algorithms.SymmetricTree;

/// <inheritdoc />
public sealed class SymmetricTreeRecursive : ISymmetricTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public bool IsSymmetric(TreeNode? root)
    {
        return IsSymmetric(root?.left, root?.right);
    }

    private static bool IsSymmetric(TreeNode? leftNode, TreeNode? rightNode)
    {
        if (leftNode == null && rightNode == null)
        {
            return true;
        }

        if (leftNode == null || rightNode == null)
        {
            return false;
        }

        if (leftNode.val != rightNode.val)
        {
            return false;
        }

        return IsSymmetric(leftNode.left, rightNode.right) && IsSymmetric(leftNode.right, rightNode.left);
    }
}