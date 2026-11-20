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

namespace LeetCode.Algorithms.AverageOfLevelsInBinaryTree;

/// <summary>
///     https://leetcode.com/problems/average-of-levels-in-binary-tree/description/
/// </summary>
public interface IAverageOfLevelsInBinaryTree
{
    /// <summary>
    ///     Calculates the average value of the nodes on each level of the binary tree rooted at
    ///     <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root node of the binary tree.</param>
    /// <returns>The average node value of each level, ordered from the root level downwards.</returns>
    IList<double> AverageOfLevels(TreeNode root);
}