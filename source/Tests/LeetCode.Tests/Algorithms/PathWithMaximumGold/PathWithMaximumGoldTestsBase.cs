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

using LeetCode.Algorithms.PathWithMaximumGold;

namespace LeetCode.Tests.Algorithms.PathWithMaximumGold;

public abstract class PathWithMaximumGoldTestsBase<T> where T : IPathWithMaximumGold, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void GetMaximumGold_WithGridJson_ReturnsMaximumGoldCollected(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetMaximumGold(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0 } }, 0];

        yield return [new[] { new[] { 100 } }, 100];

        yield return [new[] { new[] { 0, 6, 0 }, new[] { 5, 8, 7 }, new[] { 0, 9, 0 } }, 24];

        yield return [new[] { new[] { 1, 0, 7 }, new[] { 2, 0, 6 }, new[] { 3, 4, 5 }, new[] { 0, 3, 0 }, new[] { 9, 0, 20 } }, 28];

        yield return [new[] { new[] { 0, 56, 0, 41, 0 }, new[] { 0, 0, 45, 0, 0 }, new[] { 70, 0, 0, 0, 0 }, new[] { 11, 0, 67, 0, 0 }, new[] { 66, 0, 0, 67, 0 } }, 147];

        yield return [new[] { new[] { 1, 0, 7, 0, 0, 0 }, new[] { 2, 0, 6, 0, 1, 0 }, new[] { 3, 5, 6, 7, 4, 2 }, new[] { 4, 3, 1, 0, 2, 0 }, new[] { 3, 0, 5, 0, 20, 0 } }, 60];

        yield return [new[] { new[] { 0, 0, 0, 0, 0, 0, 11, 0, 0, 98 }, new[] { 69, 31, 0, 0, 80, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 34, 0, 0, 0, 0 }, new[] { 51, 0, 0, 0, 0, 69, 9, 0, 0, 0 }, new[] { 0, 44, 91, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 83, 0, 0, 49, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 74, 6, 0, 59, 0, 0, 0 }, new[] { 46, 0, 0, 0, 0, 0, 69, 0, 0, 0 } }, 135];
    }
}