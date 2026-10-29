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

using LeetCode.Core.Models;

namespace LeetCode.Core.Tests.Models;

[TestClass]
public sealed class TrieTests
{
    [TestMethod]
    public void TrieDefaultConstructor_WithInsertedWord_SearchReturnsTrue()
    {
        // Arrange
        var trie = new Trie();

        // Act
        trie.Insert("apple");

        var actualResult = trie.Search("apple");

        // Assert
        Assert.IsTrue(actualResult);
    }

    [TestMethod]
    public void TrieDefaultConstructor_WithoutInsertedWords_StartsWithReturnsFalse()
    {
        // Arrange
        var trie = new Trie();

        // Act
        var actualResult = trie.StartsWith("a");

        // Assert
        Assert.IsFalse(actualResult);
    }

    [TestMethod]
    [DataRow(new[] { "apple" }, "apple", true)]
    [DataRow(new[] { "apple" }, "app", false)]
    [DataRow(new[] { "apple", "app" }, "app", true)]
    [DataRow(new[] { "apple" }, "apples", false)]
    [DataRow(new string[] { }, "a", false)]
    [DataRow(new string[] { }, "", false)]
    [DataRow(new[] { "" }, "", true)]
    [DataRow(new[] { "a" }, "a", true)]
    [DataRow(new[] { "a" }, "b", false)]
    [DataRow(new[] { "abc", "abd" }, "abd", true)]
    [DataRow(new[] { "abc", "abd" }, "ab", false)]
    [DataRow(new[] { "cat", "car", "cart" }, "car", true)]
    [DataRow(new[] { "cat", "car", "cart" }, "cart", true)]
    [DataRow(new[] { "cat", "car", "cart" }, "ca", false)]
    [DataRow(new[] { "hello", "hell", "he" }, "hel", false)]
    [DataRow(new[] { "hello", "hell", "he" }, "he", true)]
    [DataRow(new[] { "dog" }, "Dog", false)]
    [DataRow(new[] { "ab", "ab" }, "ab", true)]
    [DataRow(new[] { "xyz" }, "xy", false)]
    [DataRow(new[] { "leet", "code" }, "code", true)]
    [DataRow(new[] { "leet", "code" }, "leetcode", false)]
    public void Search_WithWordsAndWord_ReturnsWhetherWordWasInserted(string[] words, string word, bool expectedResult)
    {
        // Arrange
        var trie = new Trie(words);

        // Act
        var actualResult = trie.Search(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow(new[] { "apple" }, "app", true)]
    [DataRow(new[] { "apple" }, "apple", true)]
    [DataRow(new[] { "apple" }, "apples", false)]
    [DataRow(new[] { "apple" }, "", true)]
    [DataRow(new string[] { }, "a", false)]
    [DataRow(new[] { "a" }, "a", true)]
    [DataRow(new[] { "a" }, "b", false)]
    [DataRow(new[] { "abc", "abd" }, "ab", true)]
    [DataRow(new[] { "abc", "abd" }, "abe", false)]
    [DataRow(new[] { "cat", "car" }, "c", true)]
    [DataRow(new[] { "cat", "car" }, "ca", true)]
    [DataRow(new[] { "cat", "car" }, "cb", false)]
    [DataRow(new[] { "hello" }, "hell", true)]
    [DataRow(new[] { "hello" }, "help", false)]
    [DataRow(new[] { "dog" }, "Do", false)]
    [DataRow(new[] { "leet", "code" }, "co", true)]
    [DataRow(new[] { "leet", "code" }, "leetc", false)]
    [DataRow(new[] { "xyz" }, "xyz", true)]
    [DataRow(new[] { "xyz" }, "yz", false)]
    [DataRow(new[] { "ab", "abcd" }, "abc", true)]
    public void StartsWith_WithWordsAndPrefix_ReturnsWhetherAnyWordStartsWithPrefix(string[] words, string prefix, bool expectedResult)
    {
        // Arrange
        var trie = new Trie(words);

        // Act
        var actualResult = trie.StartsWith(prefix);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    [DataRow(new[] { "cat", "bat", "rat" }, "cattle", true, 3)]
    [DataRow(new[] { "cat", "bat", "rat" }, "battery", true, 3)]
    [DataRow(new[] { "cat", "bat", "rat" }, "the", false, 0)]
    [DataRow(new[] { "a", "aa", "aaa" }, "aaaa", true, 1)]
    [DataRow(new[] { "aaa", "aa" }, "aaaa", true, 2)]
    [DataRow(new[] { "abc" }, "ab", false, 0)]
    [DataRow(new[] { "abc" }, "abc", true, 3)]
    [DataRow(new string[] { }, "abc", false, 0)]
    [DataRow(new[] { "a" }, "", false, 0)]
    [DataRow(new[] { "" }, "abc", true, 0)]
    [DataRow(new[] { "he", "hello" }, "hello", true, 2)]
    [DataRow(new[] { "hello", "he" }, "help", true, 2)]
    [DataRow(new[] { "hel" }, "he", false, 0)]
    [DataRow(new[] { "x" }, "xyz", true, 1)]
    [DataRow(new[] { "y" }, "xyz", false, 0)]
    [DataRow(new[] { "ab", "abc" }, "abd", true, 2)]
    [DataRow(new[] { "abc", "abd" }, "abe", false, 0)]
    [DataRow(new[] { "catt", "cat" }, "cattle", true, 3)]
    [DataRow(new[] { "dog" }, "Dogma", false, 0)]
    [DataRow(new[] { "leet", "code", "leetcode" }, "leetcoder", true, 4)]
    [DataRow(new[] { "code" }, "leetcode", false, 0)]
    public void TryFindShortestPrefix_WithWordsAndText_ReturnsShortestWordPrefixLength(
        string[] words,
        string text,
        bool expectedResult,
        int expectedLength)
    {
        // Arrange
        var trie = new Trie(words);

        // Act
        var actualResult = trie.TryFindShortestPrefix(text, out var actualLength);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        Assert.AreEqual(expectedLength, actualLength);
    }

    [TestMethod]
    [DataRow(new[] { "leet", "code", "leetcode" }, "leetcode", new[] { 4, 8 })]
    [DataRow(new[] { "a", "aa", "aaa" }, "aaaa", new[] { 1, 2, 3 })]
    [DataRow(new[] { "a", "aa", "aaa" }, "aa", new[] { 1, 2 })]
    [DataRow(new[] { "abc" }, "ab", new int[] { })]
    [DataRow(new string[] { }, "abc", new int[] { })]
    [DataRow(new[] { "abc" }, "abc", new[] { 3 })]
    [DataRow(new[] { "cat", "cats" }, "catsdog", new[] { 3, 4 })]
    [DataRow(new[] { "dog" }, "catsdog", new int[] { })]
    [DataRow(new[] { "" }, "ab", new[] { 0 })]
    [DataRow(new[] { "", "a" }, "ab", new[] { 0, 1 })]
    [DataRow(new[] { "a" }, "", new int[] { })]
    [DataRow(new[] { "b" }, "abc", new int[] { })]
    [DataRow(new[] { "ab", "abc", "abcd" }, "abcde", new[] { 2, 3, 4 })]
    [DataRow(new[] { "abcd", "ab" }, "abc", new[] { 2 })]
    [DataRow(new[] { "hello", "world" }, "helloworld", new[] { 5 })]
    [DataRow(new[] { "x", "xyz" }, "xy", new[] { 1 })]
    [DataRow(new[] { "sayhello", "say", "hello" }, "sayhello", new[] { 3, 8 })]
    [DataRow(new[] { "ab", "ab" }, "abab", new[] { 2 })]
    [DataRow(new[] { "Ab" }, "ab", new int[] { })]
    [DataRow(new[] { "z", "zz", "zzz", "zzzz" }, "zzzz", new[] { 1, 2, 3, 4 })]
    public void FindPrefixLengths_WithWordsAndText_ReturnsWordPrefixLengthsInAscendingOrder(string[] words, string text, int[] expectedResult)
    {
        // Arrange
        var trie = new Trie(words);

        // Act
        var actualResult = trie.FindPrefixLengths(text);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}