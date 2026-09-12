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

namespace LeetCode.Algorithms.CountCommasInRange2;

/// <summary>
///     https://leetcode.com/problems/count-commas-in-range-ii/description/
/// </summary>
public interface ICountCommasInRange2
{
    /// <summary>
    ///     Counts commas used when formatting all integers from 1 through n.
    /// </summary>
    /// <param name="n">The inclusive upper bound, between 1 and 10^15.</param>
    /// <returns>The total number of commas, with digit groups separated every three digits from the right.</returns>
    long CountCommas(long n);
}