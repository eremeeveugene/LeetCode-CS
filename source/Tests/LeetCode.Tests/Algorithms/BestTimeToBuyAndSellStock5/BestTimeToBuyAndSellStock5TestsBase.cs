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

using LeetCode.Algorithms.BestTimeToBuyAndSellStock5;

namespace LeetCode.Tests.Algorithms.BestTimeToBuyAndSellStock5;

public abstract class BestTimeToBuyAndSellStock5TestsBase<T> where T : IBestTimeToBuyAndSellStock5, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 7, 9, 8, 2 }, 2, 14L)]
    [DataRow(new[] { 12, 16, 19, 19, 8, 1, 19, 13, 9 }, 3, 36L)]
    [DataRow(new[] { 1, 2 }, 1, 1L)]
    [DataRow(new[] { 2, 1 }, 1, 1L)]
    [DataRow(new[] { 5, 5 }, 1, 0L)]
    [DataRow(new[] { 1, 2, 3 }, 1, 2L)]
    [DataRow(new[] { 3, 2, 1 }, 1, 2L)]
    [DataRow(new[] { 1, 3, 2, 4 }, 1, 3L)]
    [DataRow(new[] { 1, 3, 2, 4 }, 2, 4L)]
    [DataRow(new[] { 1, 10, 1, 10 }, 2, 18L)]
    [DataRow(new[] { 10, 1, 10, 1 }, 2, 18L)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3, 5L)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, 3, 5L)]
    [DataRow(new[] { 1, 5, 1, 5, 1, 5 }, 3, 12L)]
    [DataRow(new[] { 5, 1, 5, 1, 5, 1 }, 2, 8L)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, 0L)]
    [DataRow(new[] { 2, 8, 3, 9 }, 1, 7L)]
    [DataRow(new[] { 9, 3, 8, 2 }, 1, 7L)]
    [DataRow(new[] { 4, 1, 7, 2, 9, 3 }, 2, 13L)]
    [DataRow(new[] { 100, 1, 100, 1 }, 1, 99L)]
    public void MaximumProfit_WithPricesAndTransactionLimit_ReturnsMaximumTotalProfitConsideringNormalAndShortSelling(
        int[] prices,
        int maxTransactions,
        long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumProfit(prices, maxTransactions);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}