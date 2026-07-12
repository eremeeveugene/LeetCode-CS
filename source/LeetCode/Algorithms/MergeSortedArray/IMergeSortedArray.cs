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

namespace LeetCode.Algorithms.MergeSortedArray;

/// <summary>
///     https://leetcode.com/problems/merge-sorted-array/description/
/// </summary>
public interface IMergeSortedArray
{
    /// <summary>
    ///     Merges the first <paramref name="m" /> elements of <paramref name="nums1" /> with the first
    ///     <paramref name="n" /> elements of <paramref name="nums2" /> into <paramref name="nums1" /> as a single,
    ///     sorted array.
    /// </summary>
    /// <param name="nums1">The destination array, sized to hold <paramref name="m" /> + <paramref name="n" /> elements.</param>
    /// <param name="m">The number of initialized elements in <paramref name="nums1" />.</param>
    /// <param name="nums2">The second sorted array to merge in.</param>
    /// <param name="n">The number of initialized elements in <paramref name="nums2" />.</param>
    void Merge(int[] nums1, int m, int[] nums2, int n);
}