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

using LeetCode.Algorithms.MinimumTimeToMakeRopeColorful;

namespace LeetCode.Tests.Algorithms.MinimumTimeToMakeRopeColorful;

public abstract class MinimumTimeToMakeRopeColorfulTestsBase<T> where T : IMinimumTimeToMakeRopeColorful, new()
{
    [TestMethod]
    [DataRow("abaac", new[] { 1, 2, 3, 4, 5 }, 3)]
    [DataRow("abc", new[] { 1, 2, 3 }, 0)]
    [DataRow("aabaa", new[] { 1, 2, 3, 4, 1 }, 2)]
    [DataRow("a", new[] { 5 }, 0)]
    [DataRow("aa", new[] { 3, 7 }, 3)]
    [DataRow("aaa", new[] { 1, 2, 3 }, 3)]
    [DataRow("aaaa", new[] { 1, 2, 3, 4 }, 6)]
    [DataRow("ababab", new[] { 1, 2, 3, 4, 5, 6 }, 0)]
    [DataRow("aabb", new[] { 1, 2, 3, 4 }, 4)]
    [DataRow("aaa", new[] { 5, 5, 5 }, 10)]
    [DataRow("abcabc", new[] { 1, 2, 3, 4, 5, 6 }, 0)]
    [DataRow("aabbcc", new[] { 1, 1, 1, 1, 1, 1 }, 3)]
    [DataRow("aaab", new[] { 1, 1, 1, 5 }, 2)]
    [DataRow("baaa", new[] { 5, 1, 1, 1 }, 2)]
    [DataRow("abba", new[] { 1, 2, 3, 4 }, 2)]
    [DataRow("abccba", new[] { 1, 2, 3, 4, 5, 6 }, 3)]
    [DataRow("aabaa", new[] { 3, 5, 2, 4, 1 }, 4)]
    [DataRow("aaab", new[] { 10000, 10000, 10000, 1 }, 20000)]
    [DataRow("wxyz", new[] { 100, 200, 300, 400 }, 0)]
    [DataRow("xxxxxx", new[] { 1, 1, 1, 1, 1, 1 }, 5)]
    [DataRow("aaabbbccc", new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 27)]
    [DataRow("abcabcabc", new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
    [DataRow("aabb", new[] { 10000, 1, 1, 10000 }, 2)]
    [DataRow("z", new[] { 10000 }, 0)]
    [DataRow("aabbaa", new[] { 1, 2, 3, 4, 5, 6 }, 9)]
    public void MinCost_WithColorsAndNeededTime_ReturnsMinimumRemovalTimeToAvoidConsecutiveSameColors(
        string colors,
        int[] neededTime,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinCost(colors, neededTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}