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

using LeetCode.Algorithms.ApplyDiscountToPrices;

namespace LeetCode.Tests.Algorithms.ApplyDiscountToPrices;

public abstract class ApplyDiscountToPricesTestsBase<T> where T : IApplyDiscountToPrices, new()
{
    [TestMethod]
    [DataRow("there are $1 $2 and 5$ candies in the shop", 50, "there are $0.50 $1.00 and 5$ candies in the shop")]
    [DataRow("1 2 $3 4 $5 $6 7 8$ $9 $10$", 100, "1 2 $0.00 4 $0.00 $0.00 7 8$ $0.00 $10$")]
    [DataRow("$1e9", 50, "$1e9")]
    [DataRow("$100", 10, "$90.00")]
    [DataRow("$1", 0, "$1.00")]
    [DataRow("$99", 100, "$0.00")]
    [DataRow("$3 $4", 50, "$1.50 $2.00")]
    [DataRow("no prices here", 20, "no prices here")]
    [DataRow("$", 50, "$")]
    [DataRow("$a", 50, "$a")]
    [DataRow("$12abc", 50, "$12abc")]
    [DataRow("$$5", 50, "$$5")]
    [DataRow("5$", 50, "5$")]
    [DataRow("$10 $20 $30", 10, "$9.00 $18.00 $27.00")]
    [DataRow("$7", 50, "$3.50")]
    [DataRow("$1000000", 25, "$750000.00")]
    [DataRow("$10000000000", 50, "$5000000000.00")]
    [DataRow("$5 and $15", 20, "$4.00 and $12.00")]
    [DataRow("$333", 33, "$223.11")]
    [DataRow("$1", 1, "$0.99")]
    [DataRow("$2 $", 50, "$1.00 $")]
    [DataRow("$0", 50, "$0.00")]
    [DataRow("$250", 40, "$150.00")]
    [DataRow("a $4 b", 25, "a $3.00 b")]
    public void DiscountPrices_WithSentenceAndDiscount_ReturnsFormattedPrices(string sentence, int discount, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DiscountPrices(sentence, discount);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}