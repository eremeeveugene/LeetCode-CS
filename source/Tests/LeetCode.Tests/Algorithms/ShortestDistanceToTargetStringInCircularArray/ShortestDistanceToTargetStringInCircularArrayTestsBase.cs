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

using LeetCode.Algorithms.ShortestDistanceToTargetStringInCircularArray;

namespace LeetCode.Tests.Algorithms.ShortestDistanceToTargetStringInCircularArray;

public abstract class ShortestDistanceToTargetStringInCircularArrayTestsBase<T> where T : IShortestDistanceToTargetStringInCircularArray, new()
{
    [TestMethod]
    [DataRow(new[] { "hello", "i", "am", "leetcode", "hello" }, "hello", 1, 1)]
    [DataRow(new[] { "a", "b", "leetcode" }, "leetcode", 0, 1)]
    [DataRow(new[] { "i", "eat", "leetcode" }, "ate", 0, -1)]
    [DataRow(new[] { "a" }, "a", 0, 0)]
    [DataRow(new[] { "a" }, "b", 0, -1)]
    [DataRow(new[] { "a", "b" }, "b", 0, 1)]
    [DataRow(new[] { "a", "b" }, "a", 1, 1)]
    [DataRow(new[] { "a", "b", "c" }, "c", 0, 1)]
    [DataRow(new[] { "a", "b", "c", "d", "e" }, "d", 0, 2)]
    [DataRow(new[] { "a", "b", "c", "d", "e" }, "b", 4, 2)]
    [DataRow(new[] { "a", "b", "a", "b", "a" }, "b", 2, 1)]
    [DataRow(new[] { "a", "b", "a", "b", "a" }, "a", 2, 0)]
    [DataRow(new[] { "x", "y", "x", "y" }, "z", 1, -1)]
    [DataRow(new[] { "p", "q", "r", "s", "t", "u" }, "t", 1, 3)]
    [DataRow(new[] { "p", "q", "r", "s", "t", "u" }, "q", 5, 2)]
    [DataRow(new[] { "same", "same", "same" }, "same", 1, 0)]
    [DataRow(new[] { "ab", "a", "b" }, "a", 0, 1)]
    [DataRow(new[] { "w1", "w2", "w3", "w4", "w5", "w6", "w7", "w8" }, "w5", 0, 4)]
    [DataRow(new[] { "w1", "w2", "w3", "w4", "w5", "w6", "w7", "w8" }, "w6", 7, 2)]
    [DataRow(new[] { "m", "n", "m", "n", "m", "n" }, "n", 0, 1)]
    public void ClosestTarget_WithWordsArrayTargetAndStartIndex_ReturnsShortestDistanceToTargetString(
        string[] words,
        string target,
        int startIndex,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ClosestTarget(words, target, startIndex);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}