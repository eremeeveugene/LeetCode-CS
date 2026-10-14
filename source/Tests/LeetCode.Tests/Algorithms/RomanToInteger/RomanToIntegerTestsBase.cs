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

using LeetCode.Algorithms.RomanToInteger;

namespace LeetCode.Tests.Algorithms.RomanToInteger;

public abstract class RomanToIntegerTestsBase<T> where T : IRomanToInteger, new()
{
    [TestMethod]
    [DataRow("III", 3)]
    [DataRow("LVIII", 58)]
    [DataRow("MCMXCIV", 1994)]
    [DataRow("I", 1)]
    [DataRow("II", 2)]
    [DataRow("IV", 4)]
    [DataRow("V", 5)]
    [DataRow("VI", 6)]
    [DataRow("IX", 9)]
    [DataRow("X", 10)]
    [DataRow("XIV", 14)]
    [DataRow("XIX", 19)]
    [DataRow("XL", 40)]
    [DataRow("XLIX", 49)]
    [DataRow("XC", 90)]
    [DataRow("CD", 400)]
    [DataRow("CDXLIV", 444)]
    [DataRow("CM", 900)]
    [DataRow("M", 1000)]
    [DataRow("MMXXIV", 2024)]
    [DataRow("MMMDCCCLXXXVIII", 3888)]
    [DataRow("MMMCMXCIX", 3999)]
    public void RomanToInt_WithRomanString_ConvertsToInteger(string romanString, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RomanToInt(romanString);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}