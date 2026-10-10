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

using LeetCode.Algorithms.BuyTwoChocolates;

namespace LeetCode.Tests.Algorithms.BuyTwoChocolates;

public abstract class BuyTwoChocolatesTestsBase<T> where T : IBuyTwoChocolates, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2 }, 3, 0)]
    [DataRow(new[] { 3, 2, 3 }, 3, 3)]
    [DataRow(new[] { 41, 1, 28, 2, 92, 97, 1, 87 }, 68, 66)]
    [DataRow(new[] { 98, 54, 6, 34, 66, 63, 52, 39 }, 62, 22)]
    [DataRow(new[] { 2, 12, 93, 52, 91, 86, 81, 1, 79, 64 }, 43, 40)]
    [DataRow(new[] { 1, 2 }, 3, 0)]
    [DataRow(new[] { 1, 2 }, 2, 2)]
    [DataRow(new[] { 5, 5 }, 10, 0)]
    [DataRow(new[] { 5, 5 }, 9, 9)]
    [DataRow(new[] { 100, 100 }, 100, 100)]
    [DataRow(new[] { 1, 1 }, 100, 98)]
    [DataRow(new[] { 1, 1, 1 }, 2, 0)]
    [DataRow(new[] { 10, 20, 30 }, 60, 30)]
    [DataRow(new[] { 10, 20, 30 }, 29, 29)]
    [DataRow(new[] { 50, 40, 30, 20, 10 }, 35, 5)]
    [DataRow(new[] { 3, 2, 1 }, 6, 3)]
    [DataRow(new[] { 2, 2, 2, 2 }, 4, 0)]
    [DataRow(new[] { 99, 1 }, 100, 0)]
    [DataRow(new[] { 4, 6, 8, 10 }, 11, 1)]
    [DataRow(new[] { 7, 3, 9, 5 }, 15, 7)]
    public void BuyChoco_WithPricesAndMoney_ReturnsRemainingMoneyAfterBuyingTwoCheapest(int[] prices, int money, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.BuyChoco(prices, money);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}