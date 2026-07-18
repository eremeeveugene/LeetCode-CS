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

using LeetCode.Algorithms.CountSubarraysWithScoreLessThanK;

namespace LeetCode.Tests.Algorithms.CountSubarraysWithScoreLessThanK;

public abstract class CountSubarraysWithScoreLessThanKTestsBase<T> where T : ICountSubarraysWithScoreLessThanK, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 4, 3, 5 }, 10L, 6L)]
    [DataRow(new[] { 1, 1, 1 }, 5L, 5L)]
    [DataRow(new[] { 5 }, 5L, 0L)]
    [DataRow(new[] { 10 }, 5L, 0L)]
    [DataRow(new[] { 1 }, 2L, 1L)]
    [DataRow(new[] { 1 }, 1L, 0L)]
    [DataRow(new[] { 2, 5, 1 }, 6L, 3L)]
    [DataRow(new[] { 4, 4, 4 }, 4L, 0L)]
    [DataRow(new[] { 1, 9, 1 }, 9L, 2L)]
    [DataRow(new[] { 2, 2 }, 3L, 2L)]
    [DataRow(new[] { 3, 1, 2 }, 7L, 4L)]
    [DataRow(new[] { 1, 2, 3 }, 100L, 6L)]
    [DataRow(new[] { 1, 1, 1, 1 }, 4L, 4L)]
    [DataRow(new[] { 1, 1, 1, 1 }, 5L, 7L)]
    [DataRow(new[] { 6, 1 }, 6L, 1L)]
    [DataRow(new[] { 1, 6 }, 6L, 1L)]
    [DataRow(new[] { 2, 3, 4, 5 }, 20L, 7L)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 15L, 8L)]
    [DataRow(new[] { 100 }, 1000L, 1L)]
    [DataRow(new[] { 1000000000, 1000000000 }, 10L, 0L)]
    [DataRow(new[] { 1, 2, 1, 2 }, 6L, 4L)]
    [DataRow(new[] { 7, 8, 9 }, 100L, 6L)]
    public void CountSubarrays_WithPositiveIntArrayAndScoreThreshold_ReturnsNumberOfSubarraysWithScoreLessThanK(
        int[] nums,
        long k,
        long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}