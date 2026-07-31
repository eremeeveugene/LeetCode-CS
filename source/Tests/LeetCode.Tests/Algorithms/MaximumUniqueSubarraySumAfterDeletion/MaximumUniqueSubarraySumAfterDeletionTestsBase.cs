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

using LeetCode.Algorithms.MaximumUniqueSubarraySumAfterDeletion;

namespace LeetCode.Tests.Algorithms.MaximumUniqueSubarraySumAfterDeletion;

public abstract class MaximumUniqueSubarraySumAfterDeletionTestsBase<T> where T : IMaximumUniqueSubarraySumAfterDeletion, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 15)]
    [DataRow(new[] { 1, 1, 0, 1, 1 }, 1)]
    [DataRow(new[] { 1, 2, -1, -2, 1, 0, -1 }, 3)]
    [DataRow(new[] { -5, -1, -3 }, -1)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { -1 }, -1)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 1, 1, 1, 1 }, 1)]
    [DataRow(new[] { 5, 5, 5, 5 }, 5)]
    [DataRow(new[] { -1, -2, -3, -4 }, -1)]
    [DataRow(new[] { 10, 20, 30 }, 60)]
    [DataRow(new[] { 10, 10, 20, 20, 30 }, 60)]
    [DataRow(new[] { -100, -1, -50 }, -1)]
    [DataRow(new[] { 1, -1, 2, -2, 3, -3 }, 6)]
    [DataRow(new[] { 100 }, 100)]
    [DataRow(new[] { -100 }, -100)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3 }, 6)]
    [DataRow(new[] { 0, 1, 2, 3 }, 6)]
    [DataRow(new[] { 0, -1, -2 }, 0)]
    [DataRow(new[] { 7, 7, 7, 7, 7, 7 }, 7)]
    [DataRow(new[] { -1, 0, 1 }, 1)]
    [DataRow(new[] { 2, 4, 6, 8, 10 }, 30)]
    [DataRow(new[] { -10, -20, -30, -5 }, -5)]
    [DataRow(new[] { 1, 2, 3, -100, 4, 5 }, 15)]
    public void MaxSum_WithIntegerArray_ReturnsMaximumSubarraySum(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}