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

using LeetCode.Algorithms.CountSubarraysWithFixedBounds;

namespace LeetCode.Tests.Algorithms.CountSubarraysWithFixedBounds;

public abstract class CountSubarraysWithFixedBoundsTestsBase<T> where T : ICountSubarraysWithFixedBounds, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 5, 2, 7, 5 }, 1, 5, 2L)]
    [DataRow(new[] { 1, 1, 1, 1 }, 1, 1, 10L)]
    [DataRow(new[] { 0, 4, 1, 5 }, 1, 5, 2L)]
    [DataRow(new[] { 2, 3, 4, 5, 6 }, 2, 6, 1L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 3, 1L)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 1, 5, 1L)]
    [DataRow(new[] { 1, 5, 1, 5, 1, 5 }, 1, 5, 15L)]
    [DataRow(new[] { 9, 9, 9 }, 9, 9, 6L)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 1, 2, 10L)]
    [DataRow(new[] { 0, 1, 2, 3, 0 }, 1, 3, 1L)]
    [DataRow(new[] { 4, 1, 4, 4, 4, 1, 4 }, 1, 4, 18L)]
    [DataRow(new[] { 1, 1, 2, 1, 1 }, 1, 2, 8L)]
    [DataRow(new[] { 3, 3, 3, 3 }, 1, 3, 0L)]
    [DataRow(new[] { 1, 4, 4, 4, 1 }, 1, 4, 7L)]
    [DataRow(new[] { 2, 1, 2, 1, 2 }, 1, 2, 10L)]
    [DataRow(new[] { 6, 2, 6, 2, 6 }, 2, 6, 10L)]
    [DataRow(new[] { 1 }, 1, 1, 1L)]
    [DataRow(new[] { 2 }, 1, 5, 0L)]
    [DataRow(new[] { 1, 2, 3, 2, 1 }, 1, 3, 5L)]
    [DataRow(new[] { 5, 1, 5, 1, 5, 1 }, 1, 5, 15L)]
    [DataRow(new[] { 1, 10, 1, 10, 1 }, 1, 10, 10L)]
    [DataRow(new[] { 0, 0, 1, 5, 0, 0 }, 1, 5, 1L)]
    public void CountSubarrays_WithMinAndMaxBounds_ReturnsNumberOfSubarraysWithFixedBounds(int[] nums, int minK, int maxK, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums, minK, maxK);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}