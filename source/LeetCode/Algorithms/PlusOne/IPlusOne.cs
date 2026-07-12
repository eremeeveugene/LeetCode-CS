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

namespace LeetCode.Algorithms.PlusOne;

/// <summary>
///     https://leetcode.com/problems/plus-one/
/// </summary>
public interface IPlusOne
{
    /// <summary>
    ///     Increments by one the large integer represented as the ordered array of digits <paramref name="digits" />.
    /// </summary>
    /// <param name="digits">The array of digits representing the integer, most significant digit first.</param>
    /// <returns>The array of digits representing the incremented integer.</returns>
    int[] PlusOne(int[] digits);
}