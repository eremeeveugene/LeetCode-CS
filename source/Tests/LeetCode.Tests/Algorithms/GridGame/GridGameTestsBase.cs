// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.GridGame;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.GridGame;

public abstract class GridGameTestsBase<T> where T : IGridGame, new()
{
    [TestMethod]
    [DataRow("[[2,5,4],[1,5,1]]", 4)]
    [DataRow("[[3,3,1],[8,5,2]]", 4)]
    [DataRow("[[1,3,1,15],[1,3,3,1]]", 4)]
    [DataRow("[[1,3,1,15],[1,3,3,1]]", 4)]
    public void GridGame_WithInputGrid_ReturnsPointsCollectedBySecondRobot(string handJsonArray,
        int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<int>.DeserializeToJaggedArray(handJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.GridGame(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}