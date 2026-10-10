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

using LeetCode.Algorithms.FinalPricesWithSpecialDiscountInShop;

namespace LeetCode.Tests.Algorithms.FinalPricesWithSpecialDiscountInShop;

public abstract class FinalPricesWithSpecialDiscountInShopTestsBase<T> where T : IFinalPricesWithSpecialDiscountInShop, new()
{
    [TestMethod]
    [DataRow(new[] { 8, 4, 6, 2, 3 }, new[] { 4, 2, 4, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 10, 1, 1, 6 }, new[] { 9, 0, 1, 6 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 5, 5 }, new[] { 0, 5 })]
    [DataRow(new[] { 5, 4 }, new[] { 1, 4 })]
    [DataRow(new[] { 4, 5 }, new[] { 4, 5 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 10, 10, 10 }, new[] { 0, 0, 10 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 8, 7, 6, 5, 4 }, new[] { 1, 1, 1, 1, 4 })]
    [DataRow(new[] { 2, 5, 2, 5, 2 }, new[] { 0, 3, 0, 3, 2 })]
    [DataRow(new[] { 1000, 1, 1000, 1 }, new[] { 999, 0, 999, 1 })]
    [DataRow(new[] { 6, 4, 8, 3, 5, 1 }, new[] { 2, 1, 5, 2, 4, 1 })]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, new[] { 0, 0, 0, 0, 5 })]
    [DataRow(new[] { 1, 1000 }, new[] { 1, 1000 })]
    [DataRow(new[] { 1000, 1 }, new[] { 999, 1 })]
    [DataRow(new[] { 9, 2, 9, 2, 9, 2 }, new[] { 7, 0, 7, 0, 7, 2 })]
    [DataRow(new[] { 7, 8, 3, 4, 3, 6 }, new[] { 4, 5, 0, 1, 3, 6 })]
    public void FinalPrices_WithPriceArray_ReturnsDiscountedPrices(int[] prices, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FinalPrices(prices);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}