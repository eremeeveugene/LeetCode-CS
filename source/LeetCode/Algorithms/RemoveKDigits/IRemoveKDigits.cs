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

namespace LeetCode.Algorithms.RemoveKDigits;

/// <summary>
///     https://leetcode.com/problems/remove-k-digits/
/// </summary>
public interface IRemoveKDigits
{
    /// <summary>
    ///     Removes exactly <paramref name="k" /> digits from the non-negative integer string <paramref name="num" /> to
    ///     produce the smallest possible resulting number.
    /// </summary>
    /// <param name="num">The string representation of a non-negative integer.</param>
    /// <param name="k">The number of digits to remove.</param>
    /// <returns>The smallest possible number, as a string, after removing <paramref name="k" /> digits.</returns>
    string RemoveKdigits(string num, int k);
}