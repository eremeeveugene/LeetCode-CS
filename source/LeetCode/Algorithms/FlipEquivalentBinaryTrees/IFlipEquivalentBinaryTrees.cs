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

namespace LeetCode.Algorithms.FlipEquivalentBinaryTrees;

/// <summary>
///     https://leetcode.com/problems/flip-equivalent-binary-trees/description/
/// </summary>
public interface IFlipEquivalentBinaryTrees
{
    /// <summary>
    ///     Determines whether the binary trees rooted at <paramref name="root1" /> and <paramref name="root2" /> are flip
    ///     equivalent, i.e. one can be obtained from the other by swapping the left and right children of some nodes.
    /// </summary>
    /// <param name="root1">The root of the first binary tree.</param>
    /// <param name="root2">The root of the second binary tree.</param>
    /// <returns><see langword="true" /> if the two trees are flip equivalent; otherwise, <see langword="false" />.</returns>
    bool FlipEquiv(TreeNode? root1, TreeNode? root2);
}