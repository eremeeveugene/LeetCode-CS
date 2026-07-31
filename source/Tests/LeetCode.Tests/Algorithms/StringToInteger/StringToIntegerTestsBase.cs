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