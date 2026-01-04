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

using LeetCode.Algorithms.FindTheMinimumAreaToCoverAllOnes1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheMinimumAreaToCoverAllOnes1;

public abstract class FindTheMinimumAreaToCoverAllOnes1TestsBase<T> where T : IFindTheMinimumAreaToCoverAllOnes1, new()
{
    [TestMethod]
    [DataRow("[[0,1,0],[1,0,1]]", 6)]
    [DataRow("[[1,0],[0,0]]", 1)]
    [DataRow("[[0,0,0,0],[0,0,0,0],[0,0,0,0],[0,0,1,0]]", 1)]
    [DataRow("[[0,0,0,0,0],[0,0,1,0,0],[0,0,0,0,0],[0,1,0,1,0],[0,0,0,0,0]]", 9)]
    [DataRow("[[0,0,0,1],[0,0,0,0],[0,1,0,0],[0,0,0,1]]", 12)]
    public void MinimumArea_WithBinaryGrid_ReturnsMinimumBoundingAreaOfOnes(string gridJson,
        int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<int[][]>.Parse(gridJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumArea(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}