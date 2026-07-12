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

namespace LeetCode.Algorithms.CheckIfAnyElementHasPrimeFrequency;

/// <summary>
///     https://leetcode.com/problems/check-if-any-element-has-prime-frequency/description/
/// </summary>
public interface ICheckIfAnyElementHasPrimeFrequency
{
    /// <summary>
    ///     Determines whether any element of <paramref name="nums" /> occurs a prime number of times.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns><c>true</c> if the frequency of any element of <paramref name="nums" /> is a prime number; otherwise, <c>false</c>.</returns>
    bool CheckPrimeFrequency(int[] nums);
}