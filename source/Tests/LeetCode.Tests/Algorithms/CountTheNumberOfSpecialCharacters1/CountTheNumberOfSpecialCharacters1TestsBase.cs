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

using LeetCode.Algorithms.CountTheNumberOfSpecialCharacters1;

namespace LeetCode.Tests.Algorithms.CountTheNumberOfSpecialCharacters1;

public abstract class CountTheNumberOfSpecialCharacters1TestsBase<T> where T : ICountTheNumberOfSpecialCharacters1, new()
{
    [TestMethod]
    [DataRow("a", 0)]
    [DataRow("A", 0)]
    [DataRow("aA", 1)]
    [DataRow("Aa", 1)]
    [DataRow("ab", 0)]
    [DataRow("AB", 0)]
    [DataRow("aAbB", 2)]
    [DataRow("abAB", 2)]
    [DataRow("aAbBcC", 3)]
    [DataRow("aaAA", 1)]
    [DataRow("aAbBcCdD", 4)]
    [DataRow("abc", 0)]
    [DataRow("ABC", 0)]
    [DataRow("aAbBcCdDeE", 5)]
    [DataRow("aaabbbABB", 2)]
    [DataRow("abcABC", 3)]
    [DataRow("AaBbCcDdEeFf", 6)]
    [DataRow("aAbBcCdDeEfFgG", 7)]
    [DataRow("abcdefgABCDEFG", 7)]
    [DataRow("aAbBcCdDeEfFgGhH", 8)]
    [DataRow("abcdefghABCDEFGH", 8)]
    public void NumberOfSpecialChars_WithWord_ReturnsCountOfSpecialCharacters(string word, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfSpecialChars(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}