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

namespace LeetCode.Algorithms.MinimumEqualSumOfTwoArraysAfterReplacingZeros;

/// <summary>
///     https://leetcode.com/problems/minimum-equal-sum-of-two-arrays-after-replacing-zeros/description/
/// </summary>
public interface IMinimumEqualSumOfTwoArraysAfterReplacingZeros
{
    /// <summary>
    ///     Replaces every 0 in <paramref name="nums1" /> and <paramref name="nums2" /> with a strictly positive
    ///     integer so that the sums of both arrays are equal, and finds the minimum possible value of that common
    ///     sum.
    /// </summary>
    /// <param name="nums1">The first array of non-negative integers.</param>
    /// <param name="nums2">The second array of non-negative integers.</param>
    /// <returns>The minimum equal sum achievable, or -1 if it is impossible.</returns>
    long MinSum(int[] nums1, int[] nums2);
}