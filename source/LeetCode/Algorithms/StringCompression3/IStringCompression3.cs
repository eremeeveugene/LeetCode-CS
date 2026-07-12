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

namespace LeetCode.Algorithms.StringCompression3;

/// <summary>
///     https://leetcode.com/problems/string-compression-iii/description/
/// </summary>
public interface IStringCompression3
{
    /// <summary>
    ///     Compresses <paramref name="word" /> by repeatedly taking runs of up to 9 identical adjacent
    ///     characters and appending the run length followed by the character.
    /// </summary>
    /// <param name="word">The string to compress.</param>
    /// <returns>The compressed representation of <paramref name="word" />.</returns>
    string CompressedString(string word);
}