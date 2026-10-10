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

using LeetCode.Algorithms.BestTimeToBuyAndSellStock;

namespace LeetCode.Tests.Algorithms.BestTimeToBuyAndSellStock;

public abstract class BestTimeToBuyAndSellStockTestsBase<T> where T : IBestTimeToBuyAndSellStock, new()
{
    [TestMethod]
    [DataRow(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [DataRow(new[] { 7, 6, 4, 3, 1 }, 0)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 0)]
    [DataRow(new[] { 3, 3, 3 }, 0)]
    [DataRow(new[] { 2, 4, 1 }, 2)]
    [DataRow(new[] { 3, 2, 6, 5, 0, 3 }, 4)]
    [DataRow(new[] { 2, 1, 2, 1, 0, 1, 2 }, 2)]
    [DataRow(new[] { 1, 10000 }, 9999)]
    [DataRow(new[] { 10000, 1 }, 0)]
    [DataRow(new[] { 0, 0 }, 0)]
    [DataRow(new[] { 1, 4, 2, 7 }, 6)]
    [DataRow(new[] { 2, 1, 4 }, 3)]
    [DataRow(new[] { 5, 2, 8, 1, 9 }, 8)]
    [DataRow(new[] { 4, 4, 4, 5 }, 1)]
    [DataRow(new[] { 6, 1, 3, 2, 4, 7 }, 6)]
    [DataRow(new[] { 100, 180, 260, 310, 40, 535, 695 }, 655)]
    [DataRow(new[] { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0 }, 8)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 8)]
    public void MaxProfit_GivenPriceArray_ReturnsMaximumProfit(int[] prices, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxProfit(prices);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}