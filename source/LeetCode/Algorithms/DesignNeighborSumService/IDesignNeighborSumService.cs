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

namespace LeetCode.Algorithms.DesignNeighborSumService;

/// <summary>
///     https://leetcode.com/problems/design-neighbor-sum-service/description/
/// </summary>
public interface IDesignNeighborSumService
{
    /// <summary>
    ///     Computes the sum of the values in cells that share an edge with the cell containing <paramref name="value" />.
    /// </summary>
    /// <param name="value">The value stored in the grid cell whose edge-adjacent neighbors are summed.</param>
    /// <returns>The sum of the values in the edge-adjacent neighboring cells.</returns>
    int AdjacentSum(int value);

    /// <summary>
    ///     Computes the sum of the values in cells that share a corner (diagonal) with the cell containing
    ///     <paramref name="value" />.
    /// </summary>
    /// <param name="value">The value stored in the grid cell whose diagonal neighbors are summed.</param>
    /// <returns>The sum of the values in the diagonally neighboring cells.</returns>
    int DiagonalSum(int value);
}