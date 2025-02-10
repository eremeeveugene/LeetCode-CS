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

using LeetCode.Algorithms.SecondLargestDigitInString;

namespace LeetCode.Tests.Algorithms.SecondLargestDigitInString;

public abstract class SecondLargestDigitInStringTestsBase<T> where T : ISecondLargestDigitInString, new()
{
    [TestMethod]
    [DataRow("dfa12321afd", 2)]
    [DataRow("abc1111", -1)]
    [DataRow("ck077", 0)]
    public void SecondHighest_WithStringContainingDigits_ReturnsSecondLargestDigit(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SecondHighest(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}