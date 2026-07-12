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

namespace LeetCode.Algorithms.MaximumNumberOfOperationsToMoveOnesToTheEnd;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-operations-to-move-ones-to-the-end/description/
/// </summary>
public interface IMaximumNumberOfOperationsToMoveOnesToTheEnd
{
    /// <summary>
    ///     Computes the maximum number of operations, each swapping an adjacent "10" substring to "01", achievable while
    ///     moving all the 1s of the binary string <paramref name="s" /> to the end.
    /// </summary>
    /// <param name="s">The binary string whose 1s are moved to the end.</param>
    /// <returns>The maximum number of adjacent swap operations achievable while moving all 1s in <paramref name="s" /> to the end.</returns>
    int MaxOperations(string s);
}