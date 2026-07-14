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

using LeetCode.Algorithms.LongestUnequalAdjacentGroupsSubsequence1;

namespace LeetCode.Tests.Algorithms.LongestUnequalAdjacentGroupsSubsequence1;

public abstract class LongestUnequalAdjacentGroupsSubsequence1TestsBase<T> where T : ILongestUnequalAdjacentGroupsSubsequence1, new()
{
    [TestMethod]
    [DataRow(new[] { "e", "a", "b" }, new[] { 0, 0, 1 }, new[] { "e", "b" })]
    [DataRow(new[] { "a", "b", "c", "d" }, new[] { 1, 0, 1, 1 }, new[] { "a", "b", "c" })]
    public void GetLongestSubsequence_WithWordsAndGroupLabels_ReturnsLongestSubsequenceByGroupOrder(
        string[] words,
        int[] groups,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetLongestSubsequence(words, groups).ToArray();

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}