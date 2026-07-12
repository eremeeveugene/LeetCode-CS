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

namespace LeetCode.Algorithms.IntersectionOfTwoArrays;

/// <summary>
///     https://leetcode.com/problems/intersection-of-two-arrays/description/
/// </summary>
public interface IIntersectionOfTwoArrays
{
    /// <summary>
    ///     Computes the intersection of <paramref name="nums1" /> and <paramref name="nums2" />, where each element in the
    ///     result is unique.
    /// </summary>
    /// <param name="nums1">The first array of integers.</param>
    /// <param name="nums2">The second array of integers.</param>
    /// <returns>An array of the unique elements that appear in both arrays.</returns>
    int[] Intersection(int[] nums1, int[] nums2);
}