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

namespace LeetCode.Algorithms.MinimumNumberOfOperationsToMoveAllBallsToEachBox;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/description/
/// </summary>
public interface IMinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    /// <summary>
    ///     For each box position in <paramref name="boxes" />, computes the minimum number of moves needed to bring
    ///     every ball, each moved one position per operation, to that box.
    /// </summary>
    /// <param name="boxes">The string where each character ('0' or '1') indicates whether a box contains a ball.</param>
    /// <returns>An array where each entry is the minimum number of operations to gather all balls at that box.</returns>
    int[] MinOperations(string boxes);
}