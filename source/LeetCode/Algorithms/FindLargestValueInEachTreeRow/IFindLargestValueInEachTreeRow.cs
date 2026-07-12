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

namespace LeetCode.Algorithms.FindLargestValueInEachTreeRow;

/// <summary>
///     https://leetcode.com/problems/find-largest-value-in-each-tree-row/description/
/// </summary>
public interface IFindLargestValueInEachTreeRow
{
    /// <summary>
    ///     Finds the largest value in each row of the binary tree rooted at <paramref name="root" />.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <returns>The list of the largest values of each row, ordered from the root level down.</returns>
    IList<int> LargestValues(TreeNode? root);
}