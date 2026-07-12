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

namespace LeetCode.Algorithms.FindCommonElementsBetweenTwoArrays;

/// <summary>
///     https://leetcode.com/problems/find-common-elements-between-two-arrays/description/
/// </summary>
public interface IFindCommonElementsBetweenTwoArrays
{
    /// <summary>
    ///     Counts, for each array, how many of its elements also appear in the other array.
    /// </summary>
    /// <param name="nums1">The first array of integers.</param>
    /// <param name="nums2">The second array of integers.</param>
    /// <returns>
    ///     A two-element array where the first value is the count of elements of <paramref name="nums1" /> that also
    ///     appear in <paramref name="nums2" />, and the second value is the count of elements of <paramref name="nums2" />
    ///     that also appear in <paramref name="nums1" />.
    /// </returns>
    int[] FindIntersectionValues(int[] nums1, int[] nums2);
}