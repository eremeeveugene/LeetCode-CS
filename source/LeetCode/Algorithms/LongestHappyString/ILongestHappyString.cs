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

namespace LeetCode.Algorithms.LongestHappyString;

/// <summary>
///     https://leetcode.com/problems/longest-happy-string/description/
/// </summary>
public interface ILongestHappyString
{
    /// <summary>
    ///     Constructs the longest possible "happy" string using at most <paramref name="a" /> occurrences of 'a', <paramref name="b" /> occurrences of 'b', and <paramref name="c" /> occurrences of 'c', where no three consecutive characters are the same.
    /// </summary>
    /// <param name="a">The maximum number of 'a' characters allowed.</param>
    /// <param name="b">The maximum number of 'b' characters allowed.</param>
    /// <param name="c">The maximum number of 'c' characters allowed.</param>
    /// <returns>The longest happy string obtainable, or an empty string if none can be formed.</returns>
    string LongestDiverseString(int a, int b, int c);
}