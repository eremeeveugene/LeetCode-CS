// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.IslandPerimeter;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.IslandPerimeter;

public abstract class IslandPerimeterTestsBase<T> where T : IIslandPerimeter, new()
{
    [TestMethod]
    [DataRow("[[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]", 16)]
    [DataRow("[[1]]", 4)]
    [DataRow("[[1,0]]", 4)]
    public void IslandPerimeter_GivenGrid_ReturnsCorrectPerimeter(string gridJsonArray, int expectedResult)
    {
        // Arrange
        var grid = JsonConvertHelper<int>.JsonArrayToJaggedArray(gridJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.IslandPerimeter(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}