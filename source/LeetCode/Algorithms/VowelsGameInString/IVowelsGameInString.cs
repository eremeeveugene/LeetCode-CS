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

namespace LeetCode.Algorithms.VowelsGameInString;

/// <summary>
///     https://leetcode.com/problems/vowels-game-in-a-string/description/
/// </summary>
public interface IVowelsGameInString
{
    /// <summary>
    ///     Determines whether Alice wins the game where Alice and Bob alternately remove a non-empty substring of
    ///     <paramref name="s" /> under vowel-count parity rules, with Alice moving first.
    /// </summary>
    /// <param name="s">The string of lowercase English letters used to play the game.</param>
    /// <returns><see langword="true" /> if Alice wins the game; otherwise, <see langword="false" />.</returns>
    bool DoesAliceWin(string s);
}