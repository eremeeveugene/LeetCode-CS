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

namespace LeetCode.Algorithms.BagOfTokens;

/// <summary>
///     https://leetcode.com/problems/bag-of-tokens/description/
/// </summary>
public interface IBagOfTokens
{
    /// <summary>
    ///     Plays the <paramref name="tokens" /> face up or down, starting with the given <paramref name="power" />, to
    ///     maximize the final score.
    /// </summary>
    /// <param name="tokens">The values of the tokens available to play.</param>
    /// <param name="power">The starting power available to spend on playing tokens face up.</param>
    /// <returns>The maximum score achievable by playing the tokens optimally.</returns>
    int BagOfTokensScore(int[] tokens, int power);
}