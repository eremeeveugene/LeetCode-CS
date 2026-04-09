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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountCoveredBuildings;

public abstract class CountCoveredBuildingsTestsBase<T> where T : ICountCoveredBuildings, new()
{
    [TestMethod]
    [DataRow(3, "[[1,2],[2,2],[3,2],[2,1],[2,3]]", 1)]
    [DataRow(3, "[[1,1],[1,2],[2,1],[2,2]]", 0)]
    [DataRow(5, "[[1,3],[3,2],[3,3],[3,5],[5,3]]", 1)]
    public void CountCoveredBuildings_WithBuildingsInGrid_ReturnsNumberOfBuildingsCoveredFromAllFourDirections(int n,
        string buildingsJson, int expectedResult)
    {
        // Arrange
        var buildings = JsonHelper.Parse<int[][]>(buildingsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountCoveredBuildings(n, buildings);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}