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

namespace LeetCode.Algorithms.TheTwoSneakyNumbersOfDigitville;

/// <summary>
///     https://leetcode.com/problems/the-two-sneaky-numbers-of-digitville/description/
/// </summary>
public interface ITheTwoSneakyNumbersOfDigitville
{
    /// <summary>
    ///     Finds the two "sneaky" numbers that each appear twice in <paramref name="nums" />, which should
    ///     otherwise contain every number from 0 to <c>n</c> - 1 exactly once.
    /// </summary>
    /// <param name="nums">The array of length <c>n</c> + 2 containing numbers from 0 to <c>n</c> - 1, with two duplicated.</param>
    /// <returns>An array containing the two duplicated numbers.</returns>
    int[] GetSneakyNumbers(int[] nums);
}