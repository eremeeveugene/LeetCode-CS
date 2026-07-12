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

namespace LeetCode.Algorithms.UniqueThreeDigitEvenNumbers;

/// <summary>
///     https://leetcode.com/problems/unique-3-digit-even-numbers/description/
/// </summary>
public interface IUniqueThreeDigitEvenNumbers
{
    /// <summary>
    ///     Counts the number of distinct three-digit even numbers that can be formed by picking three digits from
    ///     <paramref name="digits" /> without reusing a digit's position more than once.
    /// </summary>
    /// <param name="digits">The array of digits, each from 0 to 9, available to form the numbers.</param>
    /// <returns>The count of distinct three-digit even numbers that can be formed.</returns>
    int TotalNumbers(int[] digits);
}