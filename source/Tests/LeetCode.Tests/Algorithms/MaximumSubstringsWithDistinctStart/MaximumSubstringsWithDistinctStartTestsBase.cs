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

using LeetCode.Algorithms.MaximumSubstringsWithDistinctStart;

namespace LeetCode.Tests.Algorithms.MaximumSubstringsWithDistinctStart;

public abstract class MaximumSumOfDistinctSubarraysWithLengthKTestsBase<T> where T : IMaximumSubstringsWithDistinctStart, new()
{
    [TestMethod]
    [DataRow("aaaa", 1)]
    [DataRow("abab", 2)]
    [DataRow("abcd", 4)]
    [DataRow("a", 1)]
    [DataRow("z", 1)]
    [DataRow("ab", 2)]
    [DataRow("aa", 1)]
    [DataRow("aabb", 2)]
    [DataRow("abcabc", 3)]
    [DataRow("aabbcc", 3)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 26)]
    [DataRow("abcdeabcde", 5)]
    [DataRow("zzzz", 1)]
    [DataRow("ababab", 2)]
    [DataRow("abba", 2)]
    [DataRow("azbzc", 4)]
    [DataRow("abcba", 3)]
    [DataRow("aab", 2)]
    public void MaxDistinct_WithStringContainingLowercaseLetters_ReturnsMaxSubstringsWithDistinctStartCharacters(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDistinct(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}