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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BestTimeToBuyAndSellStock5;

public abstract class BestTimeToBuyAndSellStock5TestsBase<T> where T : IBestTimeToBuyAndSellStock5, new()
{
    [TestMethod]
    [DataRow("[1,7,9,8,2]", 2, 14)]
    [DataRow("[12,16,19,19,8,1,19,13,9]", 3, 36)]
    public void MaximumProfit_WithPricesAndTransactionLimit_ReturnsMaximumTotalProfitConsideringNormalAndShortSelling(
        string pricesJson, int maxTransactions, long expectedResult)
    {
        // Arrange
        var prices = JsonHelper.Parse<int[]>(pricesJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumProfit(prices, maxTransactions);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}