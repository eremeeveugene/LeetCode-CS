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

using LeetCode.Algorithms.FindChampion2;

namespace LeetCode.Tests.Algorithms.FindChampion2;

public abstract class FindChampion2TestsBase<T> where T : IFindChampion2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindChampion_WithNodeCountAndDirectedEdges_ReturnsChampionOrMinusOne(int n, int[][] edges, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindChampion(n, edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [1, Array.Empty<int[]>(), 0];

        yield return [2, Array.Empty<int[]>(), -1];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, 0];

        yield return [4, new[] { new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 2 } }, -1];


        yield return [2, new[] { new[] { 0, 1 } }, 0];

        yield return [3, new[] { new[] { 0, 2 }, new[] { 0, 1 } }, 0];

        yield return [3, new[] { new[] { 2, 1 }, new[] { 2, 0 }, new[] { 0, 1 } }, 2];

        yield return [4, new[] { new[] { 3, 1 }, new[] { 2, 3 }, new[] { 2, 1 } }, -1];

        yield return [4, new[] { new[] { 2, 1 }, new[] { 3, 2 }, new[] { 0, 1 }, new[] { 3, 0 } }, 3];

        yield return [5, new[] { new[] { 4, 0 }, new[] { 2, 0 }, new[] { 3, 1 }, new[] { 3, 2 } }, -1];

        yield return [5, new[] { new[] { 1, 0 }, new[] { 3, 0 }, new[] { 3, 4 }, new[] { 0, 2 }, new[] { 0, 4 }, new[] { 1, 3 } }, 1];

        yield return [6, new[] { new[] { 3, 4 }, new[] { 4, 0 }, new[] { 4, 5 }, new[] { 5, 2 }, new[] { 3, 5 } }, -1];

        yield return [6, new[] { new[] { 2, 4 }, new[] { 3, 1 }, new[] { 2, 0 }, new[] { 4, 1 }, new[] { 2, 1 }, new[] { 1, 5 }, new[] { 2, 5 }, new[] { 4, 0 } }, -1];

        yield return [7, new[] { new[] { 5, 0 }, new[] { 5, 4 }, new[] { 0, 1 }, new[] { 3, 1 }, new[] { 2, 4 }, new[] { 6, 5 } }, -1];

        yield return [8, new[] { new[] { 3, 5 }, new[] { 1, 7 }, new[] { 0, 5 }, new[] { 3, 0 }, new[] { 1, 2 }, new[] { 3, 2 }, new[] { 6, 1 } }, -1];

        yield return [8, new[] { new[] { 7, 2 }, new[] { 1, 4 }, new[] { 6, 3 }, new[] { 7, 3 }, new[] { 6, 1 }, new[] { 6, 7 }, new[] { 1, 2 }, new[] { 6, 2 }, new[] { 1, 5 }, new[] { 7, 4 }, new[] { 3, 2 }, new[] { 7, 0 } }, 6];

        yield return [9, new[] { new[] { 8, 5 }, new[] { 8, 6 }, new[] { 4, 7 }, new[] { 8, 2 }, new[] { 8, 7 }, new[] { 2, 5 }, new[] { 1, 0 }, new[] { 7, 5 }, new[] { 7, 3 }, new[] { 0, 2 } }, -1];

        yield return [10, new[] { new[] { 7, 5 }, new[] { 7, 9 }, new[] { 3, 4 }, new[] { 3, 6 }, new[] { 3, 8 }, new[] { 8, 2 }, new[] { 8, 4 }, new[] { 0, 2 }, new[] { 0, 3 } }, -1];

        yield return [10, new[] { new[] { 9, 0 }, new[] { 9, 3 }, new[] { 8, 9 }, new[] { 4, 6 }, new[] { 8, 0 }, new[] { 1, 7 }, new[] { 4, 5 }, new[] { 1, 3 }, new[] { 6, 5 }, new[] { 7, 3 }, new[] { 4, 7 }, new[] { 8, 5 }, new[] { 4, 1 }, new[] { 1, 8 }, new[] { 1, 2 } }, 4];

        yield return [5, new[] { new[] { 4, 3 }, new[] { 3, 2 }, new[] { 2, 1 }, new[] { 1, 0 } }, 4];

        yield return [4, new[] { new[] { 2, 0 }, new[] { 2, 1 }, new[] { 2, 3 } }, 2];

        yield return [3, new[] { new[] { 0, 2 }, new[] { 1, 2 } }, -1];
    }
}