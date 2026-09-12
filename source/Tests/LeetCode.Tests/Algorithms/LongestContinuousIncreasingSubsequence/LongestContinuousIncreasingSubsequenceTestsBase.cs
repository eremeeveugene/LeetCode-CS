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

using LeetCode.Algorithms.LongestContinuousIncreasingSubsequence;

namespace LeetCode.Tests.Algorithms.LongestContinuousIncreasingSubsequence;

public abstract class LongestContinuousIncreasingSubsequenceTestsBase<T> where T : ILongestContinuousIncreasingSubsequence, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 5, 4, 7 }, 3)]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, 1)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 0 }, 1)]
    [DataRow(new[] { -1 }, 1)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3, 0 }, 3)]
    [DataRow(new[] { 5, 1, 2, 3 }, 3)]
    [DataRow(new[] { 5, 1, 2, 3, 0 }, 3)]
    [DataRow(new[] { 1, 2, 2, 3, 4 }, 3)]
    [DataRow(new[] { 1, 2, 3, 3, 4 }, 3)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 2)]
    [DataRow(new[] { -5, -4, -3, -2, -1 }, 5)]
    [DataRow(new[] { -1, -2, -3, -4 }, 1)]
    [DataRow(new[] { -3, -1, 0, 2 }, 4)]
    [DataRow(new[] { 0, 0, 1, 2, 2, 3, 4, 5 }, 4)]
    [DataRow(new[] { 1, 3, 2, 4, 3, 5 }, 2)]
    [DataRow(new[] { 1, 2, 3, 0, 1, 2, 3, 4 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 0, 1, 2 }, 4)]
    [DataRow(new[] { -1000000000, 0, 1000000000 }, 3)]
    [DataRow(new[] { 1000000000, -1000000000 }, 1)]
    [DataRow(new[] { 3, 3, 3, 1, 2, 3, 4, 4 }, 4)]
    public void FindLengthOfLCIS_WithGivenNumbers_ReturnsLongestContinuousIncreasingSubsequenceLength(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindLengthOfLCIS(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}