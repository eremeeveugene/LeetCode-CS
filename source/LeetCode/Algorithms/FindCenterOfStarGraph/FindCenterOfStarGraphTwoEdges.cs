// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.FindCenterOfStarGraph;

/// <inheritdoc />
public class FindCenterOfStarGraphTwoEdges : IFindCenterOfStarGraph
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="edges"></param>
    /// <returns></returns>
    public int FindCenter(int[][] edges)
    {
        if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
        {
            return edges[0][0];
        }

        return edges[0][1];
    }
}