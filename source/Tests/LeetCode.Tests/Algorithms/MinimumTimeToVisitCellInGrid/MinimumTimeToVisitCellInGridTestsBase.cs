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

using LeetCode.Algorithms.MinimumTimeToVisitCellInGrid;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumTimeToVisitCellInGrid;

public abstract class MinimumTimeToVisitCellInGridTestsBase<T> where T : IMinimumTimeToVisitCellInGrid, new()
{
    [TestMethod]
    [DataRow("[[0,1],[1,2]]", 2)]
    [DataRow("[[0,1,3,2],[5,1,2,5],[4,3,8,6]]", 7)]
    [DataRow("[[0,2,4],[3,2,1],[1,0,4]]", -1)]
    public void MinimumTime_GridWithTraversalConstraints_ReturnsTimeToReachBottomRightOrNegativeOne(string gridJson,
        int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<int[][]>.Parse(gridJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumTime(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}