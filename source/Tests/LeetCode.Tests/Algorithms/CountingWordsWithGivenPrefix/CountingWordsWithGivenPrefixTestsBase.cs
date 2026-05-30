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

using LeetCode.Algorithms.CountingWordsWithGivenPrefix;

namespace LeetCode.Tests.Algorithms.CountingWordsWithGivenPrefix;

public abstract class CountingWordsWithGivenPrefixTestsBase<T> where T : ICountingWordsWithGivenPrefix, new()
{
    [TestMethod]
    [DataRow(new[] { "pay", "attention", "practice", "attend" }, "at", 2)]
    [DataRow(new[] { "leetcode", "win", "loops", "success" }, "code", 0)]
    public void PrefixCount_WithWordsArrayAndPrefix_ReturnsCountOfMatchingWords(string[] words, string pref, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PrefixCount(words, pref);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}