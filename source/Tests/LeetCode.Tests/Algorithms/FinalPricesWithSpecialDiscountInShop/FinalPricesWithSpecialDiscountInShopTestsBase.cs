// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FinalPricesWithSpecialDiscountInShop;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FinalPricesWithSpecialDiscountInShop;

public abstract class FinalPricesWithSpecialDiscountInShopTestsBase<T>
    where T : IFinalPricesWithSpecialDiscountInShop, new()
{
    [TestMethod]
    [DataRow("[8,4,6,2,3]", "[4,2,4,2,3]")]
    [DataRow("[1,2,3,4,5]", "[1,2,3,4,5]")]
    [DataRow("[10,1,1,6]", "[9,0,1,6]")]
    public void FinalPrices_WithPriceArray_ReturnsDiscountedPrices(string pricesJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var prices = JsonHelper<int>.DeserializeToArray(pricesJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FinalPrices(prices);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}