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

using LeetCode.Algorithms.FindCenterOfStarGraph;

namespace LeetCode.Tests.Algorithms.FindCenterOfStarGraph;

public abstract class FindCenterOfStarGraphTestsBase<T> where T : IFindCenterOfStarGraph, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindCenter_GivenEdgesJson_ReturnsCenterNode(int[][] edges, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindCenter(edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 4, 2 } }, 2];

        yield return [new[] { new[] { 1, 2 }, new[] { 5, 1 }, new[] { 1, 3 }, new[] { 1, 4 } }, 1];

        yield return [new[] { new[] { 3, 1 }, new[] { 3, 2 } }, 3];

        yield return [new[] { new[] { 2, 1 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 2, 5 } }, 2];

        yield return [new[] { new[] { 10, 1 }, new[] { 10, 2 }, new[] { 10, 3 } }, 10];

        yield return [new[] { new[] { 5, 2 }, new[] { 3, 5 }, new[] { 5, 4 } }, 5];

        yield return [new[] { new[] { 1, 7 }, new[] { 7, 2 }, new[] { 7, 3 }, new[] { 7, 4 }, new[] { 7, 5 } }, 7];

        yield return [new[] { new[] { 4, 1 }, new[] { 4, 2 }, new[] { 4, 3 }, new[] { 4, 5 }, new[] { 4, 6 } }, 4];

        yield return [new[] { new[] { 6, 1 }, new[] { 6, 2 } }, 6];

        yield return [new[] { new[] { 100, 1 }, new[] { 100, 2 }, new[] { 100, 3 }, new[] { 100, 4 } }, 100];

        yield return [new[] { new[] { 1, 9 }, new[] { 2, 9 }, new[] { 3, 9 } }, 9];

        yield return [new[] { new[] { 8, 3 }, new[] { 8, 5 }, new[] { 8, 7 } }, 8];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 2 }, new[] { 4, 2 }, new[] { 5, 2 }, new[] { 6, 2 } }, 2];

        yield return [new[] { new[] { 11, 1 }, new[] { 11, 2 }, new[] { 11, 3 }, new[] { 11, 4 }, new[] { 11, 5 }, new[] { 11, 6 } }, 11];

        yield return [new[] { new[] { 2, 5 }, new[] { 5, 3 }, new[] { 5, 4 }, new[] { 5, 6 }, new[] { 5, 7 } }, 5];

        yield return [new[] { new[] { 20, 1 }, new[] { 20, 2 }, new[] { 20, 3 } }, 20];

        yield return [new[] { new[] { 7, 1 }, new[] { 7, 2 }, new[] { 7, 3 }, new[] { 7, 4 } }, 7];

        yield return [new[] { new[] { 99, 1 }, new[] { 99, 2 } }, 99];
    }
}