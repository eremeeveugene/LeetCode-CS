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

using LeetCode.Algorithms.MinimumLengthOfStringAfterDeletingSimilarEnds;

namespace LeetCode.Tests.Algorithms.MinimumLengthOfStringAfterDeletingSimilarEnds;

public abstract class MinimumLengthOfStringAfterDeletingSimilarEndsTestsBase<T> where T : IMinimumLengthOfStringAfterDeletingSimilarEnds, new()
{
    [TestMethod]
    [DataRow("ca", 2)]
    [DataRow("cabaabac", 0)]
    [DataRow("aabccabba", 3)]
    [DataRow("bbbbbbbbbbbbbbbbbbb", 0)]
    [DataRow(
        "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbacccabbabccaccbacaaccacacccaccbbbacaabbccbbcbcbcacacccccccbcbbabccaacaabacbbaccccbabbcbccccaccacaccbcbbcbcccabaaaabbbbbbbbbbbbbbb",
        109)]
    [DataRow("a", 1)]
    [DataRow("b", 1)]
    [DataRow("aa", 0)]
    [DataRow("ab", 2)]
    [DataRow("aba", 1)]
    [DataRow("abc", 3)]
    [DataRow("abca", 2)]
    [DataRow("aabaa", 1)]
    [DataRow("abcba", 1)]
    [DataRow("abcabc", 6)]
    [DataRow("cbbbbbbc", 0)]
    [DataRow("aabbaa", 0)]
    [DataRow("abababab", 8)]
    [DataRow("aaabbbaaa", 0)]
    [DataRow("bcb", 1)]
    [DataRow("ccbbaabbcc", 0)]
    [DataRow("aabccabbaaa", 3)]
    [DataRow("acbbca", 0)]
    public void MinimumLength_WithRepeatingPrefixSuffixPattern_ReturnsFinalLengthAfterAllDeletions(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumLength(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}