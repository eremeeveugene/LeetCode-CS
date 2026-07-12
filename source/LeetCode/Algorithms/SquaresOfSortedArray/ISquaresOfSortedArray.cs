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

namespace LeetCode.Algorithms.SquaresOfSortedArray;

/// <summary>
///     https://leetcode.com/problems/squares-of-a-sorted-array/description/
/// </summary>
public interface ISquaresOfSortedArray
{
    /// <summary>
    ///     Squares each element of the non-decreasing sorted array <paramref name="nums" /> and returns the
    ///     squares sorted in non-decreasing order.
    /// </summary>
    /// <param name="nums">The sorted array of integers to square.</param>
    /// <returns>A new array containing the squares of <paramref name="nums" />, sorted in non-decreasing order.</returns>
    int[] SortedSquares(int[] nums);
}