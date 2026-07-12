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

namespace LeetCode.Algorithms.RangeSumOfBST;

/// <summary>
///     https://leetcode.com/problems/range-sum-of-bst/
/// </summary>
public interface IRangeSumOfBST
{
    /// <summary>
    ///     Sums the values of all nodes in the binary search tree rooted at <paramref name="root" /> whose values fall
    ///     between <paramref name="low" /> and <paramref name="high" />, inclusive.
    /// </summary>
    /// <param name="root">The root of the binary search tree.</param>
    /// <param name="low">The lower bound of the value range, inclusive.</param>
    /// <param name="high">The upper bound of the value range, inclusive.</param>
    /// <returns>The sum of node values within the given range.</returns>
    int RangeSumBST(TreeNode? root, int low, int high);
}