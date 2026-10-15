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

using LeetCode.Algorithms.LongestUnequalAdjacentGroupsSubsequence2;

namespace LeetCode.Tests.Algorithms.LongestUnequalAdjacentGroupsSubsequence2;

public abstract class LongestUnequalAdjacentGroupsSubsequence2TestsBase<T> where T : ILongestUnequalAdjacentGroupsSubsequence2, new()
{
    [TestMethod]
    [DataRow(new[] { "a", "b", "c", "d" }, new[] { 1, 2, 3, 4 }, new[] { "a", "b", "c", "d" })]
    [DataRow(new[] { "a" }, new[] { 1 }, new[] { "a" })]
    [DataRow(new[] { "leetcode" }, new[] { 7 }, new[] { "leetcode" })]
    [DataRow(new[] { "a", "b" }, new[] { 1, 2 }, new[] { "a", "b" })]
    [DataRow(new[] { "b", "a" }, new[] { 1, 2 }, new[] { "b", "a" })]
    [DataRow(new[] { "abc", "abd" }, new[] { 1, 2 }, new[] { "abc", "abd" })]
    [DataRow(new[] { "abc", "abd", "abe" }, new[] { 1, 2, 1 }, new[] { "abc", "abd", "abe" })]
    [DataRow(new[] { "aa", "ab", "bb", "ba" }, new[] { 1, 2, 1, 2 }, new[] { "aa", "ab", "bb", "ba" })]
    [DataRow(new[] { "aa", "ba", "bb", "ab" }, new[] { 1, 2, 1, 2 }, new[] { "aa", "ba", "bb", "ab" })]
    [DataRow(new[] { "a", "bb", "c" }, new[] { 1, 2, 3 }, new[] { "a", "c" })]
    [DataRow(new[] { "abc", "xyz", "abd" }, new[] { 1, 2, 3 }, new[] { "abc", "abd" })]
    [DataRow(new[] { "abc", "abd", "xbd" }, new[] { 1, 1, 2 }, new[] { "abd", "xbd" })]
    [DataRow(new[] { "cat", "bat", "bet", "bed" }, new[] { 1, 2, 1, 2 }, new[] { "cat", "bat", "bet", "bed" })]
    [DataRow(new[] { "ab", "cd", "ef", "eg" }, new[] { 1, 2, 3, 4 }, new[] { "ef", "eg" })]
    [DataRow(new[] { "abcd", "abce", "abde", "abdf" }, new[] { 1, 2, 3, 4 }, new[] { "abcd", "abce", "abde", "abdf" })]
    [DataRow(new[] { "aaa", "aab", "abb", "bbb", "bba" }, new[] { 1, 2, 3, 4, 5 }, new[] { "aaa", "aab", "abb", "bbb", "bba" })]
    [DataRow(new[] { "aaa", "aab", "abb", "bbb", "bba" }, new[] { 1, 2, 2, 4, 5 }, new[] { "abb", "bbb", "bba" })]
    [DataRow(new[] { "ab", "ac", "bc", "bd", "cd" }, new[] { 5, 4, 3, 2, 1 }, new[] { "ab", "ac", "bc", "bd", "cd" })]
    [DataRow(new[] { "xy", "ab", "xz" }, new[] { 2, 1, 1 }, new[] { "xy", "xz" })]
    [DataRow(new[] { "hello", "hallo", "hullo", "hulls" }, new[] { 1, 2, 2, 3 }, new[] { "hello", "hullo", "hulls" })]
    [DataRow(new[] { "abc", "zzz", "abd", "abe" }, new[] { 1, 2, 2, 1 }, new[] { "abc", "abd", "abe" })]
    [DataRow(new[] { "dog", "dot", "cot", "cat", "car" }, new[] { 1, 2, 1, 2, 1 }, new[] { "dog", "dot", "cot", "cat", "car" })]
    public void GetWordsInLongestSubsequence_WithWordsAndGroups_ReturnsLongestValidSubsequence(string[] words, int[] groups, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetWordsInLongestSubsequence(words, groups);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}