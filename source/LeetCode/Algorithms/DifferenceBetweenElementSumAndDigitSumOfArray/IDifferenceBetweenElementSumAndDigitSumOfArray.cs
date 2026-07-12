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

namespace LeetCode.Algorithms.DifferenceBetweenElementSumAndDigitSumOfArray;

/// <summary>
///     https://leetcode.com/problems/difference-between-element-sum-and-digit-sum-of-an-array/
/// </summary>
public interface IDifferenceBetweenElementSumAndDigitSumOfArray
{
    /// <summary>
    ///     Computes the absolute difference between the element sum and the digit sum of <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of positive integers.</param>
    /// <returns>The absolute difference between the sum of the elements and the sum of all digits of the elements.</returns>
    int DifferenceOfSum(int[] nums);
}