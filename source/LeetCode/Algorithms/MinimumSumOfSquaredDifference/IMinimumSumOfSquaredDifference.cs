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

namespace LeetCode.Algorithms.MinimumSumOfSquaredDifference;

/// <summary>
///     https://leetcode.com/problems/minimum-sum-of-squared-difference/description/
/// </summary>
public interface IMinimumSumOfSquaredDifference
{
    /// <summary>
    ///     Finds the minimum sum of squared differences between the two arrays after changing elements of the first array
    ///     by at most <paramref name="k1" /> in total and elements of the second array by at most
    ///     <paramref name="k2" /> in total, each change being +1 or -1.
    /// </summary>
    /// <param name="nums1">The first array.</param>
    /// <param name="nums2">The second array.</param>
    /// <param name="k1">The maximum number of +1 or -1 modifications allowed on the first array.</param>
    /// <param name="k2">The maximum number of +1 or -1 modifications allowed on the second array.</param>
    /// <returns>The minimum sum of squared differences.</returns>
    long MinSumSquareDiff(int[] nums1, int[] nums2, int k1, int k2);
}