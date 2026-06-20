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

namespace LeetCode.Algorithms.FindTheDegreeOfEachVertex;

/// <summary>
///     https://leetcode.com/problems/find-the-degree-of-each-vertex/
/// </summary>
public interface IFindTheDegreeOfEachVertex
{
    /// <summary>
    ///     Given the <paramref name="matrix" /> of size <c>n x n</c> that is the adjacency matrix of an undirected graph with
    ///     vertices labeled <c>0</c> to <c>n - 1</c>, where <c>matrix[i][j] == 1</c> means there is an edge between vertices
    ///     <c>i</c> and <c>j</c> and <c>matrix[i][j] == 0</c> means there is none, computes the degree (the number of edges
    ///     connected) of every vertex.
    /// </summary>
    /// <param name="matrix">The adjacency matrix of the undirected graph.</param>
    /// <returns>An array where the element at index <c>i</c> is the degree of vertex <c>i</c>.</returns>
    int[] FindDegrees(int[][] matrix);
}