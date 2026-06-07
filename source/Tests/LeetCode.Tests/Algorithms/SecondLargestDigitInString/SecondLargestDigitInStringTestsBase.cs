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

using LeetCode.Algorithms.SecondLargestDigitInString;

namespace LeetCode.Tests.Algorithms.SecondLargestDigitInString;

public abstract class SecondLargestDigitInStringTestsBase<T> where T : ISecondLargestDigitInString, new()
{
    [TestMethod]
    [DataRow("dfa12321afd", 2)]
    [DataRow("abc1111", -1)]
    [DataRow("ck077", 0)]
    [DataRow("abc", -1)]
    [DataRow("9", -1)]
    [DataRow("98", 8)]
    [DataRow("0123456789", 8)]
    [DataRow("a1b2c3", 2)]
    [DataRow("99", -1)]
    [DataRow("90", 0)]
    [DataRow("z5z5z5", -1)]
    [DataRow("z5z4z", 4)]
    [DataRow("aaa0", -1)]
    [DataRow("aaa01", 0)]
    [DataRow("1234567890", 8)]
    [DataRow("9999999998", 8)]
    [DataRow("abcde9f8g", 8)]
    [DataRow("11223344", 3)]
    [DataRow("5050505", 0)]
    [DataRow("xyz55z6", 5)]
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