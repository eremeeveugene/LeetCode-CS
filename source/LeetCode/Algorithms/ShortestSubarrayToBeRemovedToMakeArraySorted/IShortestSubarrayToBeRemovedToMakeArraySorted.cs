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

namespace LeetCode.Algorithms.ShortestSubarrayToBeRemovedToMakeArraySorted;

/// <summary>
///     https://leetcode.com/problems/shortest-subarray-to-be-removed-to-make-array-sorted/description/
/// </summary>
public interface IShortestSubarrayToBeRemovedToMakeArraySorted
{
    /// <summary>
    ///     Finds the length of the shortest contiguous subarray of <paramref name="arr" /> that can be removed
    ///     so that the remaining elements are sorted in non-decreasing order.
    /// </summary>
    /// <param name="arr">The array of integers to process.</param>
    /// <returns>The length of the shortest subarray whose removal leaves <paramref name="arr" /> sorted.</returns>
    int FindLengthOfShortestSubarray(int[] arr);
}