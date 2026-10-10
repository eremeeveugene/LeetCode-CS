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

using LeetCode.Algorithms.DeleteColumnsToMakeSorted2;

namespace LeetCode.Tests.Algorithms.DeleteColumnsToMakeSorted2;

public abstract class DeleteColumnsToMakeSorted2TestsBase<T> where T : IDeleteColumnsToMakeSorted2, new()
{
    [TestMethod]
    [DataRow(new[] { "xc", "yb", "za" }, 0)]
    [DataRow(new[] { "ca", "bb", "ac" }, 1)]
    [DataRow(new[] { "xga", "xfb", "yfa" }, 1)]
    [DataRow(new[] { "zyx", "wvu", "tsr" }, 3)]
    [DataRow(new[] { "a" }, 0)]
    [DataRow(new[] { "ab" }, 0)]
    [DataRow(new[] { "ba" }, 0)]
    [DataRow(new[] { "a", "a" }, 0)]
    [DataRow(new[] { "b", "a" }, 1)]
    [DataRow(new[] { "ab", "ab" }, 0)]
    [DataRow(new[] { "aa", "ab", "ba" }, 0)]
    [DataRow(new[] { "ba", "ab" }, 1)]
    [DataRow(new[] { "abc", "abd", "abe" }, 0)]
    [DataRow(new[] { "zz", "aa" }, 2)]
    [DataRow(new[] { "bca", "bba" }, 1)]
    [DataRow(new[] { "bccb", "bcac", "abcb", "bcbb" }, 4)]
    [DataRow(new[] { "ccbbb", "cbcbb", "acbbb", "cacaa" }, 5)]
    [DataRow(new[] { "bcac", "ccba", "cccc", "bbcc" }, 2)]
    [DataRow(new[] { "aaacbc", "caacac", "cabaaa", "aababa" }, 2)]
    [DataRow(new[] { "bbbc", "caca" }, 0)]
    [DataRow(new[] { "babbbb", "accbac", "cbabcc" }, 4)]
    [DataRow(new[] { "bbabb", "cccbb", "aacbc", "baaca" }, 3)]
    [DataRow(new[] { "ababcc", "cabccb", "bbabbb", "cbbacc" }, 6)]
    [DataRow(new[] { "bbbbab", "bbbaba", "accbab", "aababc" }, 6)]
    [DataRow(new[] { "ba", "ab", "ba", "cb" }, 2)]
    public void MinDeletionSize_WithStringsOfEqualLength_ReturnsMinimumDeletionsForLexicographicOrder(string[] strs, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinDeletionSize(strs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}