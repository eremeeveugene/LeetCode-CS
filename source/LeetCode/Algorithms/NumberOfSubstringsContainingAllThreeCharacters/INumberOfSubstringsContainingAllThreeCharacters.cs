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

namespace LeetCode.Algorithms.NumberOfSubstringsContainingAllThreeCharacters;

/// <summary>
///     https://leetcode.com/problems/number-of-substrings-containing-all-three-characters/description/
/// </summary>
public interface INumberOfSubstringsContainingAllThreeCharacters
{
    /// <summary>
    ///     Counts the substrings of <paramref name="s" /> that contain at least one occurrence of each of the characters
    ///     <c>'a'</c>, <c>'b'</c> and <c>'c'</c>.
    /// </summary>
    /// <param name="s">A string consisting only of characters <c>'a'</c>, <c>'b'</c> and <c>'c'</c>.</param>
    /// <returns>The number of substrings containing at least one occurrence of all three characters.</returns>
    int NumberOfSubstrings(string s);
}