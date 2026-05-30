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
        var actualResult = solution.FindMinHeightTrees(n, edges).ToArray();

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
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

        yield return [8, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 5 }, new[] { 2, 6 }, new[] { 6, 7 } }, new[] { 0, 2 }];

        yield return [9, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 6, 7 }, new[] { 7, 8 } }, new[] { 4, 5 }];
    }
}