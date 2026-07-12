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

namespace LeetCode.Algorithms.MergeTwoBinaryTrees;

/// <summary>
///     https://leetcode.com/problems/merge-two-binary-trees/
/// </summary>
public interface IMergeTwoBinaryTrees
{
    /// <summary>
    ///     Merges the two binary trees rooted at <paramref name="root1" /> and <paramref name="root2" /> by summing
    ///     overlapping node values, keeping any node that has no overlapping counterpart.
    /// </summary>
    /// <param name="root1">The root of the first binary tree.</param>
    /// <param name="root2">The root of the second binary tree.</param>
    /// <returns>The root of the merged binary tree.</returns>
    TreeNode? MergeTrees(TreeNode? root1, TreeNode? root2);
}