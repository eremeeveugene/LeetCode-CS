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

using LeetCode.Algorithms.ShortestPalindrome;

namespace LeetCode.Tests.Algorithms.ShortestPalindrome;

public abstract class ShortestPalindromeTestsBase<T> where T : IShortestPalindrome, new()
{
    [TestMethod]
    [DataRow("", "")]
    [DataRow("a", "a")]
    [DataRow("abb", "bbabb")]
    [DataRow("aacecaaa", "aaacecaaa")]
    [DataRow("abcd", "dcbabcd")]
    [DataRow("aabba", "abbaabba")]
    [DataRow("aacecaa", "aacecaa")]
    [DataRow("aaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaa")]
    [DataRow("b", "b")]
    [DataRow("ab", "bab")]
    [DataRow("ba", "aba")]
    [DataRow("aa", "aa")]
    [DataRow("aba", "aba")]
    [DataRow("abc", "cbabc")]
    [DataRow("abca", "acbabca")]
    [DataRow("aabc", "cbaabc")]
    [DataRow("abab", "babab")]
    [DataRow("babab", "babab")]
    [DataRow("zzzy", "yzzzy")]
    [DataRow("xyzzy", "yzzyxyzzy")]
    [DataRow("abcba", "abcba")]
    [DataRow("abbacd", "dcabbacd")]
    [DataRow("aaabaaa", "aaabaaa")]
    [DataRow("abcdefg", "gfedcbabcdefg")]
    public void ShortestPalindrome_WithInputString_ReturnsShortestPalindromeForm(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ShortestPalindrome(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}