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

using LeetCode.Algorithms.ApplyDiscountToPrices;

namespace LeetCode.Tests.Algorithms.ApplyDiscountToPrices;

public abstract class ApplyDiscountToPricesTestsBase<T> where T : IApplyDiscountToPrices, new()
{
    [TestMethod]
    [DataRow("there are $1 $2 and 5$ candies in the shop", 50, "there are $0.50 $1.00 and 5$ candies in the shop")]
    [DataRow("1 2 $3 4 $5 $6 7 8$ $9 $10$", 100, "1 2 $0.00 4 $0.00 $0.00 7 8$ $0.00 $10$")]
    [DataRow("$1e9", 50, "$1e9")]
    public void DiscountPrices_WithSentenceAndDiscount_ReturnsFormattedPrices(string sentence, int discount,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DiscountPrices(sentence, discount);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}