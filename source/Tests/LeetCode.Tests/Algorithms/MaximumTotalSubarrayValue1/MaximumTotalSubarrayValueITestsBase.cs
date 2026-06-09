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

using LeetCode.Algorithms.MaximumTotalSubarrayValue1;

namespace LeetCode.Tests.Algorithms.MaximumTotalSubarrayValue1;

public abstract class MaximumTotalSubarrayValueITestsBase<T> where T : IMaximumTotalSubarrayValue1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 2 }, 2, 4L)]
    [DataRow(new[] { 4, 2, 5, 1 }, 3, 12L)]
    [DataRow(new[] { 1 }, 1, 0L)]
    [DataRow(new[] { 5 }, 5, 0L)]
    [DataRow(new[] { 7 }, 100000, 0L)]
    [DataRow(new[] { 1, 2 }, 1, 1L)]
    [DataRow(new[] { 1, 2 }, 10, 10L)]
    [DataRow(new[] { 2, 1 }, 5, 5L)]
    [DataRow(new[] { 5, 5, 5 }, 3, 0L)]
    [DataRow(new[] { 0, 0, 0, 0 }, 100, 0L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 4L)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 1, 4L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 20L)]
    [DataRow(new[] { 1000000000, 0 }, 1, 1000000000L)]
    [DataRow(new[] { 1000000000, 0 }, 100000, 100000000000000L)]
    [DataRow(new[] { 10, 20, 30 }, 2, 40L)]
    [DataRow(new[] { 100, 1, 50 }, 3, 297L)]
    [DataRow(new[] { 7, 7, 7, 1, 7 }, 4, 24L)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 2, 16L)]
    [DataRow(new[] { 0, 1000000000 }, 100000, 100000000000000L)]
    [DataRow(new[] { 42 }, 100000, 0L)]
    [DataRow(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, 3, 63L)]
    [DataRow(new[] { 1, 0 }, 1, 1L)]
    public void MaxTotalValue_WithGivenNumsAndK_ReturnsMaximumTotalValueOfChosenSubarrays(int[] nums, int k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxTotalValue(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}