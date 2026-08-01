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

namespace LeetCode.Algorithms.FindTheNumberOfDistinctColorsAmongTheBalls;

/// <summary>
///     https://leetcode.com/problems/find-the-number-of-distinct-colors-among-the-balls/description/
/// </summary>
public interface IFindTheNumberOfDistinctColorsAmongTheBalls
{
    /// <summary>
    ///     Processes <paramref name="queries" /> in order, assigning a color to a ball, and after each query records the number of distinct colors currently
    ///     used among all colored balls in the range <c>[0, limit]</c>.
    /// </summary>
    /// <param name="limit">The maximum ball index, defining the range <c>[0, limit]</c>.</param>
    /// <param name="queries">The array of queries, each specifying a ball index and the color to assign to it.</param>
    /// <returns>An array where each element is the number of distinct colors after the corresponding query.</returns>
    int[] QueryResults(int limit, int[][] queries);
}