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

namespace LeetCode.Algorithms.EvenOddTree;

/// <summary>
///     https://leetcode.com/problems/even-odd-tree/
/// </summary>
public interface IEvenOddTree
{
    /// <summary>
    ///     Determines whether the binary tree rooted at <paramref name="root" /> is an even-odd tree, where even-indexed
    ///     levels contain strictly increasing odd values and odd-indexed levels contain strictly decreasing even values.
    /// </summary>
    /// <param name="root">The root node of the binary tree.</param>
    /// <returns><c>true</c> if the tree is an even-odd tree; otherwise, <c>false</c>.</returns>
    bool IsEvenOddTree(TreeNode? root);
}