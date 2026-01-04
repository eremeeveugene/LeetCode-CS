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

using LeetCode.Algorithms.MaximumAreaOfLongestDiagonalRectangle;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumAreaOfLongestDiagonalRectangle;

public abstract class MaximumAreaOfLongestDiagonalRectangleTestsBase<T>
    where T : IMaximumAreaOfLongestDiagonalRectangle, new()
{
    [TestMethod]
    [DataRow("[[9,3],[8,6]]", 48)]
    [DataRow("[[3,4],[4,3]]", 12)]
    [DataRow("[[2,6],[5,1],[3,10],[8,4]]", 30)]
    [DataRow("[[6,5],[8,6],[2,10],[8,1],[9,2],[3,5],[3,5]]", 20)]
    public void AreaOfMaxDiagonal_WithDimensionsArray_ReturnsAreaOfRectangleHavingTheLongestDiagonal(
        string dimensionsJson, double expectedResult)
    {
        // Arrange
        var dimensions = JsonHelper<int[][]>.Parse(dimensionsJson);

        var solution = new T();

        // Act
        var actualResult = solution.AreaOfMaxDiagonal(dimensions);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}