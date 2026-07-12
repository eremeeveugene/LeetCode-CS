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

namespace LeetCode.Algorithms.GuessNumberHigherOrLower;

/// <summary>
///     https://leetcode.com/problems/guess-number-higher-or-lower/description/
/// </summary>
public interface IGuessNumberHigherOrLower
{
    /// <summary>
    ///     Finds the picked number between 1 and <paramref name="n" /> using the guess API, which reports whether a guess is
    ///     higher than, lower than, or equal to the picked number.
    /// </summary>
    /// <param name="n">The upper bound of the range to guess from.</param>
    /// <returns>The picked number.</returns>
    int GuessNumber(int n);
}