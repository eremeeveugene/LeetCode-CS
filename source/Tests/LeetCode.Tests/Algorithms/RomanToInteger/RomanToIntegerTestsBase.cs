// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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