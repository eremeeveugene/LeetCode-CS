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

using LeetCode.Algorithms.MinimumCostToReachEveryPosition;

namespace LeetCode.Tests.Algorithms.MinimumCostToReachEveryPosition;

public abstract class MinimumCostToReachEveryPositionTestsBase<T> where T : IMinimumCostToReachEveryPosition, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 3, 4, 1, 3, 2 }, new[] { 5, 3, 3, 1, 1, 1 })]
    [DataRow(new[] { 1, 2, 4, 6, 7 }, new[] { 1, 1, 1, 1, 1 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 100 }, new[] { 100 })]
    [DataRow(new[] { 7, 7, 7 }, new[] { 7, 7, 7 })]
    [DataRow(new[] { 100, 99, 98, 97 }, new[] { 100, 99, 98, 97 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 1, 1, 1, 1 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 3, 1, 2, 1, 3, 1 }, new[] { 3, 1, 1, 1, 1, 1 })]
    [DataRow(new[] { 50, 20, 30, 10, 40, 5, 60 }, new[] { 50, 20, 20, 10, 10, 5, 5 })]
    [DataRow(new[] { 2, 2 }, new[] { 2, 2 })]
    [DataRow(new[] { 10, 20 }, new[] { 10, 10 })]
    [DataRow(new[] { 20, 10 }, new[] { 20, 10 })]
    [DataRow(new[] { 100, 1, 100, 1, 100 }, new[] { 100, 1, 1, 1, 1 })]
    [DataRow(new[] { 9, 8, 9, 7, 9, 6, 9, 5, 9, 4 }, new[] { 9, 8, 8, 7, 7, 6, 6, 5, 5, 4 })]
    [DataRow(new[] { 42, 17, 17, 99, 3, 3, 3, 100 }, new[] { 42, 17, 17, 17, 3, 3, 3, 3 })]
    [DataRow(new[] { 1, 100, 1, 100, 1, 100 }, new[] { 1, 1, 1, 1, 1, 1 })]
    [DataRow(new[] { 100, 100, 100, 100, 100, 100, 100, 100, 1, 100 }, new[] { 100, 100, 100, 100, 100, 100, 100, 100, 1, 1 })]
    [DataRow(new[] { 64, 83, 12, 93, 41, 77, 6, 55, 29, 88, 14, 2 }, new[] { 64, 64, 12, 12, 12, 12, 6, 6, 6, 6, 6, 2 })]
    [DataRow(new[] { 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
    public void MinCosts_WithCostArray_ReturnsMinimumCostAtEachStep(int[] cost, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinCosts(cost);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}