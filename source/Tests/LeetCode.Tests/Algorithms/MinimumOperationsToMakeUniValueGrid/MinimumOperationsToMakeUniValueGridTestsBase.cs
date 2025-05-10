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

using LeetCode.Algorithms.MinimumOperationsToMakeUniValueGrid;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeUniValueGrid;

public abstract class MinimumOperationsToMakeUniValueGridTestsBase<T>
    where T : IMinimumOperationsToMakeUniValueGrid, new()
{
    [TestMethod]
    [DataRow("[[2,4],[6,8]]", 2, 4)]
    [DataRow("[[1,5],[2,3]]", 1, 5)]
    [DataRow("[[1,2],[3,4]]", 2, -1)]
    public void MinOperations_WithGridAndOperationValue_ReturnsMinimumOperationsToMakeUniValueGrid(string gridJson,
        int x, int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<int>.DeserializeToJaggedArray(gridJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(grid, x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}