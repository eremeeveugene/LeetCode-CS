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

namespace LeetCode.Algorithms.LowestCommonAncestorOfDeepestLeaves;

/// <inheritdoc />
public sealed class LowestCommonAncestorOfDeepestLeavesDepthFirstSearch : ILowestCommonAncestorOfDeepestLeaves
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public TreeNode LcaDeepestLeaves(TreeNode root)
    {
        return FindLcaDeepestLeaves(root).TreeNode!;
    }

    private static (TreeNode? TreeNode, int Depth) FindLcaDeepestLeaves(TreeNode? root)
    {
        if (root == null)
        {
            return (null, 0);
        }

        var left = FindLcaDeepestLeaves(root.left);
        var right = FindLcaDeepestLeaves(root.right);

        if (left.Depth > right.Depth)
        {
            return (left.TreeNode, left.Depth + 1);
        }

        return right.Depth > left.Depth ? (right.TreeNode, right.Depth + 1) : (root, left.Depth + 1);
    }
}