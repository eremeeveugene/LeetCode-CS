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

using LeetCode.Algorithms.NumberOfSubstringsContainingAllThreeCharacters;

namespace LeetCode.Tests.Algorithms.NumberOfSubstringsContainingAllThreeCharacters;

public abstract class NumberOfSubstringsContainingAllThreeCharactersTestsBase<T> where T : INumberOfSubstringsContainingAllThreeCharacters, new()
{
    [TestMethod]
    [DataRow("abcabc", 10)]
    [DataRow("aaacb", 3)]
    [DataRow("abc", 1)]
    [DataRow("a", 0)]
    [DataRow("b", 0)]
    [DataRow("c", 0)]
    [DataRow("ab", 0)]
    [DataRow("bca", 1)]
    [DataRow("cba", 1)]
    [DataRow("cab", 1)]
    [DataRow("ccc", 0)]
    [DataRow("abab", 0)]
    [DataRow("aabb", 0)]
    [DataRow("bcbcb", 0)]
    [DataRow("cccccccccc", 0)]
    [DataRow("abca", 3)]
    [DataRow("cabc", 3)]
    [DataRow("abcc", 2)]
    [DataRow("aabc", 2)]
    [DataRow("aabbcc", 4)]
    [DataRow("abcba", 5)]
    [DataRow("acbca", 5)]
    [DataRow("bacacb", 7)]
    [DataRow("baccab", 7)]
    [DataRow("aaabbbccc", 9)]
    [DataRow("abcabcabc", 28)]
    public void NumberOfSubstrings_WithGivenString_ReturnsNumberOfSubstringsContainingAllThreeCharacters(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfSubstrings(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}