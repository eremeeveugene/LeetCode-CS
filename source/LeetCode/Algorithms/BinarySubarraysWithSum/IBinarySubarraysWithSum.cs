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

namespace LeetCode.Algorithms.BinarySubarraysWithSum;

/// <summary>
///     https://leetcode.com/problems/binary-subarrays-with-sum/
/// </summary>
public interface IBinarySubarraysWithSum
{
    /// <summary>
    ///     Counts the non-empty subarrays of the binary array <paramref name="nums" /> whose sum equals
    ///     <paramref name="goal" />.
    /// </summary>
    /// <param name="nums">The binary array.</param>
    /// <param name="goal">The target subarray sum.</param>
    /// <returns>The number of non-empty subarrays with a sum equal to <paramref name="goal" />.</returns>
    int NumSubarraysWithSum(int[] nums, int goal);
}