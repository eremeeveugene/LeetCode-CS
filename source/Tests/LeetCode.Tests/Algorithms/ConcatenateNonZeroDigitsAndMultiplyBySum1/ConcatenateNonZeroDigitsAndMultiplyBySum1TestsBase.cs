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
    [DataRow(1, 1)]
    [DataRow(5, 25)]
    [DataRow(10, 1)]
    [DataRow(12, 36)]
    [DataRow(21, 63)]
    [DataRow(100, 1)]
    [DataRow(101, 22)]
    [DataRow(909, 1782)]
    [DataRow(4321, 43210)]
    [DataRow(999, 26973)]
    [DataRow(111, 333)]
    [DataRow(2020, 88)]
    [DataRow(305, 280)]
    [DataRow(9, 81)]
    [DataRow(99, 1782)]
    [DataRow(90, 81)]
    [DataRow(123456789, 5555555505)]
    [DataRow(987654321, 44444444445)]
    [DataRow(1000000000, 1)]
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