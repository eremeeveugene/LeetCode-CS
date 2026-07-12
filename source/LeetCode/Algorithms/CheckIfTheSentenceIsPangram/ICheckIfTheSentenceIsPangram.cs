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

namespace LeetCode.Algorithms.CheckIfTheSentenceIsPangram;

/// <summary>
///     https://leetcode.com/problems/check-if-the-sentence-is-pangram/description/
/// </summary>
public interface ICheckIfTheSentenceIsPangram
{
    /// <summary>
    ///     Determines whether <paramref name="sentence" /> is a pangram, i.e. contains every letter of the English alphabet
    ///     at least once.
    /// </summary>
    /// <param name="sentence">The sentence consisting of lowercase English letters.</param>
    /// <returns><c>true</c> if <paramref name="sentence" /> is a pangram; otherwise, <c>false</c>.</returns>
    bool CheckIfPangram(string sentence);
}