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

namespace LeetCode.Algorithms.RootEqualsSumOfChildren;

/// <summary>
///     https://leetcode.com/problems/root-equals-sum-of-children/
/// </summary>
public interface IRootEqualsSumOfChildren
{
    /// <summary>
    ///     Determines whether the value of <paramref name="root" /> equals the sum of the values of its two children.
    /// </summary>
    /// <param name="root">The root of a binary tree with exactly two children.</param>
    /// <returns><see langword="true" /> if the root's value equals the sum of its children's values; otherwise, <see langword="false" />.</returns>
    bool CheckTree(TreeNode root);
}