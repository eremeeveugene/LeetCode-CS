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

using LeetCode.Algorithms.CountResiduePrefixes;

namespace LeetCode.Tests.Algorithms.CountResiduePrefixes;

public abstract class CountResiduePrefixesTestsBase<T> where T : ICountResiduePrefixes, new()
{
    [TestMethod]
    [DataRow("abc", 2)]
    [DataRow("dd", 1)]
    [DataRow("bob", 2)]
    [DataRow("a", 1)]
    [DataRow("aa", 1)]
    [DataRow("ab", 2)]
    [DataRow("abcd", 2)]
    [DataRow("aaa", 1)]
    [DataRow("aab", 1)]
    [DataRow("abab", 2)]
    [DataRow("abcabc", 2)]
    [DataRow("zzzzzz", 2)]
    [DataRow("abacaba", 2)]
    [DataRow("abcdefghij", 2)]
    [DataRow("aabbcc", 1)]
    [DataRow("xyzxyzxyz", 2)]
    [DataRow("qqwwee", 1)]
    [DataRow("mississippi", 2)]
    [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 34)]
    [DataRow("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", 2)]
    public void ResiduePrefixes_WithInputString_ReturnsResiduePrefixesCount(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ResiduePrefixes(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}