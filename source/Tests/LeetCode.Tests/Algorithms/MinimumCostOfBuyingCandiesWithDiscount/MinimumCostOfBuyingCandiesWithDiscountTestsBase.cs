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

using LeetCode.Algorithms.MinimumCostOfBuyingCandiesWithDiscount;

namespace LeetCode.Tests.Algorithms.MinimumCostOfBuyingCandiesWithDiscount;

public abstract class MinimumCostOfBuyingCandiesWithDiscountTestsBase<T> where T : IMinimumCostOfBuyingCandiesWithDiscount, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 5 }, 5)]
    [DataRow(new[] { 100 }, 100)]
    [DataRow(new[] { 1, 1 }, 2)]
    [DataRow(new[] { 1, 2 }, 3)]
    [DataRow(new[] { 5, 5 }, 10)]
    [DataRow(new[] { 100, 100 }, 200)]
    [DataRow(new[] { 1, 1, 1 }, 2)]
    [DataRow(new[] { 1, 2, 3 }, 5)]
    [DataRow(new[] { 5, 5, 5 }, 10)]
    [DataRow(new[] { 100, 100, 100 }, 200)]
    [DataRow(new[] { 1, 2, 3, 4 }, 8)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 12)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 16)]
    [DataRow(new[] { 6, 5, 7, 9, 2, 2 }, 23)]
    [DataRow(new[] { 100, 1, 100, 1, 100, 1 }, 202)]
    [DataRow(new[] { 10, 10, 10, 10, 10, 10 }, 40)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 21)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 33)]
    [DataRow(new[] { 2, 2, 2, 3, 3, 3, 1, 1, 1 }, 12)]
    [DataRow(new[] { 100, 100, 100, 100, 100, 100, 100, 100, 100 }, 600)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 40)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 56)]
    public void MinimumCost_WithCandyCosts_ReturnsMinimumTotalCostAfterDiscount(int[] costs, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumCost(costs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}