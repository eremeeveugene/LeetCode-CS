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

using LeetCode.Algorithms.FindMinimumDiameterAfterMergingTwoTrees;

namespace LeetCode.Tests.Algorithms.FindMinimumDiameterAfterMergingTwoTrees;

public abstract class FindMinimumDiameterAfterMergingTwoTreesTestsBase<T> where T : IFindMinimumDiameterAfterMergingTwoTrees, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumDiameterAfterMerge_WithTwoGraphs_CalculatesMinimumDiameter(int[][] edges1, int[][] edges2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumDiameterAfterMerge(edges1, edges2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } }, new[] { new[] { 0, 1 } }, 3];

        yield return
        [
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 2, 4 }, new[] { 2, 5 }, new[] { 3, 6 }, new[] { 2, 7 } },
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 2, 4 }, new[] { 2, 5 }, new[] { 3, 6 }, new[] { 2, 7 } },
            5
        ];

        yield return [Array.Empty<int[]>(), Array.Empty<int[]>(), 1];

        yield return [Array.Empty<int[]>(), new[] { new[] { 1, 0 } }, 2];

        yield return [new[] { new[] { 0, 1 } }, Array.Empty<int[]>(), 2];

        yield return [new[] { new[] { 0, 1 } }, new[] { new[] { 1, 0 } }, 3];

        yield return [Array.Empty<int[]>(), new[] { new[] { 1, 0 }, new[] { 2, 1 }, new[] { 0, 3 }, new[] { 0, 4 } }, 3];

        yield return [new[] { new[] { 1, 0 }, new[] { 2, 1 } }, new[] { new[] { 1, 0 }, new[] { 2, 0 } }, 3];

        yield return [new[] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 1, 3 } }, new[] { new[] { 1, 0 } }, 4];

        yield return [new[] { new[] { 1, 0 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 0, 4 } }, new[] { new[] { 1, 0 }, new[] { 2, 1 }, new[] { 3, 1 }, new[] { 4, 2 } }, 5];

        yield return [new[] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 5, 2 } }, new[] { new[] { 1, 0 }, new[] { 0, 2 } }, 4];

        yield return [new[] { new[] { 0, 1 }, new[] { 0, 2 } }, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 4, 1 }, new[] { 3, 5 }, new[] { 6, 1 } }, 4];

        yield return [new[] { new[] { 0, 1 }, new[] { 2, 1 }, new[] { 1, 3 }, new[] { 0, 4 }, new[] { 5, 2 }, new[] { 6, 3 } }, new[] { new[] { 1, 0 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 4, 2 }, new[] { 5, 0 }, new[] { 6, 5 } }, 5];

        yield return [new[] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 1, 3 }, new[] { 4, 3 }, new[] { 2, 5 }, new[] { 6, 5 }, new[] { 7, 2 } }, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } }, 6];

        yield return [new[] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 0, 3 } }, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 3, 0 } }, 3];

        yield return [new[] { new[] { 0, 1 }, new[] { 2, 1 }, new[] { 3, 0 }, new[] { 0, 4 }, new[] { 5, 4 } }, new[] { new[] { 1, 0 }, new[] { 1, 2 }, new[] { 3, 2 }, new[] { 4, 3 }, new[] { 5, 3 } }, 5];

        yield return [new[] { new[] { 0, 1 } }, new[] { new[] { 1, 0 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 4, 1 }, new[] { 1, 5 }, new[] { 6, 2 }, new[] { 7, 5 } }, 5];

        yield return [new[] { new[] { 1, 0 }, new[] { 1, 2 }, new[] { 0, 3 }, new[] { 4, 3 } }, new[] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 0, 3 }, new[] { 4, 1 }, new[] { 1, 5 }, new[] { 2, 6 }, new[] { 7, 5 } }, 6];

        yield return [new[] { new[] { 1, 0 }, new[] { 1, 2 }, new[] { 3, 1 }, new[] { 0, 4 }, new[] { 5, 4 }, new[] { 1, 6 }, new[] { 7, 1 } }, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 3, 4 }, new[] { 3, 5 }, new[] { 0, 6 }, new[] { 7, 0 } }, 5];

        yield return [new[] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 3, 1 }, new[] { 1, 4 }, new[] { 5, 0 }, new[] { 6, 4 } }, new[] { new[] { 1, 0 } }, 4];
    }
}