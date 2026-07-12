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

namespace LeetCode.Algorithms.MultiplyStrings;

/// <summary>
///     https://leetcode.com/problems/multiply-strings/
/// </summary>
public interface IMultiplyStrings
{
    /// <summary>
    ///     Multiplies the two non-negative integers represented as strings <paramref name="num1" /> and
    ///     <paramref name="num2" /> and returns the product as a string.
    /// </summary>
    /// <param name="num1">The first non-negative integer, represented as a string of digits.</param>
    /// <param name="num2">The second non-negative integer, represented as a string of digits.</param>
    /// <returns>The product of <paramref name="num1" /> and <paramref name="num2" />, represented as a string.</returns>
    string Multiply(string num1, string num2);
}