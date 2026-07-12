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

namespace LeetCode.Algorithms.NumberOfGoodPairs;

/// <summary>
///     https://leetcode.com/problems/number-of-good-pairs/
/// </summary>
public interface INumberOfGoodPairs
{
    /// <summary>
    ///     Counts the number of good pairs in <paramref name="nums" />, where a pair (i, j) is good if
    ///     <c>nums[i] == nums[j]</c> and <c>i &lt; j</c>.
    /// </summary>
    /// <param name="nums">The array of integers to search for good pairs.</param>
    /// <returns>The number of good pairs found in <paramref name="nums" />.</returns>
    int NumIdenticalPairs(int[] nums);
}