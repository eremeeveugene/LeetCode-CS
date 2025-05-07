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

using LeetCode.Algorithms.MaximumProductOfTwoDigits;

namespace LeetCode.Tests.Algorithms.MaximumProductOfTwoDigits;

public abstract class MaximumProductOfTwoDigitsTestsBase<T> where T : IMaximumProductOfTwoDigits, new()
{
    [TestMethod]
    [DataRow(31, 3)]
    [DataRow(22, 4)]
    [DataRow(124, 8)]
    public void MaxProduct_WithGivenInteger_ReturnsMaximumDigitProduct(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxProduct(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}