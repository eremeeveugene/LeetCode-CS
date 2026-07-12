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

namespace LeetCode.Algorithms.MedianOfTwoSortedArrays;

/// <summary>
///     https://leetcode.com/problems/median-of-two-sorted-arrays/description/
/// </summary>
public interface IMedianOfTwoSortedArrays
{
    /// <summary>
    ///     Finds the median of the combined elements of the two sorted arrays <paramref name="nums1" /> and
    ///     <paramref name="nums2" />.
    /// </summary>
    /// <param name="nums1">The first sorted array.</param>
    /// <param name="nums2">The second sorted array.</param>
    /// <returns>The median value of the merged sorted arrays.</returns>
    double FindMedianSortedArrays(int[] nums1, int[] nums2);
}