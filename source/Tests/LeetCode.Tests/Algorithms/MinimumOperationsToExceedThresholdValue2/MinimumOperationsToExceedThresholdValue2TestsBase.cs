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

using LeetCode.Algorithms.MinimumOperationsToExceedThresholdValue2;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToExceedThresholdValue2;

public abstract class MinimumOperationsToExceedThresholdValue2TestsBase<T> where T : IMinimumOperationsToExceedThresholdValue2, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 11, 10, 1, 3 }, 10, 2)]
    [DataRow(new[] { 1, 1, 2, 4, 9 }, 20, 4)]
    [DataRow(new[] { 1, 1 }, 2, 1)]
    [DataRow(new[] { 1, 2 }, 3, 1)]
    [DataRow(new[] { 1, 2 }, 4, 1)]
    [DataRow(new[] { 1, 1, 1 }, 5, 2)]
    [DataRow(new[] { 10, 10, 10 }, 10, 0)]
    [DataRow(new[] { 999999999, 1000000000 }, 1000000000, 1)]
    [DataRow(new[] { 1, 1000000000 }, 1000000000, 1)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 8, 6)]
    [DataRow(new[] { 3, 3, 3, 3 }, 20, 3)]
    [DataRow(new[] { 1000000000, 1000000000 }, 1000000000, 0)]
    [DataRow(new[] { 2, 3, 4, 5, 6 }, 30, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 100, 9)]
    [DataRow(new[] { 7, 7, 7, 7, 7, 7 }, 50, 5)]
    [DataRow(new[] { 12, 13, 5, 7, 2 }, 3, 1)]
    [DataRow(new[] { 16, 13, 4, 9, 4, 3, 13, 20 }, 14, 4)]
    [DataRow(new[] { 17, 20, 7, 10, 5, 12, 17, 10, 17 }, 10, 1)]
    [DataRow(new[] { 12, 8, 1, 10, 11 }, 9, 1)]
    [DataRow(new[] { 6, 13, 4, 6, 1, 7, 6, 10 }, 1, 0)]
    [DataRow(new[] { 5, 17, 16, 5, 20, 3, 7 }, 5, 1)]
    [DataRow(new[] { 13, 19, 4, 10, 12, 11, 12 }, 16, 3)]
    public void MinOperations_WithTargetSum_ReturnsMinimumOperations(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}