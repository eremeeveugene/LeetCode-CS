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

namespace LeetCode.Algorithms.IntegerToEnglishWords;

/// <summary>
///     https://leetcode.com/problems/integer-to-english-words/
/// </summary>
public interface IIntegerToEnglishWords
{
    /// <summary>
    ///     Converts <paramref name="num" /> to its English words representation.
    /// </summary>
    /// <param name="num">The non-negative integer to convert.</param>
    /// <returns>The English words representation of <paramref name="num" />.</returns>
    string NumberToWords(int num);
}