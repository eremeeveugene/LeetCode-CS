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

using LeetCode.Algorithms.MinimumSumOfFourDigitNumberAfterSplittingDigits;

namespace LeetCode.Tests.Algorithms.MinimumSumOfFourDigitNumberAfterSplittingDigits;

public abstract class MinimumSumOfFourDigitNumberAfterSplittingDigitsTestsBase<T> where T : IMinimumSumOfFourDigitNumberAfterSplittingDigits, new()
{
    [TestMethod]
    [DataRow(2932, 52)]
    [DataRow(4009, 13)]
    [DataRow(1000, 1)]
    [DataRow(9999, 198)]
    [DataRow(1111, 22)]
    [DataRow(1234, 37)]
    [DataRow(4321, 37)]
    [DataRow(9000, 9)]
    [DataRow(1010, 2)]
    [DataRow(5050, 10)]
    [DataRow(9876, 147)]
    [DataRow(6789, 147)]
    [DataRow(1001, 2)]
    [DataRow(3333, 66)]
    [DataRow(8765, 125)]
    [DataRow(2020, 4)]
    [DataRow(7007, 14)]
    [DataRow(1990, 28)]
    [DataRow(5000, 5)]
    [DataRow(9091, 28)]
    public void MinimumSum_WithFourDigitNumber_ReturnsMinimumPossibleSumOfTwoSplitIntegers(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumSum(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}