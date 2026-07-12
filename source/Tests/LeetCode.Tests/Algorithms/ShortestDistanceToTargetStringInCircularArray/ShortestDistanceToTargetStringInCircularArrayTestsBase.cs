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