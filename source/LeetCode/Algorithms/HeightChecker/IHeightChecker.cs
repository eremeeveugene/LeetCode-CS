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

namespace LeetCode.Algorithms.HeightChecker;

/// <summary>
///     https://leetcode.com/problems/height-checker/
/// </summary>
public interface IHeightChecker
{
    /// <summary>
    ///     Counts the indices where <paramref name="heights" /> differs from the expected order, i.e. the same values sorted
    ///     in non-decreasing order.
    /// </summary>
    /// <param name="heights">The current heights of the students in line.</param>
    /// <returns>The number of indices where the current height does not match the expected height.</returns>
    int HeightChecker(int[] heights);
}