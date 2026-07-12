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

namespace LeetCode.Algorithms.FindingThreeDigitEvenNumbers;

/// <summary>
///     https://leetcode.com/problems/finding-3-digit-even-numbers/description/
/// </summary>
public interface IFindingThreeDigitEvenNumbers
{
    /// <summary>
    ///     Finds all unique three-digit even numbers that can be formed by concatenating three elements of
    ///     <paramref name="digits" /> without leading zeros.
    /// </summary>
    /// <param name="digits">The array of digits.</param>
    /// <returns>The sorted array of unique three-digit even numbers that can be formed.</returns>
    int[] FindEvenNumbers(int[] digits);
}