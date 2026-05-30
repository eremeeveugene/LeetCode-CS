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
    public void CountSubarrays_WithPositiveIntArrayAndScoreThreshold_ReturnsNumberOfSubarraysWithScoreLessThanK(int[] nums, long k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}