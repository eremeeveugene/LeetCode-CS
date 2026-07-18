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

using LeetCode.Algorithms.WordPattern;

namespace LeetCode.Tests.Algorithms.WordPattern;

public abstract class WordPatternTestsBase<T> where T : IWordPattern, new()
{
    [TestMethod]
    [DataRow("aaa", "aa aa aa aa", false)]
    [DataRow("abba", "dog cat cat dog", true)]
    [DataRow("abba", "dog cat cat fish", false)]
    [DataRow("aaaa", "dog cat cat dog", false)]
    [DataRow("abba", "dog dog dog dog", false)]
    [DataRow("a", "dog", true)]
    [DataRow("a", "dog cat", false)]
    [DataRow("ab", "dog cat", true)]
    [DataRow("ab", "dog dog", false)]
    [DataRow("aa", "dog dog", true)]
    [DataRow("aa", "dog cat", false)]
    [DataRow("abc", "dog cat fish", true)]
    [DataRow("abc", "dog cat dog", false)]
    [DataRow("aab", "dog dog cat", true)]
    [DataRow("aba", "cat dog cat", true)]
    [DataRow("aba", "cat dog dog", false)]
    [DataRow("abcd", "dog cat fish bird", true)]
    [DataRow("abcd", "dog cat fish dog", false)]
    [DataRow("ab", "cat cat", false)]
    [DataRow("ba", "cat dog", true)]
    [DataRow("aaaa", "a a a a", true)]
    [DataRow("abcabc", "x y z x y z", true)]
    public void WordPattern_GivenPatternAndString_MatchesExpectedResult(string pattern, string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WordPattern(pattern, s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}