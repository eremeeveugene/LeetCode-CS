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

namespace LeetCode.Algorithms.MakeTwoArraysEqualByReversingSubarrays;

/// <summary>
///     https://leetcode.com/problems/make-two-arrays-equal-by-reversing-subarrays/description/
/// </summary>
public interface IMakeTwoArraysEqualByReversingSubarrays
{
    /// <summary>
    ///     Determines whether <paramref name="arr" /> can be made equal to <paramref name="target" /> by reversing any
    ///     number of its subarrays.
    /// </summary>
    /// <param name="target">The array that <paramref name="arr" /> should be transformed into.</param>
    /// <param name="arr">The array to transform via subarray reversals.</param>
    /// <returns><see langword="true" /> if <paramref name="arr" /> can be made equal to <paramref name="target" />; otherwise, <see langword="false" />.</returns>
    bool CanBeEqual(int[] target, int[] arr);
}