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

namespace LeetCode.Algorithms.AbsoluteDifferenceBetweenMaximumAndMinimumKElements;

/// <summary>
///     https://leetcode.com/problems/absolute-difference-between-maximum-and-minimum-k-elements/description/
/// </summary>
public interface IAbsoluteDifferenceBetweenMaximumAndMinimumKElements
{
    /// <summary>
    ///     Computes the absolute difference between the sum of the <paramref name="k" /> largest elements and the sum of
    ///     the <paramref name="k" /> smallest elements of <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="k">The number of maximum and minimum elements to sum.</param>
    /// <returns>The absolute difference between the sum of the <paramref name="k" /> largest and <paramref name="k" /> smallest elements.</returns>
    int AbsDifference(int[] nums, int k);
}