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

namespace LeetCode.Algorithms.CountTheNumberOfSubstringsWithDominantOnes;

/// <summary>
///     https://leetcode.com/problems/count-the-number-of-substrings-with-dominant-ones/description/
/// </summary>
public interface ICountTheNumberOfSubstringsWithDominantOnes
{
    /// <summary>
    ///     Counts the substrings of the binary string <paramref name="s" /> that have dominant ones, meaning the number of
    ///     ones in the substring is greater than or equal to the square of the number of zeros in the substring.
    /// </summary>
    /// <param name="s">The binary string consisting only of the characters <c>'0'</c> and <c>'1'</c>.</param>
    /// <returns>The number of substrings of <paramref name="s" /> in which ones are dominant.</returns>
    int NumberOfSubstrings(string s);
}