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

using LeetCode.Algorithms.ModifyGraphEdgeWeights;

namespace LeetCode.Tests.Algorithms.ModifyGraphEdgeWeights;

public abstract class ModifyGraphEdgeWeightsTestsBase<T> where T : IModifyGraphEdgeWeights, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ModifiedGraphEdges_WithGivenParameters_ReturnsModifiedEdges(
        int n,
        int[][] edges,
        int source,
        int destination,
        int target,
        int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ModifiedGraphEdges(n, edges, source, destination, target);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [3, new[] { new[] { 0, 1, -1 }, new[] { 0, 2, 5 } }, 0, 2, 6, Array.Empty<int[]>()];

        yield return
        [
            4,
            new[] { new[] { 1, 0, 4 }, new[] { 1, 2, 3 }, new[] { 2, 3, 5 }, new[] { 0, 3, -1 } },
            0,
            2,
            6,
            new[] { new[] { 1, 0, 4 }, new[] { 1, 2, 3 }, new[] { 2, 3, 5 }, new[] { 0, 3, 1 } }
        ];

        yield return
        [
            5,
            new[] { new[] { 4, 1, -1 }, new[] { 2, 0, -1 }, new[] { 0, 3, -1 }, new[] { 4, 3, -1 } },
            0,
            1,
            5,
            new[] { new[] { 4, 1, 1 }, new[] { 2, 0, 3 }, new[] { 0, 3, 3 }, new[] { 4, 3, 1 } }
        ];

        yield return [2, new[] { new[] { 0, 1, 5 } }, 0, 1, 3, Array.Empty<int[]>()];

        yield return
        [
            4,
            new[] { new[] { 0, 1, 1 }, new[] { 0, 2, 5 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 }, new[] { 1, 3, 10 } },
            0,
            3,
            3,
            new[] { new[] { 0, 1, 1 }, new[] { 0, 2, 5 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 }, new[] { 1, 3, 10 } }
        ];
        yield return [2, new[] { new[] { 0, 1, -1 } }, 0, 1, 1, new[] { new[] { 0, 1, 1 } }];
        yield return [2, new[] { new[] { 0, 1, -1 } }, 0, 1, 2, new[] { new[] { 0, 1, 2 } }];
        yield return [2, new[] { new[] { 0, 1, -1 } }, 0, 1, 1000000000, new[] { new[] { 0, 1, 1000000000 } }];
        yield return [2, new[] { new[] { 1, 0, -1 } }, 1, 0, 7, new[] { new[] { 1, 0, 7 } }];
        yield return [2, new[] { new[] { 0, 1, -1 } }, 1, 0, 9, new[] { new[] { 0, 1, 9 } }];
        yield return [3, new[] { new[] { 0, 1, -1 }, new[] { 1, 2, 4 } }, 0, 2, 5, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 4 } }];
        yield return [3, new[] { new[] { 0, 1, -1 }, new[] { 1, 2, 4 } }, 0, 2, 10, new[] { new[] { 0, 1, 6 }, new[] { 1, 2, 4 } }];
        yield return [3, new[] { new[] { 0, 1, -1 }, new[] { 1, 2, 4 } }, 0, 2, 4, Array.Empty<int[]>()];
        yield return [3, new[] { new[] { 0, 1, 2 } }, 0, 2, 5, Array.Empty<int[]>()];
        yield return [4, new[] { new[] { 0, 1, -1 }, new[] { 1, 2, -1 }, new[] { 2, 3, -1 } }, 0, 3, 3, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 2, 3, 1 } }];
        yield return [4, new[] { new[] { 0, 1, -1 }, new[] { 1, 2, -1 }, new[] { 2, 3, -1 } }, 0, 3, 2, Array.Empty<int[]>()];
        yield return [4, new[] { new[] { 0, 1, 3 }, new[] { 1, 2, 3 }, new[] { 2, 3, 3 } }, 0, 3, 9, new[] { new[] { 0, 1, 3 }, new[] { 1, 2, 3 }, new[] { 2, 3, 3 } }];
        yield return [4, new[] { new[] { 0, 1, 3 }, new[] { 1, 2, 3 }, new[] { 2, 3, 3 } }, 0, 3, 8, Array.Empty<int[]>()];
        yield return [4, new[] { new[] { 0, 1, 3 }, new[] { 1, 2, 3 }, new[] { 2, 3, 3 } }, 0, 3, 10, Array.Empty<int[]>()];
        yield return [3, new[] { new[] { 0, 1, -1 }, new[] { 1, 2, -1 }, new[] { 0, 2, 2 } }, 0, 2, 3, Array.Empty<int[]>()];
        yield return [2, new[] { new[] { 0, 1, 10000000 } }, 0, 1, 10000000, new[] { new[] { 0, 1, 10000000 } }];
        yield return [2, new[] { new[] { 0, 1, 10000000 } }, 0, 1, 1000000000, Array.Empty<int[]>()];
        yield return [4, new[] { new[] { 0, 1, -1 }, new[] { 1, 2, 5 }, new[] { 2, 3, -1 } }, 0, 3, 7, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 5 }, new[] { 2, 3, 1 } }];
        yield return [5, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, -1 }, new[] { 2, 3, 2 }, new[] { 3, 4, 2 } }, 0, 4, 7, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, 1 }, new[] { 2, 3, 2 }, new[] { 3, 4, 2 } }];
        yield return [5, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, -1 }, new[] { 2, 3, 2 }, new[] { 3, 4, 2 } }, 0, 4, 10, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, 4 }, new[] { 2, 3, 2 }, new[] { 3, 4, 2 } }];
    }
}