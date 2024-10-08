﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.BuyTwoChocolates;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BuyTwoChocolates;

public abstract class BuyTwoChocolatesTestsBase<T> where T : IBuyTwoChocolates, new()
{
    [TestMethod]
    [DataRow("[1, 2, 2]", 3, 0)]
    [DataRow("[3, 2, 3]", 3, 3)]
    [DataRow("[41, 1, 28, 2, 92, 97, 1, 87]", 68, 66)]
    [DataRow("[98, 54, 6, 34, 66, 63, 52, 39]", 62, 22)]
    [DataRow("[2, 12, 93, 52, 91, 86, 81, 1, 79, 64]", 43, 40)]
    public void BuyChoco_WithPricesAndMoney_ReturnsExpectedResult(string pricesJsonArray, int money, int expectedResult)
    {
        // Arrange
        var prices = JsonHelper<int>.DeserializeToArray(pricesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.BuyChoco(prices, money);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}