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

using LeetCode.Algorithms.ConcatenateNonZeroDigitsAndMultiplyBySum1;

namespace LeetCode.Tests.Algorithms.ConcatenateNonZeroDigitsAndMultiplyBySum1;

public abstract class ConcatenateNonZeroDigitsAndMultiplyBySum1TestsBase<T> where T : IConcatenateNonZeroDigitsAndMultiplyBySum1, new()
{
    [TestMethod]
    [DataRow(1000, 1)]
    [DataRow(10203004, 12340)]
    public void SumAndMultiply_WithGivenInteger_ReturnsProductOfNonZeroDigitConcatenationAndDigitSum(int n, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumAndMultiply(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}