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

namespace LeetCode.Algorithms.CountOperationsToObtainZero;

/// <summary>
///     https://leetcode.com/problems/count-operations-to-obtain-zero/description/
/// </summary>
public interface ICountOperationsToObtainZero
{
    /// <summary>
    ///     Counts the number of operations needed to reduce <paramref name="num1" /> or <paramref name="num2" /> to zero,
    ///     where each operation subtracts the smaller of the two from the larger.
    /// </summary>
    /// <param name="num1">The first non-negative integer.</param>
    /// <param name="num2">The second non-negative integer.</param>
    /// <returns>The total number of operations required until one of the values becomes zero.</returns>
    int CountOperations(int num1, int num2);
}