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

using LeetCode.Algorithms.LongestSubstringWithoutRepeatingCharacters;

namespace LeetCode.Tests.Algorithms.LongestSubstringWithoutRepeatingCharacters;

public abstract class LongestSubstringWithoutRepeatingCharactersTestsBase<T> where T : ILongestSubstringWithoutRepeatingCharacters, new()
{
    [TestMethod]
    [DataRow("bbbbb", 1)]
    [DataRow("abcabcbb", 3)]
    [DataRow("dvdf", 3)]
    [DataRow("pwwkew", 3)]
    [DataRow("abcabcd", 4)]
    [DataRow("", 0)]
    [DataRow("a", 1)]
    [DataRow("ab", 2)]
    [DataRow("aa", 1)]
    [DataRow("abba", 2)]
    [DataRow("tmmzuxt", 5)]
    [DataRow("anviaj", 5)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 26)]
    [DataRow("abcdefghijklmnopqrstuvwxyza", 26)]
    [DataRow("zyxwvutsrqponmlkjihgfedcbaz", 26)]
    [DataRow(" ", 1)]
    [DataRow("a b a", 3)]
    [DataRow("1231234", 4)]
    [DataRow("!@#!@#$", 4)]
    [DataRow("aab", 2)]
    [DataRow("abac", 3)]
    [DataRow("cdd", 2)]
    [DataRow("ohvhjdml", 6)]
    [DataRow("au", 2)]
    [DataRow("qrsvbspk", 5)]
    public void LengthOfLongestSubstring_GivenString_ReturnsMaxUniqueSubstringLength(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LengthOfLongestSubstring(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}