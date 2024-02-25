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

namespace LeetCode.Algorithms.SameTree;

/// <inheritdoc />
public class SameTreeRecursive : ISameTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(log n) for a balanced tree, O(n) for an unbalanced tree
    /// </summary>
    /// <param name="p"></param>
    /// <param name="q"></param>
    /// <returns></returns>
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if (p == null || q == null)
        {
            return false;
        }

        if (p.val != q.val)
        {
            return false;
        }

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}