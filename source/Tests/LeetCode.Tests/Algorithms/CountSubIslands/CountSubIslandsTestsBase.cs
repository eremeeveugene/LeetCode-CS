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

using LeetCode.Algorithms.CountSubIslands;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountSubIslands;

public abstract class CountSubIslandsTestsBase<T> where T : ICountSubIslands, new()
{
    [TestMethod]
    [DataRow("[[1,1,1,0,0],[0,1,1,1,1],[0,0,0,0,0],[1,0,0,0,0],[1,1,0,1,1]]",
        "[[1,1,1,0,0],[0,0,1,1,1],[0,1,0,0,0],[1,0,1,1,0],[0,1,0,1,0]]", 3)]
    [DataRow("[[1,0,1,0,1],[1,1,1,1,1],[0,0,0,0,0],[1,1,1,1,1],[1,0,1,0,1]]",
        "[[0,0,0,0,0],[1,1,1,1,1],[0,1,0,1,0],[0,1,0,1,0],[1,0,0,0,1]]", 2)]
    public void CountSubIslands_GivenTwoGrids_ReturnsCorrectSubIslandCount(string grid1JsonArray, string grid2JsonArray,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        var grid1 = JsonHelper<int>.JsonArrayToJaggedArray(grid1JsonArray);
        var grid2 = JsonHelper<int>.JsonArrayToJaggedArray(grid2JsonArray);

        // Act
        var actualResult = solution.CountSubIslands(grid1, grid2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}