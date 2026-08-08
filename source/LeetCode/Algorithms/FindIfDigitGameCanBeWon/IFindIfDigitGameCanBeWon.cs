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

namespace LeetCode.Algorithms.FindIfDigitGameCanBeWon;

/// <summary>
///     https://leetcode.com/problems/find-if-digit-game-can-be-won/description/
/// </summary>
public interface IFindIfDigitGameCanBeWon
{
    /// <summary>
    ///     Determines whether Alice can win the digit game by choosing either all single-digit numbers or all
    ///     double-digit numbers from <paramref name="nums" />, leaving the rest to Bob.
    /// </summary>
    /// <param name="nums">The array of positive integers to split between Alice and Bob.</param>
    /// <returns>
    ///     <see langword="true" /> if the sum of single-digit numbers differs from the sum of double-digit numbers
    ///     in <paramref name="nums" />; otherwise, <see langword="false" />.
    /// </returns>
    bool CanAliceWin(int[] nums);
}