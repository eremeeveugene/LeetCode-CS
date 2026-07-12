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

namespace LeetCode.Algorithms.LongestSubarrayWithMaximumBitwiseAND;

/// <summary>
///     https://leetcode.com/problems/longest-subarray-with-maximum-bitwise-and/
/// </summary>
public interface ILongestSubarrayWithMaximumBitwiseAND
{
    /// <summary>
    ///     Finds the length of the longest subarray of <paramref name="nums" /> whose bitwise AND equals the maximum
    ///     possible bitwise AND of any subarray (which is the maximum element of <paramref name="nums" />).
    /// </summary>
    /// <param name="nums">The array of integers to search.</param>
    /// <returns>The length of the longest subarray achieving the maximum bitwise AND.</returns>
    int LongestSubarray(int[] nums);
}