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

namespace LeetCode.Algorithms.MaximumElementAfterDecreasingAndRearranging;

/// <summary>
///     https://leetcode.com/problems/maximum-element-after-decreasing-and-rearranging/description/
/// </summary>
public interface IMaximumElementAfterDecreasingAndRearranging
{
    /// <summary>
    ///     Returns the maximum possible value of the last element after decreasing and rearranging
    ///     <paramref name="arr" /> so that the first element is 1 and the absolute difference between any two adjacent
    ///     elements is at most 1.
    /// </summary>
    /// <param name="arr">The array of positive integers to decrease and rearrange.</param>
    /// <returns>The maximum possible value of the largest element after the operations.</returns>
    int MaximumElementAfterDecrementingAndRearranging(int[] arr);
}