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

namespace LeetCode.Algorithms.MajorityFrequencyCharacters;

/// <summary>
///     https://leetcode.com/problems/majority-frequency-characters/description/
/// </summary>
public interface IMajorityFrequencyCharacters
{
    /// <summary>
    ///     Groups the characters of <paramref name="s" /> that share the highest frequency of occurrence.
    /// </summary>
    /// <param name="s">The string whose characters are grouped by frequency.</param>
    /// <returns>A string containing the characters with the highest frequency in <paramref name="s" />, sorted in decreasing order of frequency.</returns>
    string MajorityFrequencyGroup(string s);
}