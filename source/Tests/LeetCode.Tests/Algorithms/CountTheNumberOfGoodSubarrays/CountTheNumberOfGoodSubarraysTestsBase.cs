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

using LeetCode.Algorithms.CountTheNumberOfGoodSubarrays;

namespace LeetCode.Tests.Algorithms.CountTheNumberOfGoodSubarrays;

public abstract class CountTheNumberOfGoodSubarraysTestsBase<T> where T : ICountTheNumberOfGoodSubarrays, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 10, 1L)]
    [DataRow(new[] { 3, 1, 4, 3, 2, 2, 4 }, 2, 4L)]
    [DataRow(new[] { 1 }, 1, 0L)]
    [DataRow(new[] { 1, 1 }, 1, 1L)]
    [DataRow(new[] { 1, 1 }, 2, 0L)]
    [DataRow(new[] { 1, 2, 3 }, 1, 0L)]
    [DataRow(new[] { 1, 1, 1 }, 1, 3L)]
    [DataRow(new[] { 1, 1, 1 }, 3, 1L)]
    [DataRow(new[] { 1, 1, 1 }, 2, 1L)]
    [DataRow(new[] { 2, 2, 2, 2 }, 3, 3L)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 2, 3L)]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5 }, 6, 6L)]
    [DataRow(new[] { 1000000000, 1000000000 }, 1, 1L)]
    [DataRow(new[] { 1, 2, 3, 4 }, 1000000000, 0L)]
    [DataRow(new[] { 1, 2, 1, 2 }, 2, 1L)]
    [DataRow(new[] { 3, 3, 4, 4, 3, 3 }, 3, 3L)]
    [DataRow(new[] { 7, 8, 7, 8, 7, 8, 7 }, 4, 6L)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 2, 5L)]
    [DataRow(new[] { 4, 1, 4, 1, 4 }, 1, 6L)]
    [DataRow(new[] { 9, 9, 9, 1, 9 }, 4, 1L)]
    public void CountGood_WithIntegerArrayAndK_ReturnsNumberOfGoodPairs(int[] nums, int k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountGood(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}