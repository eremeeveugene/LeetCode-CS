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

using LeetCode.Algorithms.MaximumSumOfDistinctSubarraysWithLengthK;

namespace LeetCode.Tests.Algorithms.MaximumSumOfDistinctSubarraysWithLengthK;

public abstract class MaximumSumOfDistinctSubarraysWithLengthKTestsBase<T> where T : IMaximumSumOfDistinctSubarraysWithLengthK, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 5, 4, 2, 9, 9, 9 }, 3, 15L)]
    [DataRow(new[] { 4, 4, 4 }, 3, 0L)]
    [DataRow(new[] { 1 }, 1, 1L)]
    [DataRow(new[] { 5, 5 }, 1, 5L)]
    [DataRow(new[] { 5, 5 }, 2, 0L)]
    [DataRow(new[] { 1, 2 }, 2, 3L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 15L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, 12L)]
    [DataRow(new[] { 9, 9, 9, 1, 2, 3 }, 3, 12L)]
    [DataRow(new[] { 1, 1, 1, 1 }, 1, 1L)]
    [DataRow(new[] { 100000, 99999, 100000 }, 2, 199999L)]
    [DataRow(new[] { 100000, 99999, 100000 }, 3, 0L)]
    [DataRow(new[] { 1, 2, 1, 2, 3 }, 3, 6L)]
    [DataRow(new[] { 4, 3, 2, 1, 4, 3, 2, 1 }, 4, 10L)]
    [DataRow(new[] { 2, 2, 3, 3, 4, 4 }, 2, 7L)]
    [DataRow(new[] { 10, 20, 30, 10, 20, 30 }, 3, 60L)]
    [DataRow(new[] { 7, 8, 9, 7, 8, 9, 10 }, 4, 34L)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 4, 0L)]
    [DataRow(new[] { 100000, 100000, 100000, 100000, 100000 }, 1, 100000L)]
    [DataRow(new[] { 1, 3, 5, 7, 9, 11, 13 }, 7, 49L)]
    public void MaximumSubarraySum_WithArrayAndWindowSize_ReturnsMaximumSubarraySum(int[] nums, int k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumSubarraySum(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}