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

namespace LeetCode.Algorithms.ModifyGraphEdgeWeights;

/// <summary>
///     https://leetcode.com/problems/modify-graph-edge-weights/description/
/// </summary>
public interface IModifyGraphEdgeWeights
{
    int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target);
}