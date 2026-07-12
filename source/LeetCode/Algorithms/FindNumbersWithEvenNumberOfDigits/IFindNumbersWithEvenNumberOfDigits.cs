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

namespace LeetCode.Algorithms.FindNumbersWithEvenNumberOfDigits;

/// <summary>
///     https://leetcode.com/problems/find-numbers-with-even-number-of-digits/description/
/// </summary>
public interface IFindNumbersWithEvenNumberOfDigits
{
    /// <summary>
    ///     Counts the elements of <paramref name="nums" /> that contain an even number of digits.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The number of elements containing an even number of digits.</returns>
    int FindNumbers(int[] nums);
}