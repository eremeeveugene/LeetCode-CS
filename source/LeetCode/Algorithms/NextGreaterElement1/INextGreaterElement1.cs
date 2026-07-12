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

namespace LeetCode.Algorithms.NextGreaterElement1;

/// <summary>
///     https://leetcode.com/problems/next-greater-element-i/
/// </summary>
public interface INextGreaterElement1
{
    /// <summary>
    ///     For each element of <paramref name="nums1" />, finds the next greater element that appears to its right
    ///     in <paramref name="nums2" />, where <paramref name="nums1" /> is a subset of <paramref name="nums2" />.
    /// </summary>
    /// <param name="nums1">The array of distinct integers to find next greater elements for.</param>
    /// <param name="nums2">The array of distinct integers in which to search for next greater elements.</param>
    /// <returns>An array where each element is the next greater element in <paramref name="nums2" />, or -1 if none exists.</returns>
    int[] NextGreaterElement(int[] nums1, int[] nums2);
}