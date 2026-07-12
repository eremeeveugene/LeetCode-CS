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

namespace LeetCode.Algorithms.FirstCompletelyPaintedRowOrColumn;

/// <summary>
///     https://leetcode.com/problems/first-completely-painted-row-or-column/description/
/// </summary>
public interface IFirstCompletelyPaintedRowOrColumn
{
    /// <summary>
    ///     Finds the smallest index in <paramref name="arr" /> at which painting the matching cells of
    ///     <paramref name="mat" /> in order first results in a completely painted row or column.
    /// </summary>
    /// <param name="arr">The order in which the values of the matrix are painted.</param>
    /// <param name="mat">The matrix whose cells contain the values of <paramref name="arr" />.</param>
    /// <returns>The smallest index of <paramref name="arr" /> at which a row or column becomes completely painted.</returns>
    int FirstCompleteIndex(int[] arr, int[][] mat);
}