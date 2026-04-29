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

namespace LeetCode.Algorithms.ValidDigitNumber;

/// <summary>
///     https://leetcode.com/problems/valid-digit-number/description/
/// </summary>
public interface IValidDigitNumber
{
    /// <summary>
    ///     Determines whether the specified number contains the digit and does not start with it.
    /// </summary>
    /// <param name="n">The integer number to validate.</param>
    /// <param name="x">The digit that must appear in the number but not as the first digit.</param>
    /// <returns>
    ///     <see langword="true" /> if <paramref name="n" /> contains <paramref name="x" /> and does not start with it;
    ///     otherwise, <see langword="false" />.
    /// </returns>
    bool ValidDigit(int n, int x);
}