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

namespace LeetCode.Algorithms.CountNumberOfBadPairs;

/// <summary>
///     /https://leetcode.com/problems/count-number-of-bad-pairs/description/
/// </summary>
public interface ICountNumberOfBadPairs
{
    /// <summary>
    ///     Counts the bad pairs in <paramref name="nums" />, i.e. the index pairs (i, j) with i &lt; j such that j - i is
    ///     not equal to <paramref name="nums" />[j] - <paramref name="nums" />[i].
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The number of bad pairs in the array.</returns>
    long CountBadPairs(int[] nums);
}