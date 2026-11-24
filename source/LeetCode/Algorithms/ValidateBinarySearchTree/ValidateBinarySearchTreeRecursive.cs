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

namespace LeetCode.Algorithms.ValidateBinarySearchTree;

/// <inheritdoc />
public sealed class ValidateBinarySearchTreeRecursive : IValidateBinarySearchTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h)
    /// </remarks>
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, long.MinValue, long.MaxValue);
    }

    /// <summary>
    ///     Determines whether every value in the subtree rooted at <paramref name="node" /> lies strictly between
    ///     <paramref name="lowerBound" /> and <paramref name="upperBound" /> and the subtree is a valid binary search tree.
    /// </summary>
    /// <param name="node">The root node of the subtree to validate.</param>
    /// <param name="lowerBound">The exclusive lower bound for every value in the subtree.</param>
    /// <param name="upperBound">The exclusive upper bound for every value in the subtree.</param>
    /// <returns><see langword="true" /> if the subtree is a valid binary search tree within the bounds; otherwise, <see langword="false" />.</returns>
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h)
    /// </remarks>
    private static bool IsValidBST(TreeNode? node, long lowerBound, long upperBound)
    {
        if (node is null)
        {
            return true;
        }

        if (node.val <= lowerBound || node.val >= upperBound)
        {
            return false;
        }

        return IsValidBST(node.left, lowerBound, node.val) && IsValidBST(node.right, node.val, upperBound);
    }
}