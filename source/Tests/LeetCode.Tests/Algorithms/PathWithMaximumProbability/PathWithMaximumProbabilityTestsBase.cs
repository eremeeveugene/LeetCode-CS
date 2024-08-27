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

using LeetCode.Algorithms.PathWithMaximumProbability;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.PathWithMaximumProbability;

public abstract class PathWithMaximumProbabilityTestsBase<T> where T : IPathWithMaximumProbability, new()
{
    [TestMethod]
    [DataRow(2, "[]", new double[] { }, 0, 1, 0)]
    [DataRow(3, "[[0,1]]", new[] { 0.5 }, 0, 2, 0)]
    [DataRow(3, "[[0,1],[1,2],[0,2]]", new[] { 0.5, 0.5, 0.2 }, 0, 2, 0.25)]
    [DataRow(3, "[[0,1],[1,2],[0,2]]", new[] { 0.5, 0.5, 0.3 }, 0, 2, 0.3)]
    [DataRow(4, "[[0, 1], [1, 2], [2, 3], [0, 3]]", new[] { 0.4, 0.3, 0.2, 0.1 }, 0, 3, 0.1)]
    [DataRow(5, "[[1,4],[2,4],[0,4],[0,3],[0,2],[2,3]]", new[] { 0.37, 0.17, 0.93, 0.23, 0.39, 0.04 }, 3, 4, 0.2139)]
    [DataRow(10, "[[0, 1], [0, 2], [1, 3], [2, 4], [3, 5], [4, 5], [5, 6], [5, 7], [6, 8], [7, 9]]",
        new[] { 0.1, 0.2, 0.5, 0.6, 0.3, 0.7, 0.8, 0.9, 0.4, 0.5 }, 0, 9, 0.03780)]
    [DataRow(15,
        "[[0, 1], [0, 2], [1, 3], [2, 4], [3, 5], [4, 5], [5, 6], [6, 7], [7, 8], [8, 9], [9, 10], [10, 11], [11, 12], [12, 13], [13, 14]]",
        new[] { 0.4, 0.5, 0.6, 0.7, 0.3, 0.9, 0.2, 0.1, 0.8, 0.9, 0.7, 0.6, 0.5, 0.4, 0.3 }, 0, 14, 0.00011)]
    public void MaxProbability_GivenGraphAndProbabilities_ReturnsMaxProbability(int n, string edgesJsonArray,
        double[] successProbability, int startNode, int endNode, double expectedResult)
    {
        // Arrange
        var edges = JsonHelper<int>.JsonArrayToJaggedArray(edgesJsonArray);

        var solution = new T();

        // Act
        var actualResult = Math.Round(solution.MaxProbability(n, edges, successProbability, startNode, endNode), 5);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}