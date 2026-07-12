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

namespace LeetCode.Algorithms.AddToArrayFormOfInteger;

/// <summary>
///     https://leetcode.com/problems/add-to-array-form-of-integer/description/
/// </summary>
public interface IAddToArrayFormOfInteger
{
    /// <summary>
    ///     Adds the integer <paramref name="k" /> to the number represented by the digit array <paramref name="num" /> and
    ///     returns the result in array form.
    /// </summary>
    /// <param name="num">The digits of the number, ordered from most significant to least significant.</param>
    /// <param name="k">The integer to add.</param>
    /// <returns>The array form of the sum of the number and <paramref name="k" />.</returns>
    IList<int> AddToArrayForm(int[] num, int k);
}