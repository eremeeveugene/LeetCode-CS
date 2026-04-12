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

using LeetCode.Algorithms.NumberOfSmoothDescentPeriodsOfStock;

namespace LeetCode.Tests.Algorithms.NumberOfSmoothDescentPeriodsOfStock;

public abstract class NumberOfSmoothDescentPeriodsOfStockTestsBase<T>
    where T : INumberOfSmoothDescentPeriodsOfStock, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 8, 6, 7, 7 }, 4)]
    [DataRow(new[] { 3, 2, 1, 4 }, 7)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 15)]
    [DataRow(new[] { 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 4, 3, 2, 1, 0 }, 15)]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5 }, 21)]
    [DataRow(new[] { 1, 1, 1 }, 3)]
    [DataRow(new[] { 5, 4, 5, 4, 3 }, 9)]
    [DataRow(new[] { 2, 1, 2, 1, 2, 1 }, 9)]
    [DataRow(new[] { 0, -1, -2, -3 }, 10)]
    [DataRow(new[] { 3, 2, 1, 0, 1, 0, -1 }, 16)]
    [DataRow(new[] { 100 }, 1)]
    [DataRow(new[] { 2, 1 }, 3)]
    [DataRow(new[] { 2, 2 }, 2)]
    public void GetDescentPeriods_WithGivenPrices_ReturnsCountOfSmoothDescentPeriods(int[] prices, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetDescentPeriods(prices);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}