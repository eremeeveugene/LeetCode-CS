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

namespace LeetCode.Algorithms.RearrangeStringToAvoidCharacterPair;

/// <summary>
///     https://leetcode.com/problems/rearrange-string-to-avoid-character-pair/description/
/// </summary>
public interface IRearrangeStringToAvoidCharacterPair
{
    /// <summary>
    ///     Rearranges the characters of <paramref name="s" /> so that every occurrence of <paramref name="y" />
    ///     appears before every occurrence of <paramref name="x" />.
    /// </summary>
    /// <param name="s">The string whose characters are rearranged.</param>
    /// <param name="x">The character that must appear only after every occurrence of <paramref name="y" />.</param>
    /// <param name="y">The character that must appear only before every occurrence of <paramref name="x" />.</param>
    /// <returns>Any permutation of <paramref name="s" /> satisfying the ordering requirement.</returns>
    string RearrangeString(string s, char x, char y);
}