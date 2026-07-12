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

namespace LeetCode.Algorithms.CountSubarraysOfLengthThreeWithCondition;

/// <summary>
///     https://leetcode.com/problems/count-subarrays-of-length-three-with-a-condition/description/
/// </summary>
public interface ICountSubarraysOfLengthThreeWithCondition
{
    /// <summary>
    ///     Counts the subarrays of <paramref name="nums" /> of length three where the sum of the first and third
    ///     elements equals exactly half of the second element.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <returns>The number of subarrays of length three that satisfy the condition.</returns>
    int CountSubarrays(int[] nums);
}