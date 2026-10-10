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

using LeetCode.Algorithms.MinimumSumOfSquaredDifference;

namespace LeetCode.Tests.Algorithms.MinimumSumOfSquaredDifference;

public abstract class MinimumSumOfSquaredDifferenceTestsBase<T> where T : IMinimumSumOfSquaredDifference, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 2, 10, 20, 19 }, 0, 0, 579L)]
    [DataRow(new[] { 1, 4, 10, 12 }, new[] { 5, 8, 6, 9 }, 1, 1, 43L)]
    [DataRow(new[] { 1 }, new[] { 1 }, 0, 0, 0L)]
    [DataRow(new[] { 5 }, new[] { 1 }, 0, 0, 16L)]
    [DataRow(new[] { 5 }, new[] { 1 }, 2, 0, 4L)]
    [DataRow(new[] { 5 }, new[] { 1 }, 10, 10, 0L)]
    [DataRow(new[] { 1, 1 }, new[] { 3, 3 }, 1, 0, 5L)]
    [DataRow(new[] { 1, 1 }, new[] { 3, 3 }, 2, 0, 2L)]
    [DataRow(new[] { 1, 1 }, new[] { 3, 3 }, 3, 0, 1L)]
    [DataRow(new[] { 1, 1 }, new[] { 3, 3 }, 4, 0, 0L)]
    [DataRow(new[] { 3, 3 }, new[] { 1, 1 }, 0, 2, 2L)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, 5, 5, 0L)]
    [DataRow(new[] { 10, 0 }, new[] { 0, 10 }, 0, 0, 200L)]
    [DataRow(new[] { 10, 0 }, new[] { 0, 10 }, 5, 0, 113L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 }, 0, 0, 40L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 }, 2, 0, 26L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 }, 1, 3, 16L)]
    [DataRow(new[] { 100000 }, new[] { 0 }, 0, 0, 10000000000L)]
    [DataRow(new[] { 100000 }, new[] { 0 }, 1, 0, 9999800001L)]
    [DataRow(new[] { 0, 0, 0 }, new[] { 1, 1, 1 }, 1, 1, 1L)]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 }, 0, 0, 0L)]
    [DataRow(new[] { 7, 7, 7 }, new[] { 1, 1, 1 }, 3, 0, 75L)]
    [DataRow(new[] { 7, 7, 7 }, new[] { 1, 1, 1 }, 4, 0, 66L)]
    public void MinSumSquareDiff_GivenArraysAndModificationBudgets_ReturnsMinimumSumOfSquaredDifferences(
        int[] nums1,
        int[] nums2,
        int k1,
        int k2,
        long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinSumSquareDiff(nums1, nums2, k1, k2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}