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

namespace LeetCode.Algorithms.MaximumDistanceBetweenPairOfValues;

/// <summary>
///     https://leetcode.com/problems/maximum-distance-between-a-pair-of-values/description/
/// </summary>
public interface IMaximumDistanceBetweenPairOfValues
{
    /// <summary>
    ///     Returns the maximum distance j - i among all valid pairs (i, j)
    ///     where i <= j and <paramref name="nums1" />[i] <= <paramref name="nums2" />[j],
    ///     or <c>0</c> if no valid pair exists.
    /// </summary>
    /// <param name="nums1">A non-increasing array of integers.</param>
    /// <param name="nums2">A non-increasing array of integers.</param>
    /// <returns>
    ///     The maximum distance j - i for any valid pair, or <c>0</c>.
    /// </returns>
    int MaxDistance(int[] nums1, int[] nums2);
}