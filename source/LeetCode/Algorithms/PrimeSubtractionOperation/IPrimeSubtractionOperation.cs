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

namespace LeetCode.Algorithms.PrimeSubtractionOperation;

/// <summary>
///     https://leetcode.com/problems/prime-subtraction-operation/description/
/// </summary>
public interface IPrimeSubtractionOperation
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> can be made strictly increasing by optionally subtracting a prime
    ///     number smaller than each element, at most once per index.
    /// </summary>
    /// <param name="nums">The array of integers to evaluate.</param>
    /// <returns><see langword="true" /> if <paramref name="nums" /> can be made strictly increasing; otherwise, <see langword="false" />.</returns>
    bool PrimeSubOperation(int[] nums);
}