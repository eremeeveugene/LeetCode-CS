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

namespace LeetCode.Algorithms.RemoveZerosInDecimalRepresentation;

/// <summary>
///     https://leetcode.com/problems/remove-zeros-in-decimal-representation/description/
/// </summary>
public interface IRemoveZerosInDecimalRepresentation
{
    /// <summary>
    ///     Removes every digit '0' from the decimal representation of <paramref name="n" />.
    /// </summary>
    /// <param name="n">The non-negative integer whose zero digits are removed.</param>
    /// <returns>The integer formed by removing all '0' digits from <paramref name="n" />.</returns>
    long RemoveZeros(long n);
}