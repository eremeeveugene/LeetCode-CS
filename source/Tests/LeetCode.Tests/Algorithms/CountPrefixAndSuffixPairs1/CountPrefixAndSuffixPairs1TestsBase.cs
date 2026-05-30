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

using LeetCode.Algorithms.CountPrefixAndSuffixPairs1;

namespace LeetCode.Tests.Algorithms.CountPrefixAndSuffixPairs1;

public abstract class CountPrefixAndSuffixPairs1TestsBase<T> where T : ICountPrefixAndSuffixPairs1, new()
{
    [TestMethod]
    [DataRow(new[] { "a", "aba", "ababa", "aa" }, 4)]
    [DataRow(new[] { "pa", "papa", "ma", "mama" }, 2)]
    [DataRow(new[] { "abab", "ab" }, 0)]
    public void CountPrefixSuffixPairs_WithStringArray_ReturnsNumberOfValidPrefixAndSuffixPairs(string[] words, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountPrefixSuffixPairs(words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}