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
    [DataRow(new[] { "a" }, new[] { 0 }, new[] { "a" })]
    [DataRow(new[] { "a" }, new[] { 1 }, new[] { "a" })]
    [DataRow(new[] { "a", "b" }, new[] { 0, 1 }, new[] { "a", "b" })]
    [DataRow(new[] { "a", "b" }, new[] { 1, 1 }, new[] { "a" })]
    [DataRow(new[] { "a", "b", "c" }, new[] { 0, 0, 0 }, new[] { "a" })]
    [DataRow(new[] { "a", "b", "c" }, new[] { 0, 1, 0 }, new[] { "a", "b", "c" })]
    [DataRow(new[] { "a", "b", "c", "d" }, new[] { 1, 1, 0, 0 }, new[] { "a", "c" })]
    [DataRow(new[] { "x", "y", "z", "w", "v" }, new[] { 0, 1, 1, 0, 0 }, new[] { "x", "y", "w" })]
    [DataRow(new[] { "a", "b", "c", "d", "e", "f" }, new[] { 1, 0, 1, 0, 1, 0 }, new[] { "a", "b", "c", "d", "e", "f" })]
    [DataRow(new[] { "a", "b", "c", "d", "e", "f" }, new[] { 0, 0, 0, 1, 1, 1 }, new[] { "a", "d" })]
    [DataRow(new[] { "ab", "cd", "ef" }, new[] { 1, 0, 0 }, new[] { "ab", "cd" })]
    [DataRow(new[] { "a", "b", "c", "d", "e", "f" }, new[] { 1, 1, 0, 0, 0, 0 }, new[] { "a", "c" })]
    [DataRow(new[] { "a", "b", "c", "d", "e", "f" }, new[] { 0, 0, 1, 0, 1, 1 }, new[] { "a", "c", "d", "e" })]
    [DataRow(new[] { "a", "b", "c", "d", "e", "f", "g", "h" }, new[] { 1, 1, 0, 1, 0, 1, 0, 0 }, new[] { "a", "c", "d", "e", "f", "g" })]
    [DataRow(new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" }, new[] { 1, 1, 1, 1, 0, 1, 0, 0, 1, 1 }, new[] { "a", "e", "f", "g", "i" })]
    [DataRow(new[] { "a", "b", "c", "d", "e" }, new[] { 0, 1, 0, 0, 1 }, new[] { "a", "b", "c", "e" })]
    [DataRow(new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" }, new[] { 0, 0, 0, 0, 1, 0, 0, 1, 1, 1 }, new[] { "a", "e", "f", "h" })]
    [DataRow(new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i" }, new[] { 1, 1, 0, 0, 0, 1, 1, 1, 0 }, new[] { "a", "c", "f", "i" })]
    [DataRow(new[] { "a", "b", "c", "d", "e", "f", "g" }, new[] { 0, 1, 1, 0, 0, 1, 0 }, new[] { "a", "b", "d", "f", "g" })]
    [DataRow(new[] { "a", "b", "c", "d", "e" }, new[] { 1, 1, 0, 1, 0 }, new[] { "a", "c", "d", "e" })]
    public void GetLongestSubsequence_WithWordsAndGroupLabels_ReturnsLongestSubsequenceByGroupOrder(
        string[] words,
        int[] groups,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualList = solution.GetLongestSubsequence(words, groups);
        var actualResult = new string[actualList.Count];

        actualList.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}