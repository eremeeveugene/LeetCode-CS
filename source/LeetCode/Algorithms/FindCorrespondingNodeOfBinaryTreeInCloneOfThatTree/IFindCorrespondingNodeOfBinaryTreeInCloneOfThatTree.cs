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

namespace LeetCode.Algorithms.FindCorrespondingNodeOfBinaryTreeInCloneOfThatTree;

/// <summary>
///     https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/description
/// </summary>
public interface IFindCorrespondingNodeOfBinaryTreeInCloneOfThatTree
{
    /// <summary>
    ///     Finds the node in <paramref name="cloned" /> that corresponds to <paramref name="target" /> in
    ///     <paramref name="original" />, given that <paramref name="cloned" /> is an exact structural copy of
    ///     <paramref name="original" />.
    /// </summary>
    /// <param name="original">The root node of the original binary tree.</param>
    /// <param name="cloned">The root node of the cloned binary tree.</param>
    /// <param name="target">The node in <paramref name="original" /> whose counterpart is being searched for.</param>
    /// <returns>The node in <paramref name="cloned" /> corresponding to <paramref name="target" />.</returns>
    TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target);
}