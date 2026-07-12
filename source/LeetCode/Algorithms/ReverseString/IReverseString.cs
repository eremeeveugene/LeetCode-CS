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

namespace LeetCode.Algorithms.ReverseString;

/// <summary>
///     https://leetcode.com/problems/reverse-string/description/
/// </summary>
public interface IReverseString
{
    /// <summary>
    ///     Reverses the array of characters <paramref name="s" /> in place.
    /// </summary>
    /// <param name="s">The character array to reverse in place.</param>
    void ReverseString(char[] s);
}