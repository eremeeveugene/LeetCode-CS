// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Algorithms.SmallestSubtreeWithAllTheDeepestNodes;

/// <summary>
///     https://leetcode.com/problems/smallest-subtree-with-all-the-deepest-nodes/description/
/// </summary>
public interface ISmallestSubtreeWithAllTheDeepestNodes
{
    TreeNode SubtreeWithAllDeepest(TreeNode root);
}