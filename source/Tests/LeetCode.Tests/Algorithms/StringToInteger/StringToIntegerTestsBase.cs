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

using LeetCode.Algorithms.StringToInteger;

namespace LeetCode.Tests.Algorithms.StringToInteger;

public abstract class StringToIntegerTestsBase<T> where T : IStringToInteger, new()
{
    [TestMethod]
    [DataRow("42", 42)]
    [DataRow(" -042", -42)]
    [DataRow("1337c0d3", 1337)]
    [DataRow("0-1", 0)]
    [DataRow("words and 987", 0)]
    [DataRow("-91283472332", -2147483648)]
    [DataRow("9223372036854775808", 2147483647)]
    [DataRow(" ", 0)]
    [DataRow("+123", 123)]
    [DataRow("", 0)]
    [DataRow("-", 0)]
    [DataRow("+", 0)]
    [DataRow("   -", 0)]
    [DataRow("-0", 0)]
    [DataRow("0032", 32)]
    [DataRow("   42   ", 42)]
    [DataRow("+-12", 0)]
    [DataRow("-+12", 0)]
    [DataRow("3.14159", 3)]
    [DataRow("4193 with words", 4193)]
    [DataRow("21474836470", 2147483647)]
    [DataRow("2147483647", 2147483647)]
    [DataRow("2147483648", 2147483647)]
    [DataRow("-2147483648", -2147483648)]
    [DataRow("-2147483649", -2147483648)]
    [DataRow("00000-42a1234", 0)]
    [DataRow("  +0 123", 0)]
    [DataRow("- 5", 0)]
    [DataRow("   +00000000000000000000000000000000000000000000000000000000000000000001", 1)]
    [DataRow("9999999999999999999999999999", 2147483647)]
    [DataRow("-9999999999999999999999999999", -2147483648)]
    [DataRow(" . 1", 0)]
    [DataRow("1 2", 1)]
    public void MyAtoi_WithStringInput_ReturnsParsedIntegerOrZero(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MyAtoi(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}