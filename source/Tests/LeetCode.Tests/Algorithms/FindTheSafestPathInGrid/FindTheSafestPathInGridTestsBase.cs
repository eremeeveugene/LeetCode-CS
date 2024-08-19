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

using LeetCode.Algorithms.FindTheSafestPathInGrid;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheSafestPathInGrid;

public abstract class FindTheSafestPathInGridTestsBase<T> where T : IFindTheSafestPathInGrid, new()
{
    [TestMethod]
    [DataRow("[[1,0,0],[0,0,0],[0,0,1]]", 0)]
    [DataRow("[[0,0,1],[0,0,0],[0,0,0]]", 2)]
    [DataRow("[[0,0,0,1],[0,0,0,0],[0,0,0,0],[1,0,0,0]]", 2)]
    public void MaximumSafenessFactor_WithVariousGrids_ReturnsCorrectSafetyLevels(string gridJsonArray,
        int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<int>.DeserializeToJaggedList(gridJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumSafenessFactor(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}