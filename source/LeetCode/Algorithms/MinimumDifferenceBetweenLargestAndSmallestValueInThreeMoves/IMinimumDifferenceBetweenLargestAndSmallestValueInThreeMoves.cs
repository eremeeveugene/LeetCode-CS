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

namespace LeetCode.Algorithms.MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves;

/// <summary>
///     https://leetcode.com/problems/minimum-difference-between-largest-and-smallest-value-in-three-moves/description/
/// </summary>
public interface IMinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves
{
    /// <summary>
    ///     Changes at most three elements of <paramref name="nums" /> to any values, in up to three moves, to
    ///     minimize the difference between the largest and smallest values in the array.
    /// </summary>
    /// <param name="nums">The array of integers to adjust.</param>
    /// <returns>The minimum possible difference between the largest and smallest values after at most three moves.</returns>
    int MinDifference(int[] nums);
}