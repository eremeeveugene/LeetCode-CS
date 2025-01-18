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

using LeetCode.Algorithms.MinimumCostToMakeAtLeastOneValidPathInGrid;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumCostToMakeAtLeastOneValidPathInGrid;

public abstract class MinimumCostToMakeAtLeastOneValidPathInGridTestsBase<T>
    where T : IMinimumCostToMakeAtLeastOneValidPathInGrid, new()
{
    [TestMethod]
    [DataRow("[[1,1,1,1],[2,2,2,2],[1,1,1,1],[2,2,2,2]]", 3)]
    [DataRow("[[1,1,3],[3,2,2],[1,1,4]]", 0)]
    [DataRow("[[1,2],[4,3]]", 1)]
    public void MinCost_WithGridJsonArray_ReturnsMinimumCost(string gridJsonArray, int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<int>.DeserializeToJaggedArray(gridJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinCost(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}