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

namespace LeetCode.Algorithms.MinimumOperationsToMakeTheIntegerZero;

/// <summary>
///     https://leetcode.com/problems/minimum-operations-to-make-the-integer-zero/description/
/// </summary>
public interface IMinimumOperationsToMakeTheIntegerZero
{
    /// <summary>
    ///     Finds the minimum number of operations needed to make <paramref name="num1" /> equal to zero, where each
    ///     operation chooses an integer <c>i</c> in the range [0, 60] and subtracts <c>2^i + num2</c> from
    ///     <paramref name="num1" />.
    /// </summary>
    /// <param name="num1">The starting integer value to reduce to zero.</param>
    /// <param name="num2">The integer added to each power of two subtracted from <paramref name="num1" />.</param>
    /// <returns>The minimum number of operations required, or -1 if it is not possible.</returns>
    int MakeTheIntegerZero(int num1, int num2);
}