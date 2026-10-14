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

using LeetCode.Algorithms.CountCoveredBuildings;

namespace LeetCode.Tests.Algorithms.CountCoveredBuildings;

public abstract class CountCoveredBuildingsTestsBase<T> where T : ICountCoveredBuildings, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountCoveredBuildings_WithBuildingsInGrid_ReturnsNumberOfBuildingsCoveredFromAllFourDirections(
        int n,
        int[][] buildings,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountCoveredBuildings(n, buildings);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [3, new[] { new[] { 1, 2 }, new[] { 2, 2 }, new[] { 3, 2 }, new[] { 2, 1 }, new[] { 2, 3 } }, 1];

        yield return [3, new[] { new[] { 1, 1 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 2, 2 } }, 0];

        yield return [5, new[] { new[] { 1, 3 }, new[] { 3, 2 }, new[] { 3, 3 }, new[] { 3, 5 }, new[] { 5, 3 } }, 1];

        yield return [2, new[] { new[] { 1, 1 } }, 0];

        yield return [3, new[] { new[] { 2, 2 } }, 0];

        yield return [3, new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 0];

        yield return [3, new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 2, 2 }, new[] { 2, 3 }, new[] { 3, 2 } }, 1];

        yield return [4, new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 2, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 3, 2 }, new[] { 4, 2 }, new[] { 3, 3 } }, 1];

        yield return [5, new[] { new[] { 3, 1 }, new[] { 3, 2 }, new[] { 3, 3 }, new[] { 3, 4 }, new[] { 3, 5 } }, 0];

        yield return [5, new[] { new[] { 1, 3 }, new[] { 2, 3 }, new[] { 3, 3 }, new[] { 4, 3 }, new[] { 5, 3 }, new[] { 3, 1 }, new[] { 3, 5 } }, 1];

        yield return [3, new[] { new[] { 1, 1 }, new[] { 1, 3 }, new[] { 3, 1 }, new[] { 3, 3 }, new[] { 2, 2 } }, 0];

        yield return [4, new[] { new[] { 1, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 1 }, new[] { 2, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 3, 1 }, new[] { 3, 2 }, new[] { 3, 3 }, new[] { 3, 4 }, new[] { 4, 1 }, new[] { 4, 2 }, new[] { 4, 3 }, new[] { 4, 4 } }, 4];

        yield return [6, new[] { new[] { 2, 2 }, new[] { 2, 5 }, new[] { 5, 2 }, new[] { 5, 5 }, new[] { 2, 3 }, new[] { 3, 2 }, new[] { 3, 3 }, new[] { 4, 3 }, new[] { 3, 4 } }, 1];

        yield return [100000, new[] { new[] { 1, 1 } }, 0];

        yield return [100000, new[] { new[] { 1, 50000 }, new[] { 50000, 50000 }, new[] { 100000, 50000 }, new[] { 50000, 1 }, new[] { 50000, 100000 } }, 1];

        yield return [6, new[] { new[] { 4, 5 }, new[] { 6, 4 }, new[] { 1, 2 }, new[] { 5, 6 }, new[] { 3, 4 }, new[] { 4, 3 }, new[] { 6, 5 }, new[] { 5, 5 }, new[] { 1, 6 }, new[] { 1, 4 }, new[] { 2, 6 }, new[] { 6, 2 }, new[] { 2, 2 }, new[] { 3, 1 }, new[] { 3, 6 }, new[] { 5, 3 }, new[] { 4, 1 }, new[] { 4, 6 }, new[] { 1, 1 }, new[] { 2, 1 }, new[] { 3, 2 }, new[] { 1, 5 }, new[] { 1, 3 }, new[] { 6, 6 }, new[] { 3, 5 }, new[] { 5, 1 }, new[] { 6, 3 }, new[] { 2, 5 }, new[] { 4, 2 } }, 10];

        yield return [5, new[] { new[] { 1, 1 }, new[] { 5, 5 }, new[] { 2, 2 }, new[] { 5, 3 }, new[] { 2, 1 }, new[] { 5, 1 }, new[] { 2, 5 }, new[] { 3, 1 }, new[] { 5, 2 } }, 0];

        yield return [5, new[] { new[] { 5, 3 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 2, 5 }, new[] { 1, 1 }, new[] { 3, 2 }, new[] { 3, 4 }, new[] { 2, 1 }, new[] { 1, 5 }, new[] { 2, 4 } }, 0];

        yield return [4, new[] { new[] { 3, 2 }, new[] { 4, 2 }, new[] { 4, 4 }, new[] { 4, 3 }, new[] { 1, 1 }, new[] { 4, 1 }, new[] { 2, 2 }, new[] { 1, 2 }, new[] { 2, 1 } }, 0];

        yield return [6, new[] { new[] { 4, 2 }, new[] { 6, 1 }, new[] { 4, 3 }, new[] { 2, 6 }, new[] { 6, 5 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 1, 6 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 1, 1 }, new[] { 4, 6 }, new[] { 6, 3 }, new[] { 3, 1 }, new[] { 5, 2 }, new[] { 3, 6 }, new[] { 3, 2 }, new[] { 5, 1 }, new[] { 5, 6 }, new[] { 4, 4 }, new[] { 3, 3 }, new[] { 3, 5 }, new[] { 4, 1 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 1, 4 }, new[] { 5, 4 }, new[] { 2, 5 }, new[] { 2, 2 }, new[] { 6, 4 }, new[] { 1, 5 }, new[] { 2, 1 } }, 13];
    }
}