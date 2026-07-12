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

namespace LeetCode.Algorithms.SumRootToLeafNumbers;

/// <summary>
///     https://leetcode.com/problems/sum-root-to-leaf-numbers/
/// </summary>
public interface ISumRootToLeafNumbers
{
    /// <summary>
    ///     Interprets each root-to-leaf path in the binary tree rooted at <paramref name="root" /> as a decimal
    ///     number formed by concatenating the digits along the path and sums all such numbers.
    /// </summary>
    /// <param name="root">The root of the binary tree, whose node values are digits from 0 to 9.</param>
    /// <returns>The sum of all root-to-leaf numbers.</returns>
    int SumNumbers(TreeNode? root);
}