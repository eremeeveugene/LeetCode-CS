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

namespace LeetCode.Algorithms.MaximumNumberOfWordsYouCanType;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-words-you-can-type/
/// </summary>
public interface IMaximumNumberOfWordsYouCanType
{
    /// <summary>
    ///     Counts the number of words in <paramref name="text" /> that can be fully typed without using any of the keys
    ///     listed in <paramref name="brokenLetters" />.
    /// </summary>
    /// <param name="text">The space-separated string of words to check.</param>
    /// <param name="brokenLetters">The string of letters representing broken (unusable) keyboard keys.</param>
    /// <returns>The count of words in <paramref name="text" /> that contain none of the broken letters.</returns>
    int CanBeTypedWords(string text, string brokenLetters);
}