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

using LeetCode.Algorithms.ClimbingStairs2;

namespace LeetCode.Tests.Algorithms.ClimbingStairs2;

public abstract class ClimbingStairs2TestsBase<T> where T : IClimbingStairs2, new()
{
    [TestMethod]
    [DataRow(4, new[] { 1, 2, 3, 4 }, 13)]
    [DataRow(4, new[] { 5, 1, 6, 2 }, 11)]
    [DataRow(3, new[] { 9, 8, 3 }, 12)]
    [DataRow(1, new[] { 1 }, 2)]
    [DataRow(1, new[] { 10000 }, 10001)]
    [DataRow(2, new[] { 1, 1 }, 4)]
    [DataRow(2, new[] { 5, 1 }, 5)]
    [DataRow(2, new[] { 1, 5 }, 8)]
    [DataRow(3, new[] { 1, 1, 1 }, 6)]
    [DataRow(3, new[] { 100, 100, 1 }, 10)]
    [DataRow(3, new[] { 1, 100, 100 }, 106)]
    [DataRow(6, new[] { 3, 3, 3, 3, 3, 3 }, 21)]
    [DataRow(6, new[] { 10, 1, 10, 1, 10, 1 }, 15)]
    [DataRow(6, new[] { 1, 10, 1, 10, 1, 10 }, 23)]
    [DataRow(6, new[] { 100, 100, 1, 100, 100, 1 }, 20)]
    [DataRow(8, new[] { 2, 2, 2, 2, 2, 2, 2, 2 }, 24)]
    [DataRow(4, new[] { 10000, 10000, 10000, 10000 }, 20008)]
    [DataRow(7, new[] { 7, 3, 8, 2, 9, 1, 6 }, 25)]
    [DataRow(8, new[] { 4, 9, 1, 7, 3, 8, 2, 5 }, 29)]
    [DataRow(10, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 48)]
    [DataRow(10, new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 43)]
    [DataRow(8, new[] { 50, 1, 50, 50, 1, 50, 50, 1 }, 25)]
    public void ClimbStairs_WithNAndCosts_ReturnsMinimumTotalCost(int n, int[] costs, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ClimbStairs(n, costs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}