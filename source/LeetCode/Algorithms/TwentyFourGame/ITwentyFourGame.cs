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

namespace LeetCode.Algorithms.TwentyFourGame;

/// <summary>
///     https://leetcode.com/problems/24-game/description/
/// </summary>
public interface ITwentyFourGame
{
    /// <summary>
    ///     Determines whether the four numbers in <paramref name="cards" /> can be combined, using each exactly
    ///     once with the operators <c>+</c>, <c>-</c>, <c>*</c>, <c>/</c>, and parentheses, to evaluate to 24.
    /// </summary>
    /// <param name="cards">The array of four numbers between 1 and 9 representing the drawn cards.</param>
    /// <returns><see langword="true" /> if the cards can be combined to make 24; otherwise, <see langword="false" />.</returns>
    bool JudgePoint24(int[] cards);
}