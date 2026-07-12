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

namespace LeetCode.Algorithms.SmallestNumberWithAllSetBits;

/// <summary>
///     https://leetcode.com/problems/smallest-number-with-all-set-bits/description/
/// </summary>
public interface ISmallestNumberWithAllSetBits
{
    /// <summary>
    ///     Finds the smallest number greater than or equal to <paramref name="n" /> whose binary representation
    ///     consists of only set bits (i.e., of the form 2^x - 1).
    /// </summary>
    /// <param name="n">The lower bound integer.</param>
    /// <returns>The smallest number with all set bits that is at least <paramref name="n" />.</returns>
    int SmallestNumber(int n);
}