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

using LeetCode.Algorithms.SumOfDistancesInTree;

namespace LeetCode.Tests.Algorithms.SumOfDistancesInTree;

public abstract class SumOfDistancesInTreeTestsBase<T> where T : ISumOfDistancesInTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SumOfDistancesInTree_GivenNumberOfNodesAndEdges_ReturnsDistanceSumsArray(int n, int[][] edges, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOfDistancesInTree(n, edges);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [6, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 2, 5 } }, new[] { 8, 12, 6, 10, 10, 10 }];

        yield return [1, Array.Empty<int[]>(), new[] { 0 }];

        yield return [2, new[] { new[] { 1, 0 } }, new[] { 1, 1 }];

        yield return [2, new[] { new[] { 0, 1 } }, new[] { 1, 1 }];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 3, 2, 3 }];

        yield return [3, new[] { new[] { 1, 0 }, new[] { 2, 0 } }, new[] { 2, 3, 3 }];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } }, new[] { 3, 5, 5, 5 }];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 } }, new[] { 6, 4, 4, 6 }];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 4 } }, new[] { 6, 5, 9, 8, 8 }];

        yield return [5, new[] { new[] { 4, 3 }, new[] { 3, 2 }, new[] { 2, 1 }, new[] { 1, 0 } }, new[] { 10, 7, 6, 7, 10 }];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, new[] { 15, 11, 9, 9, 11, 15 }];

        yield return [7, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 5 }, new[] { 2, 6 } }, new[] { 10, 11, 11, 16, 16, 16, 16 }];

        yield return [8, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 3, 5 }, new[] { 5, 6 }, new[] { 5, 7 } }, new[] { 18, 24, 14, 12, 18, 14, 20, 20 }];

        yield return [10, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 6, 7 }, new[] { 7, 8 }, new[] { 8, 9 } }, new[] { 45, 37, 31, 27, 25, 25, 27, 31, 37, 45 }];

        yield return [9, new[] { new[] { 8, 0 }, new[] { 8, 1 }, new[] { 8, 2 }, new[] { 8, 3 }, new[] { 8, 4 }, new[] { 8, 5 }, new[] { 8, 6 }, new[] { 8, 7 } }, new[] { 15, 15, 15, 15, 15, 15, 15, 15, 8 }];

        yield return [6, new[] { new[] { 3, 5 }, new[] { 1, 4 }, new[] { 0, 2 }, new[] { 2, 5 }, new[] { 4, 5 } }, new[] { 13, 13, 9, 11, 9, 7 }];

        yield return [12, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 1, 4 }, new[] { 1, 5 }, new[] { 2, 6 }, new[] { 3, 7 }, new[] { 3, 8 }, new[] { 7, 9 }, new[] { 7, 10 }, new[] { 10, 11 } }, new[] { 23, 29, 31, 23, 39, 39, 41, 27, 33, 37, 35, 45 }];

        yield return [3, new[] { new[] { 2, 1 }, new[] { 1, 0 } }, new[] { 3, 2, 3 }];

        yield return [5, new[] { new[] { 2, 0 }, new[] { 2, 1 }, new[] { 2, 3 }, new[] { 2, 4 } }, new[] { 7, 7, 4, 7, 7 }];

        yield return [7, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 2, 5 }, new[] { 5, 6 } }, new[] { 17, 12, 9, 12, 17, 12, 17 }];

        yield return [30000, CreatePathEdges(30000), CreatePathExpected(30000)];
    }

    private static int[][] CreatePathEdges(int n)
    {
        var edges = new int[n - 1][];

        for (var i = 0; i < n - 1; i++)
        {
            edges[i] = [i, i + 1];
        }

        return edges;
    }

    private static int[] CreatePathExpected(int n)
    {
        var expected = new int[n];

        for (var i = 0; i < n; i++)
        {
            var left = i;
            var right = n - 1 - i;

            expected[i] = (left * (left + 1) / 2) + (right * (right + 1) / 2);
        }

        return expected;
    }
}