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

using LeetCode.Algorithms.CountIslandsWithTotalValueDivisibleByK;

namespace LeetCode.Tests.Algorithms.CountIslandsWithTotalValueDivisibleByK;

public abstract class CountIslandsWithTotalValueDivisibleByKTestsBase<T> where T : ICountIslandsWithTotalValueDivisibleByK, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountIslands_WithGridAndK_ReturnsNumberOfIslandsWithTotalValueDivisibleByK(int[][] grid, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountIslands(grid, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 0, 2, 1, 0, 0 }, new[] { 0, 5, 0, 0, 5 }, new[] { 0, 0, 1, 0, 0 }, new[] { 0, 1, 4, 7, 0 }, new[] { 0, 2, 0, 0, 8 } },
            5,
            2
        ];

        yield return [new[] { new[] { 3, 0, 3, 0 }, new[] { 0, 3, 0, 3 }, new[] { 3, 0, 3, 0 } }, 3, 6];

        yield return [new[] { new[] { 0 } }, 1, 0];

        yield return [new[] { new[] { 5 } }, 5, 1];

        yield return [new[] { new[] { 5 } }, 3, 0];

        yield return [new[] { new[] { 1, 1, 1 } }, 3, 1];

        yield return [new[] { new[] { 1, 1, 1 } }, 2, 0];

        yield return [new[] { new[] { 1, 0, 1 } }, 1, 2];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 7, 0];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 10, 1];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 3, 0];

        yield return [new[] { new[] { 2, 0 }, new[] { 0, 2 } }, 2, 2];

        yield return [new[] { new[] { 1000000, 1000000 }, new[] { 1000000, 1000000 } }, 1000000, 1];

        yield return [new[] { new[] { 1000000, 999999 }, new[] { 0, 1 } }, 1000000, 1];

        yield return [new[] { new[] { 7 }, new[] { 0 }, new[] { 7 }, new[] { 0 }, new[] { 7 } }, 7, 3];

        yield return [new[] { new[] { 1, 0, 2 }, new[] { 0, 3, 0 }, new[] { 4, 0, 5 } }, 3, 1];

        yield return [new[] { new[] { 1, 1, 0, 0 }, new[] { 1, 1, 0, 0 }, new[] { 0, 0, 1, 1 }, new[] { 0, 0, 1, 1 } }, 4, 2];

        yield return [new[] { new[] { 1, 1, 0, 0 }, new[] { 1, 1, 0, 0 }, new[] { 0, 0, 1, 1 }, new[] { 0, 0, 1, 2 } }, 4, 1];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 1 } }, 8, 1];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 5, 1 }, new[] { 1, 1, 1 } }, 13, 1];

        yield return [new[] { new[] { 2, 0, 2, 0, 2 } }, 4, 0];

        yield return [new[] { new[] { 6, 0, 4 }, new[] { 0, 0, 0 }, new[] { 3, 0, 9 } }, 3, 3];

        yield return [new[] { new[] { 1, 1, 1, 1 }, new[] { 0, 0, 0, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 0, 0, 0 }, new[] { 1, 1, 1, 1 } }, 7, 1];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 9, 0 }, new[] { 0, 0, 0 } }, 1, 1];

        yield return [new[] { new[] { 5, 0, 5 }, new[] { 0, 0, 0 }, new[] { 5, 0, 5 } }, 10, 0];

        yield return [new[] { new[] { 3, 0, 3, 3 } }, 6, 1];
    }
}