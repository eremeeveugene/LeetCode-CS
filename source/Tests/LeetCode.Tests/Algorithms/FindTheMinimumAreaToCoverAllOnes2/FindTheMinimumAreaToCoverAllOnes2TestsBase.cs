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

using LeetCode.Algorithms.FindTheMinimumAreaToCoverAllOnes2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheMinimumAreaToCoverAllOnes2;

public abstract class FindTheMinimumAreaToCoverAllOnes2TestsBase<T> where T : IFindTheMinimumAreaToCoverAllOnes2, new()
{
    [TestMethod]
    [DataRow("[[1,0,1],[1,1,1]]", 5)]
    [DataRow("[[1,0,1,0],[0,1,0,1]]", 5)]
    public void MinimumSum_WithBinaryGrid_ReturnsMinimumSumOfRectanglesArea(string gridJson, int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<int[][]>.Parse(gridJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumSum(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}