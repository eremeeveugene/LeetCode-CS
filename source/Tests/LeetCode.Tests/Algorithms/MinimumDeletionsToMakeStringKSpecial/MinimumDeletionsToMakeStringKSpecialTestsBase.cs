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

using LeetCode.Algorithms.MinimumDeletionsToMakeStringKSpecial;

namespace LeetCode.Tests.Algorithms.MinimumDeletionsToMakeStringKSpecial;

public abstract class MinimumDeletionsToMakeStringKSpecialTestsBase<T> where T : IMinimumDeletionsToMakeStringKSpecial, new()
{
    [TestMethod]
    [DataRow("aabcaba", 0, 3)]
    [DataRow("aaabaaa", 2, 1)]
    [DataRow("dabdcbdcdcd", 2, 2)]
    [DataRow("a", 0, 0)]
    [DataRow("a", 100000, 0)]
    [DataRow("ab", 0, 0)]
    [DataRow("aab", 0, 1)]
    [DataRow("aab", 1, 0)]
    [DataRow("aaabb", 0, 1)]
    [DataRow("aaabb", 1, 0)]
    [DataRow("abcdef", 0, 0)]
    [DataRow("aaaaaaaaaa", 5, 0)]
    [DataRow("aaaaaaaabbc", 1, 3)]
    [DataRow("aaaaaaaabbc", 3, 3)]
    [DataRow("aaaaaaaabbc", 10, 0)]
    [DataRow("abbcccdddd", 1, 2)]
    [DataRow("abbcccdddd", 0, 4)]
    [DataRow("abbcccdddd", 2, 1)]
    [DataRow("zzzzyyxwww", 1, 2)]
    [DataRow("fbdbgaeaafaacgdebgdbbf", 0, 7)]
    [DataRow("feeaeceggcdccbefdag", 0, 7)]
    [DataRow("aagagbddacdb", 0, 4)]
    public void MinimumDeletions_WithWordAndValueK_ReturnsMinimumDeletionsToMakeKSpecial(string word, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumDeletions(word, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}