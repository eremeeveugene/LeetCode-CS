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

namespace LeetCode.Algorithms.LetterTilePossibilities;

/// <summary>
///     https://leetcode.com/problems/letter-tile-possibilities/description/
/// </summary>
public interface ILetterTilePossibilities
{
    /// <summary>
    ///     Counts the number of distinct non-empty sequences of letters that can be formed using the letter tiles in <paramref name="tiles" />.
    /// </summary>
    /// <param name="tiles">The string of letter tiles available to arrange.</param>
    /// <returns>The number of distinct non-empty sequences that can be formed.</returns>
    int NumTilePossibilities(string tiles);
}