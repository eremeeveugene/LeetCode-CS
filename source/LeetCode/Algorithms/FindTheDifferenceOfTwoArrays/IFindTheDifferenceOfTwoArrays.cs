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

namespace LeetCode.Algorithms.FindTheDifferenceOfTwoArrays;

/// <summary>
///     https://leetcode.com/problems/find-the-difference-of-two-arrays/
/// </summary>
public interface IFindTheDifferenceOfTwoArrays
{
    /// <summary>
    ///     Finds the distinct integers of <paramref name="nums1" /> that are not present in <paramref name="nums2" /> and the
    ///     distinct integers of <paramref name="nums2" /> that are not present in <paramref name="nums1" />.
    /// </summary>
    /// <param name="nums1">The first array of integers.</param>
    /// <param name="nums2">The second array of integers.</param>
    /// <returns>A list of two lists containing the distinct integers unique to each array.</returns>
    IList<IList<int>> FindDifference(int[] nums1, int[] nums2);
}