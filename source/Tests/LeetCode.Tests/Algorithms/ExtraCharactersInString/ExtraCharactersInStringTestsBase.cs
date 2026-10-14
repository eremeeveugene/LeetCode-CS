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

using LeetCode.Algorithms.ExtraCharactersInString;

namespace LeetCode.Tests.Algorithms.ExtraCharactersInString;

public abstract class ExtraCharactersInStringTestsBase<T> where T : IExtraCharactersInString, new()
{
    [TestMethod]
    [DataRow("leetsleetscode", new[] { "leets", "code" }, 0)]
    [DataRow("leetscode", new[] { "leet", "code", "leetcode" }, 1)]
    [DataRow("leecodet", new[] { "leet", "code" }, 4)]
    [DataRow("sayhelloworld", new[] { "hello", "world" }, 3)]
    [DataRow("dwmodizxvvbosxxw", new[] { "ox", "lb", "diz", "gu", "v", "ksv", "o", "nuq", "r", "txhe", "e", "wmo", "cehy", "tskz", "ds", "kzbu" }, 7)]
    [DataRow("a", new[] { "a" }, 0)]
    [DataRow("a", new[] { "b" }, 1)]
    [DataRow("ab", new[] { "a", "b" }, 0)]
    [DataRow("ab", new[] { "ab" }, 0)]
    [DataRow("abc", new[] { "abcd" }, 3)]
    [DataRow("aaaa", new[] { "a" }, 0)]
    [DataRow("aaaa", new[] { "aa" }, 0)]
    [DataRow("aaaaa", new[] { "aa" }, 1)]
    [DataRow("aaaaa", new[] { "aa", "aaa" }, 0)]
    [DataRow("abcdef", new[] { "abc", "def" }, 0)]
    [DataRow("abcdef", new[] { "bcd" }, 3)]
    [DataRow("abcdef", new[] { "ab", "cd", "ef", "abcdef" }, 0)]
    [DataRow("xyz", new[] { "q", "r" }, 3)]
    [DataRow("leetcode", new[] { "leet", "code", "lee", "tcode" }, 0)]
    [DataRow(
        "azvzulhlwxwobowijiyebeaskecvtjqwkmaqnvnaomaqnvf",
        new[]
        {
            "na",
            "i",
            "edd",
            "wobow",
            "kecv",
            "b",
            "n",
            "or",
            "jj",
            "zul",
            "vk",
            "yeb",
            "qnfac",
            "azv",
            "grtjba",
            "yswmjn",
            "xowio",
            "u",
            "xi",
            "pcmatm",
            "maqnv"
        },
        15)]
    public void MinExtraChar_WithStringAndDictionary_ReturnsMinExtraChars(string s, string[] dictionary, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinExtraChar(s, dictionary);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}