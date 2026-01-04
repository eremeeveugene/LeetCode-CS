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

using LeetCode.Algorithms.MaximumNumberOfMovesInGrid;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfMovesInGrid;

public abstract class MaximumNumberOfMovesInGridTestsBase<T> where T : IMaximumNumberOfMovesInGrid, new()
{
    [TestMethod]
    [DataRow("[[2,4,3,5],[5,4,9,3],[3,4,2,11],[10,9,13,15]]", 3)]
    [DataRow("[[3,2,4],[2,1,9],[1,1,7]]", 0)]
    public void MaxMoves_WithGridInput_ReturnsMaximumMoves(string gridJson, int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<int[][]>.Parse(gridJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxMoves(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}