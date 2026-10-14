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

using LeetCode.Algorithms.WordSubsets;

namespace LeetCode.Tests.Algorithms.WordSubsets;

public abstract class WordSubsetsTestsBase<T> where T : IWordSubsets, new()
{
    [TestMethod]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "e", "o" }, new[] { "facebook", "google", "leetcode" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "l", "e" }, new[] { "apple", "google", "leetcode" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "lc", "eo" }, new[] { "leetcode" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "ec", "oc", "ceo" }, new[] { "facebook", "leetcode" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "a" }, new[] { "amazon", "apple", "facebook" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "z" }, new[] { "amazon" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "ee" }, new[] { "leetcode" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "oo" }, new[] { "facebook", "google" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "e", "oo" }, new[] { "facebook", "google" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "l", "e", "e" }, new[] { "apple", "google", "leetcode" })]
    [DataRow(new[] { "a" }, new[] { "a" }, new[] { "a" })]
    [DataRow(new[] { "ab", "ba", "abc" }, new[] { "ab" }, new[] { "ab", "ba", "abc" })]
    [DataRow(new[] { "ab", "ba", "abc" }, new[] { "abc" }, new[] { "abc" })]
    [DataRow(new[] { "abc" }, new[] { "d" }, new string[] { })]
    [DataRow(new[] { "aabbcc", "abcabc", "aabbc" }, new[] { "aab", "bcc" }, new[] { "aabbcc", "abcabc" })]
    [DataRow(new[] { "zzzzzzzzzz", "zzzzzzzzza", "azzzzzzzzz" }, new[] { "zzzzzzzzzz" }, new[] { "zzzzzzzzzz" })]
    [DataRow(new[] { "abcdefghij", "jihgfedcba", "aaaaaaaaaa" }, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" }, new[] { "abcdefghij", "jihgfedcba" })]
    [DataRow(new[] { "warrior", "world" }, new[] { "wrr" }, new[] { "warrior" })]
    [DataRow(new[] { "warrior", "world" }, new[] { "or", "r" }, new[] { "warrior", "world" })]
    [DataRow(new[] { "abc", "bca", "cab", "xyz" }, new[] { "a", "b", "c" }, new[] { "abc", "bca", "cab" })]
    public void WordSubsets_WithWords1AndWords2_ReturnsMatchingSubset(string[] words1, string[] words2, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WordSubsets(words1, words2);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}