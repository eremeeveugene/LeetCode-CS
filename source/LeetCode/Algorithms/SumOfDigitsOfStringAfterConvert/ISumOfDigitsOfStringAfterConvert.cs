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

namespace LeetCode.Algorithms.SumOfDigitsOfStringAfterConvert;

/// <summary>
///     https://leetcode.com/problems/sum-of-digits-of-string-after-convert/
/// </summary>
public interface ISumOfDigitsOfStringAfterConvert
{
    /// <summary>
    ///     Converts <paramref name="s" /> to an integer by replacing each letter with its position in the alphabet,
    ///     concatenating the digits, then repeatedly transforms the resulting number into the sum of its digits
    ///     <paramref name="k" /> times.
    /// </summary>
    /// <param name="s">The string consisting of lowercase English letters to convert.</param>
    /// <param name="k">The number of times to sum the digits of the transformed number.</param>
    /// <returns>The resulting integer after performing the transformation <paramref name="k" /> times.</returns>
    int GetLucky(string s, int k);
}