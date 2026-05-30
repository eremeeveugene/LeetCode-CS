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