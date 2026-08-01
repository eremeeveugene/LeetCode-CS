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

namespace LeetCode.Algorithms.LongestPalindromeByConcatenatingTwoLetterWords;

/// <summary>
///     https://leetcode.com/problems/longest-palindrome-by-concatenating-two-letter-words/description/
/// </summary>
public interface ILongestPalindromeByConcatenatingTwoLetterWords
{
    /// <summary>
    ///     Finds the length of the longest palindrome that can be built by concatenating a selection of the two-letter words in <paramref name="words" />,
    ///     using each word at most once.
    /// </summary>
    /// <param name="words">The array of two-letter words available for concatenation.</param>
    /// <returns>The length of the longest palindrome obtainable, or <c>0</c> if none can be formed.</returns>
    int LongestPalindrome(string[] words);
}