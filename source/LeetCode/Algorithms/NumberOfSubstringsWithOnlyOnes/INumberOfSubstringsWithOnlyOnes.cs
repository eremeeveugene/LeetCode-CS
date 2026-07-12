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

namespace LeetCode.Algorithms.NumberOfSubstringsWithOnlyOnes;

/// <summary>
///     https://leetcode.com/problems/number-of-substrings-with-only-1s/description/
/// </summary>
public interface INumberOfSubstringsWithOnlyOnes
{
    /// <summary>
    ///     Counts the number of substrings of the binary string <paramref name="s" /> that consist only of the
    ///     character '1'.
    /// </summary>
    /// <param name="s">The binary string of '0' and '1' characters to search.</param>
    /// <returns>The number of substrings of <paramref name="s" /> that contain only '1' characters, modulo 10^9 + 7.</returns>
    int NumSub(string s);
}