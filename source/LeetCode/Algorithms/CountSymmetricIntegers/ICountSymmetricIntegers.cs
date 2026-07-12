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

namespace LeetCode.Algorithms.CountSymmetricIntegers;

/// <summary>
///     https://leetcode.com/problems/count-symmetric-integers/description/
/// </summary>
public interface ICountSymmetricIntegers
{
    /// <summary>
    ///     Counts the symmetric integers in the range from <paramref name="low" /> to <paramref name="high" />, where
    ///     an integer with an even number of digits is symmetric if the sum of its first half of digits equals the sum
    ///     of its second half.
    /// </summary>
    /// <param name="low">The inclusive lower bound of the range.</param>
    /// <param name="high">The inclusive upper bound of the range.</param>
    /// <returns>The number of symmetric integers in the range.</returns>
    int CountSymmetricIntegers(int low, int high);
}