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

using LeetCode.Algorithms.PathWithMaximumProbability;

namespace LeetCode.Tests.Algorithms.PathWithMaximumProbability;

public abstract class PathWithMaximumProbabilityTestsBase<T> where T : IPathWithMaximumProbability, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxProbability_GivenGraphAndProbabilities_ReturnsMaxProbability(int n, int[][] edges, double[] successProbability, int startNode, int endNode, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = Math.Round(solution.MaxProbability(n, edges, successProbability, startNode, endNode), 5);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [2, Array.Empty<int[]>(), Array.Empty<double>(), 0, 1, 0d];

        yield return [3, new[] { new[] { 0, 1 } }, new[] { 0.5 }, 0, 2, 0d];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 2 } }, new[] { 0.5, 0.5, 0.2 }, 0, 2, 0.25];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 2 } }, new[] { 0.5, 0.5, 0.3 }, 0, 2, 0.3];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 0, 3 } }, new[] { 0.4, 0.3, 0.2, 0.1 }, 0, 3, 0.1];

        yield return [5, new[] { new[] { 1, 4 }, new[] { 2, 4 }, new[] { 0, 4 }, new[] { 0, 3 }, new[] { 0, 2 }, new[] { 2, 3 } }, new[] { 0.37, 0.17, 0.93, 0.23, 0.39, 0.04 }, 3, 4, 0.2139];

        yield return [10, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 5 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 5, 7 }, new[] { 6, 8 }, new[] { 7, 9 } }, new[] { 0.1, 0.2, 0.5, 0.6, 0.3, 0.7, 0.8, 0.9, 0.4, 0.5 }, 0, 9, 0.03780];

        yield return [15, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 5 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 6, 7 }, new[] { 7, 8 }, new[] { 8, 9 }, new[] { 9, 10 }, new[] { 10, 11 }, new[] { 11, 12 }, new[] { 12, 13 }, new[] { 13, 14 } }, new[] { 0.4, 0.5, 0.6, 0.7, 0.3, 0.9, 0.2, 0.1, 0.8, 0.9, 0.7, 0.6, 0.5, 0.4, 0.3 }, 0, 14, 0.00011];

        yield return [2, Array.Empty<int[]>(), Array.Empty<double>(), 0, 0, 1d];

        yield return [3, new[] { new[] { 0, 1 } }, new[] { 0.5 }, 2, 2, 1d];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 0.5, 0.6 }, 3, 0, 0d];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 0.5, 0.6 }, 4, 3, 0d];

        yield return [3, new[] { new[] { 0, 1 } }, new[] { 0.5 }, 0, 0, 1d];

        yield return [4, new[] { new[] { 0, 1 } }, new[] { 0.5 }, 2, 3, 0d];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 0.5, 0.6 }, 0, 2, 0.3];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 0.7, 0.8 }, 0, 2, 0.56];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 1.0, 1.0 }, 0, 2, 1d];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 } }, new[] { 0.5, 0.5, 0.5 }, 0, 3, 0.125];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 0.0, 0.0 }, 0, 2, 0d];
    }
}