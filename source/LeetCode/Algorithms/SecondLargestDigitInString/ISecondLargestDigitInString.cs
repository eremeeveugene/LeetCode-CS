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

namespace LeetCode.Algorithms.SecondLargestDigitInString;

/// <summary>
///     https://leetcode.com/problems/second-largest-digit-in-a-string/description/
/// </summary>
public interface ISecondLargestDigitInString
{
    /// <summary>
    ///     Finds the second largest distinct digit that appears in <paramref name="s" />.
    /// </summary>
    /// <param name="s">The alphanumeric string to search for digits.</param>
    /// <returns>The second largest distinct digit in <paramref name="s" />, or -1 if it does not exist.</returns>
    int SecondHighest(string s);
}