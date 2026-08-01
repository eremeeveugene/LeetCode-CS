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

namespace LeetCode.Algorithms.PredictTheWinner;

/// <summary>
///     https://leetcode.com/problems/predict-the-winner/description/
/// </summary>
public interface IPredictTheWinner
{
    /// <summary>
    ///     Determines whether player 1, who moves first and alternates turns with player 2 taking numbers from
    ///     either end of <paramref name="nums" /> with both playing optimally, can win the game, where a tied
    ///     score also counts as a win for player 1.
    /// </summary>
    /// <param name="nums">The array of numbers available to be picked from either end.</param>
    /// <returns><see langword="true" /> if player 1 wins or ties; otherwise, <see langword="false" />.</returns>
    bool PredictTheWinner(int[] nums);
}