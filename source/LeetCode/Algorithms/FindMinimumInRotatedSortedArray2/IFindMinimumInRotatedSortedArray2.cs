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

namespace LeetCode.Algorithms.FindMinimumInRotatedSortedArray2;

/// <summary>
///     https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/description/
/// </summary>
public interface IFindMinimumInRotatedSortedArray2
{
    /// <summary>
    ///     Finds the minimum value in a rotated sorted array that may contain duplicate values.
    /// </summary>
    /// <param name="nums">The rotated sorted integer array to search in.</param>
    /// <returns>The minimum value in the rotated sorted array.</returns>
    int FindMin(int[] nums);
}