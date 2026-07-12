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

namespace LeetCode.Algorithms.SummaryRanges;

/// <summary>
///     https://leetcode.com/problems/summary-ranges/
/// </summary>
public interface ISummaryRanges
{
    /// <summary>
    ///     Groups the sorted, distinct integers in <paramref name="nums" /> into the smallest number of
    ///     contiguous ranges and formats each range as a string.
    /// </summary>
    /// <param name="nums">The sorted array of distinct integers to summarize.</param>
    /// <returns>A list of formatted range strings covering all values in <paramref name="nums" />.</returns>
    IList<string> SummaryRanges(int[] nums);
}