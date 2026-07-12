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

namespace LeetCode.Algorithms.SumOfRootToLeafBinaryNumbers;

/// <summary>
///     https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/description/
/// </summary>
public interface ISumOfRootToLeafBinaryNumbers
{
    /// <summary>
    ///     Interprets each root-to-leaf path in the binary tree rooted at <paramref name="root" /> as a binary
    ///     number and sums all such numbers.
    /// </summary>
    /// <param name="root">The root of the binary tree, whose node values are either 0 or 1.</param>
    /// <returns>The sum of the binary numbers represented by all root-to-leaf paths.</returns>
    int SumRootToLeaf(TreeNode root);
}