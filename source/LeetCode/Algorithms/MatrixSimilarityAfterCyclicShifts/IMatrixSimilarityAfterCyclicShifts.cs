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

namespace LeetCode.Algorithms.MatrixSimilarityAfterCyclicShifts;

/// <summary>
///     https://leetcode.com/problems/matrix-similarity-after-cyclic-shifts/description/
/// </summary>
public interface IMatrixSimilarityAfterCyclicShifts
{
    /// <summary>
    ///     Determines whether <paramref name="mat" /> looks the same after cyclically shifting each row right by
    ///     <paramref name="k" /> positions (odd rows) or left by <paramref name="k" /> positions (even rows).
    /// </summary>
    /// <param name="mat">The matrix whose rows are cyclically shifted.</param>
    /// <param name="k">The number of positions each row is cyclically shifted.</param>
    /// <returns><see langword="true" /> if <paramref name="mat" /> is unchanged after the shifts; otherwise, <see langword="false" />.</returns>
    bool AreSimilar(int[][] mat, int k);
}