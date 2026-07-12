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

namespace LeetCode.Algorithms.FindTheMinimumAreaToCoverAllOnes1;

/// <summary>
///     https://leetcode.com/problems/find-the-minimum-area-to-cover-all-ones-i/description/
/// </summary>
public interface IFindTheMinimumAreaToCoverAllOnes1
{
    /// <summary>
    ///     Finds the area of the smallest axis-aligned rectangle that covers every cell containing <c>1</c> in <paramref name="grid" />.
    /// </summary>
    /// <param name="grid">The binary grid to examine.</param>
    /// <returns>The area of the smallest rectangle covering all <c>1</c>s.</returns>
    int MinimumArea(int[][] grid);
}