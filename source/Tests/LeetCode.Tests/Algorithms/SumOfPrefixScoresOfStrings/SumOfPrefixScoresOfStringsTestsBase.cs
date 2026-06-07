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

using LeetCode.Algorithms.SumOfPrefixScoresOfStrings;

namespace LeetCode.Tests.Algorithms.SumOfPrefixScoresOfStrings;

public abstract class SumOfPrefixScoresOfStringsTestsBase<T> where T : ISumOfPrefixScoresOfStrings, new()
{
    [TestMethod]
    [DataRow(new[] { "a" }, new[] { 1 })]
    [DataRow(new[] { "abcd" }, new[] { 4 })]
    [DataRow(new[] { "abc", "ab", "bc", "b" }, new[] { 5, 4, 3, 2 })]
    [DataRow(new[] { "a", "b", "aa", "ab" }, new[] { 3, 1, 4, 4 })]
    [DataRow(new[] { "abababab", "abab", "ab", "a", "babababa", "baba", "ba", "b" }, new[] { 15, 11, 7, 4, 15, 11, 7, 4 })]
    [DataRow(new[] { "aa", "aa" }, new[] { 4, 4 })]
    [DataRow(new[] { "ab", "ac" }, new[] { 3, 3 })]
    [DataRow(new[] { "abc", "abd", "abe" }, new[] { 7, 7, 7 })]
    [DataRow(new[] { "a", "a", "a" }, new[] { 3, 3, 3 })]
    [DataRow(new[] { "z" }, new[] { 1 })]
    [DataRow(new[] { "abc", "abc" }, new[] { 6, 6 })]
    [DataRow(new[] { "ab", "abc", "abcd" }, new[] { 6, 8, 9 })]
    [DataRow(new[] { "a", "ab", "abc", "abcd" }, new[] { 4, 7, 9, 10 })]
    [DataRow(new[] { "aa", "ab", "ba", "bb" }, new[] { 3, 3, 3, 3 })]
    [DataRow(new[] { "abc", "def" }, new[] { 3, 3 })]
    [DataRow(new[] { "abcdef", "abcde", "abcd", "abc" }, new[] { 18, 17, 15, 12 })]
    [DataRow(new[] { "x", "xy", "xyz" }, new[] { 3, 5, 6 })]
    [DataRow(new[] { "cat", "car", "card" }, new[] { 7, 8, 9 })]
    [DataRow(new[] { "hello", "help", "world" }, new[] { 8, 7, 5 })]
    [DataRow(new[] { "a", "b", "c" }, new[] { 1, 1, 1 })]
    public void SumPrefixScores_WithListOfWords_ReturnsSumOfScoresForAllPrefixesOfEachWord(string[] words, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumPrefixScores(words);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}