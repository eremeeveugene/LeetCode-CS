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

namespace LeetCode.Algorithms.NeitherMinimumNorMaximum;

/// <summary>
///     https://leetcode.com/problems/neither-minimum-nor-maximum/description/
/// </summary>
public interface INeitherMinimumNorMaximum
{
    /// <summary>
    ///     Finds any value in <paramref name="nums" /> that is neither the minimum nor the maximum value in the
    ///     array.
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>A value from <paramref name="nums" /> that is neither the minimum nor the maximum, or -1 if no such value exists.</returns>
    int FindNonMinOrMax(int[] nums);
}