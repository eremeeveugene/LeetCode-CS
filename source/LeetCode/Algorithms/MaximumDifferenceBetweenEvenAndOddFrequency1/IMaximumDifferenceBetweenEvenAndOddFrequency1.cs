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

namespace LeetCode.Algorithms.MaximumDifferenceBetweenEvenAndOddFrequency1;

/// <summary>
///     https://leetcode.com/problems/maximum-difference-between-even-and-odd-frequency-i/description/
/// </summary>
public interface IMaximumDifferenceBetweenEvenAndOddFrequency1
{
    /// <summary>
    ///     Computes the maximum difference between the frequency of a character with an odd count and the frequency of
    ///     a (possibly different) character with an even count in <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string whose character frequencies are analyzed.</param>
    /// <returns>The maximum difference between an odd-frequency character count and an even-frequency character count.</returns>
    int MaxDifference(string s);
}