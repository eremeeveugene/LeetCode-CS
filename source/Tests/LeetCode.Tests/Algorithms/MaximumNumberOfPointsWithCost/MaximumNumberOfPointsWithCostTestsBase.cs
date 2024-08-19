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

using LeetCode.Algorithms.MaximumNumberOfPointsWithCost;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfPointsWithCost;

public abstract class MaximumNumberOfPointsWithCostTestsBase<T> where T : IMaximumNumberOfPointsWithCost, new()
{
    [TestMethod]
    [DataRow("[[1]]", 1)]
    [DataRow("[[5,1,100,3]]", 100)]
    [DataRow("[[1,5],[2,3],[4,2]]", 11)]
    [DataRow("[[1,2,3],[1,5,1],[3,1,1]]", 9)]
    [DataRow("[[0, 0, 0, 0, 0],[0, 0, 100000, 0, 0],[0, 0, 0, 0, 0]]", 100000)]
    [DataRow(
        "[[100000, 1, 1, 1, 1, 1],[1, 1, 1, 1, 1, 100000],[1, 1, 1, 1, 1, 1],[100000, 1, 1, 1, 1, 1],[1, 100000, 1, 1, 1, 1]]",
        399990)]
    [DataRow(
        "[[100000, 90000, 80000, 70000, 60000, 50000],[1, 2, 3, 4, 5, 6],[100000, 90000, 80000, 70000, 60000, 50000],[5, 10, 15, 20, 25, 30],[100000, 90000, 80000, 70000, 60000, 50000]]",
        300021)]
    public void MaxPoints_WithJaggedArrayOfPoints_ReturnsMaximumPoints(string pointsJsonArray, long expectedResult)
    {
        // Arrange
        var solution = new T();

        var points = JsonHelper<int>.DeserializeToJaggedArray(pointsJsonArray);

        // Act
        var actualResult = solution.MaxPoints(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}