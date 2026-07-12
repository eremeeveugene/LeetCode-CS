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

namespace LeetCode.Algorithms.AddDigits;

/// <summary>
///     https://leetcode.com/problems/add-digits/
/// </summary>
public interface IAddDigits
{
    /// <summary>
    ///     Repeatedly adds the digits of <paramref name="num" /> until the result has only one digit.
    /// </summary>
    /// <param name="num">The non-negative integer whose digits are added.</param>
    /// <returns>The single-digit result of repeatedly adding the digits of <paramref name="num" />.</returns>
    int AddDigits(int num);
}