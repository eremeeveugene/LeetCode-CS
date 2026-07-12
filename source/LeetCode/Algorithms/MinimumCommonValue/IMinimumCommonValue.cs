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

namespace LeetCode.Algorithms.MinimumCommonValue;

/// <summary>
///     https://leetcode.com/problems/minimum-common-value/
/// </summary>
public interface IMinimumCommonValue
{
    /// <summary>
    ///     Finds the minimum integer that is common to both sorted arrays <paramref name="nums1" /> and
    ///     <paramref name="nums2" />.
    /// </summary>
    /// <param name="nums1">The first sorted array.</param>
    /// <param name="nums2">The second sorted array.</param>
    /// <returns>The smallest value present in both arrays, or -1 if there is no common value.</returns>
    int GetCommon(int[] nums1, int[] nums2);
}