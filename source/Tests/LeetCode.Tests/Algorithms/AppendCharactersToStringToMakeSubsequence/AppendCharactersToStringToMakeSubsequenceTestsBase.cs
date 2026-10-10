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

using LeetCode.Algorithms.AppendCharactersToStringToMakeSubsequence;

namespace LeetCode.Tests.Algorithms.AppendCharactersToStringToMakeSubsequence;

public abstract class AppendCharactersToStringToMakeSubsequenceTestsBase<T> where T : IAppendCharactersToStringToMakeSubsequence, new()
{
    [TestMethod]
    [DataRow("a", "a", 0)]
    [DataRow("a", "z", 1)]
    [DataRow("z", "abcde", 5)]
    [DataRow("abz", "abc", 1)]
    [DataRow("abcde", "a", 0)]
    [DataRow("abcde", "abc", 0)]
    [DataRow("abcde", "bdf", 1)]
    [DataRow("abcdef", "abcdef", 0)]
    [DataRow("axbyczd", "abcd", 0)]
    [DataRow("vrykt", "rkge", 2)]
    [DataRow("coaching", "coding", 4)]
    [DataRow("abc", "abc", 0)]
    [DataRow("abc", "abcd", 1)]
    [DataRow("abc", "d", 1)]
    [DataRow("abc", "cba", 2)]
    [DataRow("a", "aa", 1)]
    [DataRow("aaa", "aa", 0)]
    [DataRow("zzz", "zzzz", 1)]
    [DataRow("hello", "world", 5)]
    [DataRow("hello", "hell", 0)]
    [DataRow("hello", "helo", 0)]
    [DataRow("hello", "hollow", 4)]
    [DataRow("abcdefg", "aceg", 0)]
    [DataRow("abcdefg", "gfe", 2)]
    [DataRow("xyz", "xyzabc", 3)]
    [DataRow("leetcode", "code", 0)]
    [DataRow("leetcode", "coda", 1)]
    [DataRow("aabbcc", "abc", 0)]
    [DataRow("aabbcc", "cba", 2)]
    public void AppendCharacters_WithSourceAndTargetStrings_ReturnsMinCharsToAppendForSubsequence(string s, string t, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AppendCharacters(s, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}