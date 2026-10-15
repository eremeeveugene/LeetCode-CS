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

namespace LeetCode.Algorithms.SubarraysDistinctElementSumOfSquares1;

/// <summary>
///     https://leetcode.com/problems/subarrays-distinct-element-sum-of-squares-i/description/
/// </summary>
public interface ISubarraysDistinctElementSumOfSquares1
{
    /// <summary>
    ///     Calculates the sum of the squares of the distinct counts of all subarrays of nums.
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>The sum of the squares of the distinct counts of all subarrays.</returns>
    int SumCounts(IList<int> nums);
}