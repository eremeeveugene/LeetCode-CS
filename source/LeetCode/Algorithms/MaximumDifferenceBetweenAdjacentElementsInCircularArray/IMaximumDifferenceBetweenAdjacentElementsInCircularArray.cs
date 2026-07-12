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

namespace LeetCode.Algorithms.MaximumDifferenceBetweenAdjacentElementsInCircularArray;

/// <summary>
///     https://leetcode.com/problems/maximum-difference-between-adjacent-elements-in-a-circular-array/description/
/// </summary>
public interface IMaximumDifferenceBetweenAdjacentElementsInCircularArray
{
    /// <summary>
    ///     Finds the maximum absolute difference between adjacent elements of <paramref name="nums" />, treating the
    ///     array as circular so the last and first elements are also considered adjacent.
    /// </summary>
    /// <param name="nums">The array of integers, treated as circular, to compute adjacent differences for.</param>
    /// <returns>The maximum absolute difference between any two circularly adjacent elements of <paramref name="nums" />.</returns>
    int MaxAdjacentDistance(int[] nums);
}