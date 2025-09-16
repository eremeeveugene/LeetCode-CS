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

namespace LeetCode.Algorithms.HeightOfBinaryTreeAfterSubtreeRemovalQueries;

/// <summary>
///     https://leetcode.com/problems/height-of-binary-tree-after-subtree-removal-queries/description/
/// </summary>
public interface IHeightOfBinaryTreeAfterSubtreeRemovalQueries
{
    int[] TreeQueries(TreeNode root, int[] queries);
}