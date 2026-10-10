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

using LeetCode.Algorithms.MinimumHeightTrees;

namespace LeetCode.Tests.Algorithms.MinimumHeightTrees;

public abstract class MinimumHeightTreesTestsBase<T> where T : IMinimumHeightTrees, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindMinHeightTrees_WithGraphEdgesAndNodeCount_ReturnsMinHeightRoots(int n, int[][] edges, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualList = solution.FindMinHeightTrees(n, edges);

        var actualResult = new int[actualList.Count];

        actualList.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [1, Array.Empty<int[]>(), new[] { 0 }];

        yield return [2, new[] { new[] { 0, 1 } }, new[] { 0, 1 }];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 1 }];

        yield return [4, new[] { new[] { 1, 0 }, new[] { 1, 2 }, new[] { 1, 3 } }, new[] { 1 }];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 3, 4 } }, new[] { 0, 3 }];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, new[] { 3 }];

        yield return [6, new[] { new[] { 3, 0 }, new[] { 3, 1 }, new[] { 3, 2 }, new[] { 3, 4 }, new[] { 5, 4 } }, new[] { 3, 4 }];

        yield return [7, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 5 }, new[] { 4, 6 } }, new[] { 1, 2 }];

        yield return
        [
            8,
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 5 }, new[] { 2, 6 }, new[] { 6, 7 } },
            new[] { 0, 2 }
        ];

        yield return
        [
            9,
            new[]
            {
                new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 6, 7 }, new[] { 7, 8 }
            },
            new[] { 4, 5 }
        ];

        yield return [8, new[] { new[] { 0, 5 }, new[] { 4, 5 }, new[] { 2, 5 }, new[] { 4, 7 }, new[] { 3, 1 }, new[] { 6, 3 }, new[] { 3, 5 } }, new[] { 5 }];

        yield return [10, new[] { new[] { 8, 4 }, new[] { 9, 1 }, new[] { 2, 8 }, new[] { 3, 9 }, new[] { 1, 6 }, new[] { 5, 9 }, new[] { 9, 0 }, new[] { 8, 7 }, new[] { 2, 9 } }, new[] { 2, 9 }];

        yield return [12, new[] { new[] { 2, 5 }, new[] { 4, 10 }, new[] { 9, 3 }, new[] { 7, 3 }, new[] { 2, 11 }, new[] { 9, 6 }, new[] { 0, 4 }, new[] { 9, 1 }, new[] { 8, 10 }, new[] { 9, 10 }, new[] { 11, 9 } }, new[] { 9 }];

        yield return [15, new[] { new[] { 5, 13 }, new[] { 9, 4 }, new[] { 11, 10 }, new[] { 6, 4 }, new[] { 10, 3 }, new[] { 5, 11 }, new[] { 9, 11 }, new[] { 7, 12 }, new[] { 0, 4 }, new[] { 9, 7 }, new[] { 1, 8 }, new[] { 14, 12 }, new[] { 2, 7 }, new[] { 1, 9 } }, new[] { 9 }];

        yield return [20, new[] { new[] { 18, 7 }, new[] { 3, 6 }, new[] { 1, 5 }, new[] { 0, 9 }, new[] { 2, 3 }, new[] { 3, 16 }, new[] { 17, 14 }, new[] { 7, 15 }, new[] { 2, 11 }, new[] { 16, 19 }, new[] { 0, 3 }, new[] { 18, 4 }, new[] { 0, 5 }, new[] { 16, 14 }, new[] { 12, 15 }, new[] { 3, 15 }, new[] { 13, 10 }, new[] { 2, 8 }, new[] { 13, 0 } }, new[] { 3, 15 }];

        yield return [30, new[] { new[] { 14, 16 }, new[] { 19, 27 }, new[] { 16, 19 }, new[] { 25, 9 }, new[] { 2, 19 }, new[] { 26, 0 }, new[] { 21, 8 }, new[] { 16, 7 }, new[] { 22, 19 }, new[] { 1, 19 }, new[] { 17, 27 }, new[] { 29, 6 }, new[] { 0, 27 }, new[] { 24, 28 }, new[] { 10, 16 }, new[] { 23, 22 }, new[] { 3, 12 }, new[] { 4, 16 }, new[] { 21, 10 }, new[] { 11, 13 }, new[] { 14, 5 }, new[] { 16, 15 }, new[] { 14, 24 }, new[] { 12, 11 }, new[] { 16, 12 }, new[] { 29, 19 }, new[] { 20, 24 }, new[] { 21, 18 }, new[] { 9, 24 } }, new[] { 16 }];

        yield return [10, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 0, 4 }, new[] { 0, 5 }, new[] { 0, 6 }, new[] { 0, 7 }, new[] { 0, 8 }, new[] { 0, 9 } }, new[] { 0 }];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 } }, new[] { 1, 2 }];

        yield return [5, new[] { new[] { 4, 3 }, new[] { 3, 2 }, new[] { 2, 1 }, new[] { 1, 0 } }, new[] { 2 }];

        yield return [1000, CreatePathEdges(1000), new[] { 499, 500 }];

        yield return [1000, CreateStarEdges(1000), new[] { 0 }];
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

    private static int[][] CreateStarEdges(int n)
    {
        var edges = new int[n - 1][];

        for (var i = 1; i < n; i++)
        {
            edges[i - 1] = [0, i];
        }

        return edges;
    }
}