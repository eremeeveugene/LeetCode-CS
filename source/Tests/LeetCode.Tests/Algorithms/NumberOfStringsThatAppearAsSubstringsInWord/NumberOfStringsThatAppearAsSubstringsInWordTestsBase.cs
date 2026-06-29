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

using LeetCode.Algorithms.NumberOfStringsThatAppearAsSubstringsInWord;

namespace LeetCode.Tests.Algorithms.NumberOfStringsThatAppearAsSubstringsInWord;

public abstract class NumberOfStringsThatAppearAsSubstringsInWordTestsBase<T> where T : INumberOfStringsThatAppearAsSubstringsInWord, new()
{
    [TestMethod]
    [DataRow(new[] { "a", "abc", "bc", "d" }, "abc", 3)]
    [DataRow(new[] { "a", "b", "c" }, "aaaaabbbbb", 2)]
    [DataRow(new[] { "a", "a", "a" }, "ab", 3)]
    [DataRow(new[] { "abc", "def" }, "xyz", 0)]
    [DataRow(new[] { "abc" }, "abc", 1)]
    [DataRow(new[] { "abcd" }, "abc", 0)]
    [DataRow(new[] { "" }, "abc", 1)]
    [DataRow(new[] { "z" }, "z", 1)]
    [DataRow(new[] { "z" }, "y", 0)]
    [DataRow(new[] { "leet", "code", "leetcode" }, "leetcode", 3)]
    [DataRow(new[] { "leet", "code", "leetcodes" }, "leetcode", 2)]
    [DataRow(new[] { "ab", "ba", "aa", "bb" }, "abab", 2)]
    [DataRow(new[] { "x", "xx", "xxx" }, "xxxx", 3)]
    [DataRow(new[] { "x", "xx", "xxxxx" }, "xxxx", 2)]
    [DataRow(new[] { "hello", "world" }, "helloworld", 2)]
    [DataRow(new[] { "hello", "word" }, "helloworld", 1)]
    [DataRow(new[] { "aaa", "aa", "a" }, "aaaa", 3)]
    [DataRow(new[] { "cat", "dog", "bird" }, "thecatandthedog", 2)]
    [DataRow(new[] { "the", "and", "fox" }, "thecatandthedog", 2)]
    [DataRow(new[] { "abc", "bca", "cab" }, "abcabc", 3)]
    [DataRow(new[] { "qrs", "tuv", "wxy" }, "abcdefg", 0)]
    [DataRow(new[] { "g", "fg", "efg" }, "abcdefg", 3)]
    public void NumOfStrings_WithPatternsAndWord_ReturnsMatchingPatternCount(string[] patterns, string word, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumOfStrings(patterns, word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}