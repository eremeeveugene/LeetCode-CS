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

using LeetCode.Algorithms.MinimumNumberOfDaysToDisconnectIsland;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfDaysToDisconnectIsland;

public abstract class MinimumNumberOfDaysToDisconnectIslandTestsBase<T>
    where T : IMinimumNumberOfDaysToDisconnectIsland, new()
{
    [TestMethod]
    [DataRow("[[1,0],[0,1]]", 0)]
    [DataRow("[[1,1]]", 2)]
    [DataRow("[[0,0,0],[0,1,0],[0,0,0]]", 1)]
    [DataRow("[[1,1,0],[1,1,1],[0,1,0]]", 1)]
    [DataRow("[[0,1,1,0],[0,1,1,0],[0,0,0,0]]", 2)]
    [DataRow("[[1,1,1,1],[1,1,1,1],[1,1,1,1],[1,1,1,1]]", 2)]
    [DataRow("[[0,1,0,1,1],[1,1,1,1,1],[1,1,1,1,1],[1,1,1,1,0]]", 1)]
    [DataRow("[[1,1,0,1,1],[1,1,1,1,1],[1,1,0,1,1],[1,1,0,1,1]]", 1)]
    [DataRow(
        "[[1,1,1,1,1,1,1,1,1,1], [1,1,1,1,1,1,1,1,1,1], [1,1,1,1,1,1,1,1,1,1], [1,1,1,1,1,1,1,1,1,1], [1,1,1,1,1,1,1,1,1,1], [1,1,1,1,1,1,1,1,1,1], [1,1,1,1,1,1,1,1,1,1]]",
        2)]
    [DataRow(
        "[[1,0,1,1,1,0,1,1,1,1,1],[1,0,1,1,0,0,0,1,1,0,1],[0,0,1,1,1,1,0,1,1,1,0],[1,1,1,1,1,0,1,1,1,1,1],[1,1,1,0,0,1,1,1,1,1,0],[0,1,0,1,1,1,1,1,1,0,1],[1,1,1,1,1,1,0,1,1,1,1],[1,1,1,0,0,1,1,1,1,1,1],[0,1,1,1,1,1,1,0,1,1,1]]",
        0)]
    [DataRow(
        "[[1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1], [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1], [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1], [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1], [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1], [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1], [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1], [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1], [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1], [1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1]]",
        1)]
    public void MinDays_GivenGridJsonArray_ReturnsMinimumDaysToSeparateIsland(string gridJsonArray, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var grid = JsonHelper<int>.JsonArrayToJaggedArray(gridJsonArray);

        // Act
        var actualResult = solution.MinDays(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}