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

namespace LeetCode.Algorithms.FinalValueOfVariableAfterPerformingOperations;

/// <summary>
///     https://leetcode.com/problems/final-value-of-variable-after-performing-operations/
/// </summary>
public interface IFinalValueOfVariableAfterPerformingOperations
{
    /// <summary>
    ///     Computes the final value of a variable initialized to zero after performing the increment and decrement
    ///     operations in <paramref name="operations" />.
    /// </summary>
    /// <param name="operations">The array of increment and decrement operations.</param>
    /// <returns>The final value of the variable after all operations.</returns>
    int FinalValueAfterOperations(string[] operations);
}