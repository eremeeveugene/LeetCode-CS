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

using LeetCode.Algorithms.StrangePrinter;

namespace LeetCode.Tests.Algorithms.StrangePrinter;

public abstract class StrangePrinterTestsBase<T> where T : IStrangePrinter, new()
{
    [TestMethod]
    [DataRow("aaabbb", 2)]
    [DataRow("aba", 2)]
    [DataRow("a", 1)]
    [DataRow("aa", 1)]
    [DataRow("ab", 2)]
    [DataRow("aab", 2)]
    [DataRow("abc", 3)]
    [DataRow("abab", 3)]
    [DataRow("abba", 2)]
    [DataRow("aaaa", 1)]
    [DataRow("abcd", 4)]
    [DataRow("abcba", 3)]
    [DataRow("aabb", 2)]
    [DataRow("abbc", 3)]
    [DataRow("abcabc", 5)]
    [DataRow("aaabbbccc", 3)]
    [DataRow("abacaba", 4)]
    [DataRow("zz", 1)]
    [DataRow("aabbcc", 3)]
    [DataRow("abcbca", 4)]
    public void StrangePrinter_GivenString_ReturnsMinimumPrints(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StrangePrinter(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}