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

namespace LeetCode.Algorithms.MinimumMovesToEqualArrayElements;

/// <summary>
///     https://leetcode.com/problems/minimum-moves-to-equal-array-elements/description/
/// </summary>
public interface IMinimumMovesToEqualArrayElements
{
    /// <summary>
    ///     Finds the minimum number of moves, each incrementing <c>n - 1</c> elements of <paramref name="nums" /> by 1,
    ///     required to make all elements equal.
    /// </summary>
    /// <param name="nums">The array of integers to equalize.</param>
    /// <returns>The minimum number of moves required.</returns>
    int MinMoves(int[] nums);
}