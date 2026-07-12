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

namespace LeetCode.Algorithms.FindTheLexicographicallyLargestStringFromTheBox1;

/// <summary>
///     https://leetcode.com/problems/find-the-lexicographically-largest-string-from-the-box-i/description/
/// </summary>
public interface IFindTheLexicographicallyLargestStringFromTheBox1
{
    /// <summary>
    ///     Finds the lexicographically largest string that can be put in the box when <paramref name="word" /> is split into
    ///     <paramref name="numFriends" /> non-empty parts in every possible way.
    /// </summary>
    /// <param name="word">The string to split.</param>
    /// <param name="numFriends">The number of non-empty parts the string is split into.</param>
    /// <returns>The lexicographically largest string from the box.</returns>
    string AnswerString(string word, int numFriends);
}