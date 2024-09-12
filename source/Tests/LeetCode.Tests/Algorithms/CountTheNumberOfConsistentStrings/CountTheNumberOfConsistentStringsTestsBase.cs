// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CountTheNumberOfConsistentStrings;

namespace LeetCode.Tests.Algorithms.CountTheNumberOfConsistentStrings;

public abstract class CountTheNumberOfConsistentStringsTestsBase<T> where T : ICountTheNumberOfConsistentStrings, new()
{
    [TestMethod]
    [DataRow("ab", new[] { "ad", "bd", "aaab", "baa", "badab" }, 2)]
    [DataRow("abc", new[] { "a", "b", "c", "ab", "ac", "bc", "abc" }, 7)]
    [DataRow("cad", new[] { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" }, 4)]
    public void CountConsistentStrings_WithAllowedCharactersAndWords_ReturnsNumberOfConsistentStrings(string allowed,
        string[] words, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountConsistentStrings(allowed, words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}