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

using LeetCode.Algorithms.MaximumIceCreamBars;

namespace LeetCode.Tests.Algorithms.MaximumIceCreamBars;

public abstract class MaximumIceCreamBarsTestsBase<T> where T : IMaximumIceCreamBars, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 2, 4, 1 }, 7, 4)]
    [DataRow(new[] { 10, 6, 8, 7, 7, 8 }, 5, 0)]
    [DataRow(new[] { 1, 6, 3, 1, 2, 5 }, 20, 6)]
    [DataRow(new[] { 5 }, 5, 1)]
    [DataRow(new[] { 5 }, 4, 0)]
    [DataRow(new[] { 1 }, 100000000, 1)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 3, 3)]
    [DataRow(new[] { 2, 2, 2, 2 }, 7, 3)]
    [DataRow(new[] { 100, 200, 300 }, 50, 0)]
    [DataRow(new[] { 100, 200, 300 }, 600, 3)]
    [DataRow(new[] { 100, 200, 300 }, 599, 2)]
    [DataRow(new[] { 7, 3, 5, 1, 9 }, 16, 4)]
    [DataRow(new[] { 7, 3, 5, 1, 9 }, 1, 1)]
    [DataRow(new[] { 4, 4, 4, 4 }, 16, 4)]
    [DataRow(new[] { 4, 4, 4, 4 }, 15, 3)]
    [DataRow(new[] { 10, 1, 1, 1, 1 }, 4, 4)]
    [DataRow(new[] { 10, 1, 1, 1, 1 }, 14, 5)]
    [DataRow(new[] { 3, 1, 2 }, 0, 0)]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, 5, 1)]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, 35, 5)]
    [DataRow(new[] { 100000, 100000 }, 100000, 1)]
    [DataRow(new[] { 6, 1, 3, 1, 1 }, 3, 3)]
    public void MaxIceCream_WithCostsAndCoins_ReturnsMaximumAffordableBars(int[] costs, int coins, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxIceCream(costs, coins);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}