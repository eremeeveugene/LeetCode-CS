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

using LeetCode.Algorithms.FindTheLexicographicallySmallestValidSequence;

namespace LeetCode.Tests.Algorithms.FindTheLexicographicallySmallestValidSequence;

public abstract class FindTheLexicographicallySmallestValidSequenceTestsBase<T> where T : IFindTheLexicographicallySmallestValidSequence, new()
{
    [TestMethod]
    [DataRow("vbcca", "abc", new[] { 0, 1, 2 })]
    [DataRow("bacdc", "abc", new[] { 1, 2, 4 })]
    [DataRow("aaaaaa", "aaabc", new int[] { })]
    [DataRow("abc", "ab", new[] { 0, 1 })]
    [DataRow("ab", "a", new[] { 0 })]
    [DataRow("ab", "b", new[] { 0 })]
    [DataRow("aa", "b", new[] { 0 })]
    [DataRow("aaa", "bb", new int[] { })]
    [DataRow("abab", "ba", new[] { 0, 2 })]
    [DataRow("xyz", "xyz", new[] { 0, 1, 2 })]
    [DataRow("xxyz", "xyz", new[] { 0, 1, 3 })]
    [DataRow("aaaa", "aaa", new[] { 0, 1, 2 })]
    [DataRow("aaabb", "aabb", new[] { 0, 1, 2, 3 })]
    [DataRow("ba", "a", new[] { 0 })]
    [DataRow("abcdef", "xyz", new int[] { })]
    [DataRow("aabbaa", "aba", new[] { 0, 1, 4 })]
    [DataRow("bbbbb", "abc", new int[] { })]
    [DataRow("cab", "ab", new[] { 0, 2 })]
    [DataRow("aabb", "ab", new[] { 0, 1 })]
    [DataRow("za", "a", new[] { 0 })]
    public void ValidSequence_WithWord1AndWord2_ReturnsLexicographicallySmallestValidSequence(string word1, string word2, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ValidSequence(word1, word2);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}