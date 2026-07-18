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

namespace LeetCode.Algorithms.FindCenterOfStarGraph;

/// <summary>
///     https://leetcode.com/problems/find-center-of-star-graph/description
/// </summary>
public interface IFindCenterOfStarGraph
{
    /// <summary>
    ///     Finds the center node of the star graph described by <paramref name="edges" />.
    /// </summary>
    /// <param name="edges">The array of edges of the star graph.</param>
    /// <returns>The identifier of the center node of the star graph.</returns>
    int FindCenter(int[][] edges);
}