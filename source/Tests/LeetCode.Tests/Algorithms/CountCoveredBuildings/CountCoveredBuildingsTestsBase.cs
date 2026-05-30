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
    public void CountCoveredBuildings_WithBuildingsInGrid_ReturnsNumberOfBuildingsCoveredFromAllFourDirections(int n, int[][] buildings, int expectedResult)
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
    }
}