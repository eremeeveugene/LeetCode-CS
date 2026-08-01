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

namespace LeetCode.Algorithms.FindTheMinimumAreaToCoverAllOnes2;

/// <summary>
///     https://leetcode.com/problems/find-the-minimum-area-to-cover-all-ones-ii/description/
/// </summary>
public interface IFindTheMinimumAreaToCoverAllOnes2
{
    /// <summary>
    ///     Finds the minimum total area of up to three non-overlapping, axis-aligned rectangles needed to cover every cell containing <c>1</c> in
    ///     <paramref name="grid" />.
    /// </summary>
    /// <param name="grid">The binary grid to examine.</param>
    /// <returns>The minimum total area of the rectangles covering all <c>1</c>s.</returns>
    int MinimumSum(int[][] grid);
}