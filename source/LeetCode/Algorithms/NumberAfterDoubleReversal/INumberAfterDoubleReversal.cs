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

namespace LeetCode.Algorithms.NumberAfterDoubleReversal;

/// <summary>
///     https://leetcode.com/problems/a-number-after-a-double-reversal/description/
/// </summary>
public interface INumberAfterDoubleReversal
{
    /// <summary>
    ///     Determines whether reversing the digits of <paramref name="num" /> and then reversing the digits of the
    ///     result again yields the original value of <paramref name="num" />.
    /// </summary>
    /// <param name="num">The non-negative integer to test.</param>
    /// <returns><see langword="true" /> if reversing <paramref name="num" /> twice reproduces its original value; otherwise, <see langword="false" />.</returns>
    bool IsSameAfterReversals(int num);
}