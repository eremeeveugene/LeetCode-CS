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

using LeetCode.Algorithms.FractionToRecurringDecimal;

namespace LeetCode.Tests.Algorithms.FractionToRecurringDecimal;

public abstract class FractionToRecurringDecimalTestsBase<T> where T : IFractionToRecurringDecimal, new()
{
    [TestMethod]
    [DataRow(1, 2, "0.5")]
    [DataRow(2, 1, "2")]
    [DataRow(4, 333, "0.(012)")]
    [DataRow(0, 1, "0")]
    [DataRow(0, -1, "0")]
    [DataRow(-1, 2, "-0.5")]
    [DataRow(1, -2, "-0.5")]
    [DataRow(-1, -2, "0.5")]
    [DataRow(1, 3, "0.(3)")]
    [DataRow(1, 6, "0.1(6)")]
    [DataRow(1, 7, "0.(142857)")]
    [DataRow(22, 7, "3.(142857)")]
    [DataRow(-50, 8, "-6.25")]
    [DataRow(7, 2, "3.5")]
    [DataRow(100, 10, "10")]
    [DataRow(1, 1, "1")]
    [DataRow(-1, -1, "1")]
    [DataRow(5, 3, "1.(6)")]
    [DataRow(2147483647, 1, "2147483647")]
    [DataRow(-2147483648, 1, "-2147483648")]
    public void FractionToDecimal_WithNumeratorAndDenominator_ReturnsTheFractionInStringFormat(int numerator, int denominator, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FractionToDecimal(numerator, denominator);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}