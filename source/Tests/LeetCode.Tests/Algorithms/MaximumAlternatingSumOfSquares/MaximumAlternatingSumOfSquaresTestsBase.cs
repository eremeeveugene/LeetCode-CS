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

using LeetCode.Algorithms.MaximumAlternatingSumOfSquares;

namespace LeetCode.Tests.Algorithms.MaximumAlternatingSumOfSquares;

public abstract class MaximumAlternatingSumOfSquaresTestsBase<T> where T : IMaximumAlternatingSumOfSquares, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 12L)]
    [DataRow(new[] { 1, -1, 2, -2, 3, -3 }, 16L)]
    [DataRow(new[] { 5 }, 25L)]
    [DataRow(new[] { -5 }, 25L)]
    [DataRow(new[] { 0 }, 0L)]
    [DataRow(new[] { 1, 1 }, 0L)]
    [DataRow(new[] { 3, 4 }, 7L)]
    [DataRow(new[] { -3, 4 }, 7L)]
    [DataRow(new[] { 0, 0, 0 }, 0L)]
    [DataRow(new[] { 2, -2, 2 }, 4L)]
    [DataRow(new[] { 1, 2, 3, 4 }, 20L)]
    [DataRow(new[] { -1, -2, -3, -4, -5 }, 45L)]
    [DataRow(new[] { 40000 }, 1600000000L)]
    [DataRow(new[] { -40000, 40000 }, 0L)]
    [DataRow(new[] { 40000, -40000, 0 }, 3200000000L)]
    [DataRow(new[] { 0, 10 }, 100L)]
    [DataRow(new[] { 7, -3, 0, 2 }, 54L)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 63L)]
    [DataRow(new[] { -10, 5, -1 }, 124L)]
    [DataRow(new[] { 6, -6, 6, -6 }, 0L)]
    [DataRow(new[] { 2, 3, 5, 7, 11 }, 182L)]
    [DataRow(new[] { -4, 1, -9, 0, 3, 2, 8 }, 165L)]
    [DataRow(new[] { 100, -200, 300 }, 120000L)]
    public void MaxAlternatingSum_WithInputNums_ReturnsMaximumAlternatingSum(int[] nums, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxAlternatingSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}