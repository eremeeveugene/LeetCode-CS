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

using LeetCode.Algorithms.CountTheNumberOfFairPairs;

namespace LeetCode.Tests.Algorithms.CountTheNumberOfFairPairs;

public abstract class CountTheNumberOfFairPairsTestsBase<T> where T : ICountTheNumberOfFairPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 7, 4, 4, 5 }, 3, 6, 6L)]
    [DataRow(new[] { 1, 7, 9, 2, 5 }, 11, 11, 1L)]
    [DataRow(new[] { 1 }, 0, 0, 0L)]
    [DataRow(new[] { 1, 1 }, 2, 2, 1L)]
    [DataRow(new[] { 1, 1 }, 3, 3, 0L)]
    [DataRow(new[] { 5, 5, 5 }, 10, 10, 3L)]
    [DataRow(new[] { 0, 0, 0, 0 }, 0, 0, 6L)]
    [DataRow(new[] { -1, 1 }, 0, 0, 1L)]
    [DataRow(new[] { -5, -3, -1 }, -8, -4, 3L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 7, 6L)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 5, 7, 6L)]
    [DataRow(new[] { 500000000, 500000000 }, 1000000000, 1000000000, 1L)]
    [DataRow(new[] { 1000000000, 1000000000 }, 1000000000, 1000000000, 0L)]
    [DataRow(new[] { -1000000000, 1000000000, 0 }, -1000000000, 1000000000, 3L)]
    [DataRow(new[] { -1000000000, -1000000000 }, -1000000000, 1000000000, 0L)]
    [DataRow(new[] { 3, 3, 3, 3 }, 6, 6, 6L)]
    [DataRow(new[] { 1, 2, 3 }, 10, 20, 0L)]
    [DataRow(new[] { 1, 2, 3 }, -5, 2, 0L)]
    [DataRow(new[] { 10, -10, 20, -20, 0 }, -10, 10, 6L)]
    [DataRow(new[] { 2, 4, 6, 8, 10 }, 8, 14, 7L)]
    [DataRow(new[] { 7, 7, 1, 1, 4 }, 8, 8, 4L)]
    public void CountFairPairs_WithArrayAndBounds_ReturnsTheNumberOfFairPairs(int[] nums, int lower, int upper, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountFairPairs(nums, lower, upper);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}