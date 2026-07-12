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

namespace LeetCode.Algorithms.SmallestStringStartingFromLeaf;

/// <summary>
///     https://leetcode.com/problems/smallest-string-starting-from-leaf/
/// </summary>
public interface ISmallestStringStartingFromLeaf
{
    /// <summary>
    ///     Finds the lexicographically smallest string obtained by concatenating the letters (mapped from node
    ///     values 0-25 to 'a'-'z') along a root-to-leaf path in the binary tree rooted at <paramref name="root" />,
    ///     read from leaf to root.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <returns>The lexicographically smallest leaf-to-root string, or <see langword="null" /> if the tree is empty.</returns>
    string? SmallestFromLeaf(TreeNode? root);
}