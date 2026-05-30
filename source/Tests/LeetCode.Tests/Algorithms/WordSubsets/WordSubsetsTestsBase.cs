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
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "e", "o" },
        new[] { "facebook", "google", "leetcode" })]
    [DataRow(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "l", "e" },
        new[] { "apple", "google", "leetcode" })]
    public void WordSubsets_WithWords1AndWords2_ReturnsMatchingSubset(string[] words1, string[] words2,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WordSubsets(words1, words2).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}