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

using LeetCode.Algorithms.StringMatchingInAnArray;

namespace LeetCode.Tests.Algorithms.StringMatchingInAnArray;

public abstract class StringMatchingInAnArrayTestsBase<T> where T : IStringMatchingInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { "mass", "as", "hero", "superhero" }, new[] { "as", "hero" })]
    [DataRow(new[] { "leetcode", "et", "code" }, new[] { "et", "code" })]
    [DataRow(new[] { "blue", "green", "bu" }, new string[0])]
    [DataRow(new[] { "a" }, new string[] { })]
    [DataRow(new[] { "a", "b" }, new string[] { })]
    [DataRow(new[] { "a", "ab" }, new[] { "a" })]
    [DataRow(new[] { "ab", "a" }, new[] { "a" })]
    [DataRow(new[] { "abc", "bc", "c", "ab", "b" }, new[] { "bc", "c", "ab", "b" })]
    [DataRow(new[] { "leet", "code", "leetcode" }, new[] { "leet", "code" })]
    [DataRow(new[] { "xyz", "abc", "def" }, new string[] { })]
    [DataRow(new[] { "aaa", "aa", "a" }, new[] { "aa", "a" })]
    [DataRow(new[] { "hello", "ell", "hell", "lo", "world" }, new[] { "ell", "hell", "lo" })]
    [DataRow(new[] { "ab", "ba", "aba", "bab" }, new[] { "ab", "ba" })]
    [DataRow(new[] { "abcdefghij", "cde", "ghij", "efg", "zzz" }, new[] { "cde", "ghij", "efg" })]
    [DataRow(new[] { "ba", "b", "a", "ab" }, new[] { "b", "a" })]
    [DataRow(new[] { "superhero", "hero", "super", "her", "perh" }, new[] { "hero", "super", "her", "perh" })]
    [DataRow(new[] { "cat", "dog", "dogcat", "catdog", "og" }, new[] { "cat", "dog", "og" })]
    [DataRow(new[] { "abc", "abcd", "abcde" }, new[] { "abc", "abcd" })]
    [DataRow(new[] { "x", "y", "z", "xyz" }, new[] { "x", "y", "z" })]
    [DataRow(new[] { "mop", "pom", "mopom", "o" }, new[] { "mop", "pom", "o" })]
    public void StringMatching_WithArrayOfWords_ReturnsMatchingSubstrings(string[] words, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StringMatching(words);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}