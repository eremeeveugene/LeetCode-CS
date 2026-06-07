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

using LeetCode.Algorithms.FindIfPathExistsInGraph;

namespace LeetCode.Tests.Algorithms.FindIfPathExistsInGraph;

public abstract class FindIfPathExistsInGraphTestsBase<T> where T : IFindIfPathExistsInGraph, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ValidPath_WithGraphAndSourceDestination_ReturnsWhetherPathExistsBetweenNodes(int n, int[][] edges, int source, int destination, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ValidPath(n, edges, source, destination);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 0 } }, 0, 2, true];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 3, 5 }, new[] { 5, 4 }, new[] { 4, 3 } }, 0, 5, false];

        yield return [1, new int[][] { }, 0, 0, true];

        yield return [2, new[] { new[] { 0, 1 } }, 0, 1, true];

        yield return [2, new[] { new[] { 0, 1 } }, 1, 0, true];

        yield return [2, new int[][] { }, 0, 1, false];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 2, 3 } }, 0, 3, false];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 } }, 0, 3, true];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, 0, 4, true];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 3, 4 } }, 0, 4, false];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } }, 1, 3, true];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, 0, 2, true];

        yield return [3, new[] { new[] { 0, 1 } }, 0, 2, false];

        yield return [5, new[] { new[] { 0, 4 }, new[] { 4, 3 }, new[] { 3, 2 }, new[] { 2, 1 } }, 0, 1, true];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, 0, 5, true];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 4, 5 } }, 0, 5, false];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 2 }, new[] { 2, 3 } }, 0, 3, true];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 2 } }, 1, 2, true];

        yield return [10, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 }, new[] { 8, 9 } }, 0, 9, false];
    }
}