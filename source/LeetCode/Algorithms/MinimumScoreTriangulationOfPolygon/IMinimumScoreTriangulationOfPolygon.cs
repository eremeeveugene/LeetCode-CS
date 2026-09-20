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

namespace LeetCode.Algorithms.MinimumScoreTriangulationOfPolygon;

/// <summary>
///     https://leetcode.com/problems/minimum-score-triangulation-of-polygon/description/
/// </summary>
public interface IMinimumScoreTriangulationOfPolygon
{
    /// <summary>
    ///     Finds the minimum total score of a triangulation of the convex polygon.
    /// </summary>
    /// <param name="values">The vertex values in clockwise order.</param>
    /// <returns>The minimum sum of the products of the three vertex values of each triangle.</returns>
    int MinScoreTriangulation(int[] values);
}