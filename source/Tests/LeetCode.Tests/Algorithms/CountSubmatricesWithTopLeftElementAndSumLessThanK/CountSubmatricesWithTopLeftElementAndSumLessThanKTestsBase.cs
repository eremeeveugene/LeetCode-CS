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

using LeetCode.Algorithms.CountSubmatricesWithTopLeftElementAndSumLessThanK;

namespace LeetCode.Tests.Algorithms.CountSubmatricesWithTopLeftElementAndSumLessThanK;

public abstract class CountSubmatricesWithTopLeftElementAndSumLessThanKTestsBase<T> where T : ICountSubmatricesWithTopLeftElementAndSumLessThanK, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountSubmatrices_WithGridAndK_ReturnsNumberOfTopLeftSubmatricesWithSumNotAboveK(int[][] grid, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubmatrices(grid, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 7, 6, 3 }, new[] { 6, 6, 1 } }, 18, 4];

        yield return [new[] { new[] { 7, 2, 9 }, new[] { 1, 5, 0 }, new[] { 2, 6, 6 } }, 20, 6];

        yield return [new[] { new[] { 1 } }, 1, 1];

        yield return [new[] { new[] { 2 } }, 1, 0];

        yield return [new[] { new[] { 0 } }, 5, 1];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 10, 4];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 3, 2];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 1, 1];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 9, 3];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 1, 4];

        yield return [new[] { new[] { 5, 5, 5 } }, 10, 2];

        yield return [new[] { new[] { 5 }, new[] { 5 }, new[] { 5 } }, 10, 2];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 4, 6];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 9, 9];

        yield return [new[] { new[] { 1000 } }, 1000000000, 1];

        yield return [new[] { new[] { 1000, 1000 }, new[] { 1000, 1000 } }, 999, 0];

        yield return [new[] { new[] { 10, 20 }, new[] { 30, 40 } }, 100, 4];

        yield return [new[] { new[] { 10, 20 }, new[] { 30, 40 } }, 99, 3];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, 12, 5];

        yield return [new[] { new[] { 3, 2 }, new[] { 1, 0 }, new[] { 4, 4 } }, 10, 5];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 1000000000, 6];

        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, 6, 3];

        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 }, new[] { 5 } }, 6, 3];

        yield return [new[] { new[] { 7, 6, 3 }, new[] { 6, 6, 1 } }, 100, 6];
    }
}