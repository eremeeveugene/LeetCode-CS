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

using LeetCode.Algorithms.MinimumCostPathWithEdgeReversals;

namespace LeetCode.Tests.Algorithms.MinimumCostPathWithEdgeReversals;

public abstract class MinimumCostPathWithEdgeReversalsTestsBase<T> where T : IMinimumCostPathWithEdgeReversals, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinCost_WithNumberOfNodesAndDirectedEdges_ReturnsMinimumCost(int n, int[][] edges, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinCost(n, edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [4, new[] { new[] { 0, 1, 3 }, new[] { 3, 1, 1 }, new[] { 2, 3, 4 }, new[] { 0, 2, 2 } }, 5];

        yield return [4, new[] { new[] { 0, 2, 1 }, new[] { 2, 1, 1 }, new[] { 1, 3, 1 }, new[] { 2, 3, 3 } }, 3];

        yield return [2, new[] { new[] { 0, 1, 1 } }, 1];

        yield return [2, new[] { new[] { 1, 0, 1 } }, 2];

        yield return [2, new[] { new[] { 1, 0, 1000 } }, 2000];

        yield return [2, new[] { new[] { 0, 1, 7 }, new[] { 1, 0, 1 } }, 2];

        yield return [3, new[] { new[] { 0, 1, 5 } }, -1];

        yield return [3, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 } }, 2];

        yield return [3, new[] { new[] { 0, 1, 1 }, new[] { 2, 1, 1 } }, 3];

        yield return [3, new[] { new[] { 0, 1, 10 }, new[] { 1, 2, 10 }, new[] { 0, 2, 25 } }, 20];

        yield return [3, new[] { new[] { 0, 2, 7 }, new[] { 0, 1, 1 }, new[] { 1, 2, 1 } }, 2];

        yield return [3, new[] { new[] { 1, 2, 5 }, new[] { 2, 1, 5 } }, -1];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 }, new[] { 0, 3, 10 } }, 3];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 3, 2, 1 } }, 4];

        yield return [4, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, 2 }, new[] { 2, 3, 2 }, new[] { 3, 0, 1 } }, 2];

        yield return [4, new[] { new[] { 0, 1, 1 }, new[] { 0, 1, 5 }, new[] { 1, 3, 2 }, new[] { 1, 3, 7 } }, 3];

        yield return [4, new[] { new[] { 0, 0, 1 }, new[] { 0, 1, 2 }, new[] { 1, 1, 3 }, new[] { 1, 3, 4 } }, 6];

        yield return [4, new[] { new[] { 0, 1, 10 }, new[] { 0, 2, 1 }, new[] { 2, 1, 1 }, new[] { 0, 3, 50 } }, 50];

        yield return [5, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 }, new[] { 3, 4, 1 } }, 4];

        yield return [5, new[] { new[] { 0, 1, 4 }, new[] { 1, 4, 9 }, new[] { 0, 2, 1 }, new[] { 2, 3, 1 }, new[] { 3, 4, 1 } }, 3];

        yield return [5, new[] { new[] { 4, 3, 1 }, new[] { 3, 2, 1 }, new[] { 2, 1, 1 }, new[] { 1, 0, 1 } }, 8];

        yield return [5, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 } }, -1];

        yield return
        [
            6, new[] { new[] { 0, 1, 3 }, new[] { 1, 2, 3 }, new[] { 2, 5, 3 }, new[] { 0, 3, 1 }, new[] { 3, 4, 1 }, new[] { 4, 5, 20 } }, 9
        ];

        yield return [6, new[] { new[] { 0, 1, 1 }, new[] { 2, 1, 1 }, new[] { 2, 3, 1 }, new[] { 4, 3, 1 }, new[] { 4, 5, 1 } }, 7];

        yield return [6, new[] { new[] { 0, 5, 1000 } }, 1000];

        yield return [6, new[] { new[] { 5, 0, 1000 } }, 2000];

        yield return
        [
            7,
            new[]
            {
                new[] { 0, 1, 2 },
                new[] { 1, 2, 2 },
                new[] { 2, 3, 2 },
                new[] { 3, 4, 2 },
                new[] { 4, 5, 2 },
                new[] { 5, 6, 2 },
                new[] { 6, 0, 1 }
            },
            2
        ];
    }
}