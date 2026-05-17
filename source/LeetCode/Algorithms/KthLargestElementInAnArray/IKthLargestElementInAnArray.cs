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

namespace LeetCode.Algorithms.KthLargestElementInAnArray;

/// <summary>
///     https://leetcode.com/problems/kth-largest-element-in-an-array/description/
/// </summary>
public interface IKthLargestElementInAnArray
{
    /// <summary>
    ///     Finds the kth largest value in the integer array.
    /// </summary>
    /// <param name="nums">The integer array to search in.</param>
    /// <param name="k">The one-based position of the largest value to find.</param>
    /// <returns>The kth largest value in the array.</returns>
    int FindKthLargest(int[] nums, int k);
}