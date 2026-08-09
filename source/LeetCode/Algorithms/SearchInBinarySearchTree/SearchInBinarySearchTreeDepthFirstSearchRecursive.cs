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

namespace LeetCode.Algorithms.SearchInBinarySearchTree;

/// <inheritdoc />
public sealed class SearchInBinarySearchTreeDepthFirstSearchRecursive : ISearchInBinarySearchTree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n) for a skewed tree, O(log n) for a balanced tree
    ///     Space complexity - O(n) for a skewed tree, O(log n) for a balanced tree
    /// </remarks>
    public TreeNode? SearchBST(TreeNode? root, int val)
    {
        if (root == null)
        {
            return null;
        }

        if (root.val == val)
        {
            return root;
        }

        var next = root.val < val ? root.right : root.left;

        return SearchBST(next, val);
    }
}