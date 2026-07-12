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

namespace LeetCode.Algorithms.ConstructStringWithRepeatLimit;

/// <summary>
///     https://leetcode.com/problems/construct-string-with-repeat-limit/description/
/// </summary>
public interface IConstructStringWithRepeatLimit
{
    /// <summary>
    ///     Rearranges the characters of <paramref name="s" /> in non-increasing order such that no character appears
    ///     more than <paramref name="repeatLimit" /> times in a row, producing the lexicographically largest such string.
    /// </summary>
    /// <param name="s">The string of lowercase letters to rearrange.</param>
    /// <param name="repeatLimit">The maximum number of times a character may repeat consecutively.</param>
    /// <returns>The lexicographically largest repeat-limited rearrangement of <paramref name="s" />.</returns>
    string RepeatLimitedString(string s, int repeatLimit);
}