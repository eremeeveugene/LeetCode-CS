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

using LeetCode.Algorithms.BestTimeToBuyAndSellStock;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BestTimeToBuyAndSellStock;

public abstract class BestTimeToBuyAndSellStockTestsBase<T> where T : IBestTimeToBuyAndSellStock, new()
{
    [TestMethod]
    [DataRow("[7, 1, 5, 3, 6, 4]", 5)]
    [DataRow("[7, 6, 4, 3, 1]", 0)]
    public void MaxProfit_GivenPriceArray_ReturnsMaximumProfit(string pricesJsonArray, int expectedResult)
    {
        // Arrange
        var prices = JsonHelper<int>.DeserializeToArray(pricesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxProfit(prices);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}