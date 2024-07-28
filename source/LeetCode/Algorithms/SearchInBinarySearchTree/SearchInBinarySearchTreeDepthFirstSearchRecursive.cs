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

namespace LeetCode.Algorithms.SearchInBinarySearchTree;

/// <inheritdoc />
public class SearchInBinarySearchTreeDepthFirstSearchRecursive : ISearchInBinarySearchTree
{
    /// <summary>
    ///     Time complexity - O(n) for a skewed tree, O(log n) for a balanced tree
    ///     Space complexity - O(n) for a skewed tree, O(log n) for a balanced tree
    /// </summary>
    /// <param name="root"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public TreeNode? SearchBST(TreeNode? root, int val)
    {
        if (root == null)
        {
            return null;
        }

        return root.val == val ? root : SearchBST(root.val < val ? root.right : root.left, val);
    }
}