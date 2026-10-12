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

namespace LeetCode.Algorithms.SumOfSquaresOfSpecialElements;

/// <summary>
///     https://leetcode.com/problems/sum-of-squares-of-special-elements/description/
/// </summary>
public interface ISumOfSquaresOfSpecialElements
{
    /// <summary>
    ///     Calculates the sum of squares of all special elements of the 1-indexed array, where an element at index i is
    ///     special if i divides the length of the array.
    /// </summary>
    /// <param name="nums">The 1-indexed array of integers.</param>
    /// <returns>The sum of squares of all special elements.</returns>
    int SumOfSquares(int[] nums);
}