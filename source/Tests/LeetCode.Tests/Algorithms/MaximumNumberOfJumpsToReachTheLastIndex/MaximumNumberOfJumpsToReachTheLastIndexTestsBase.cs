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

using LeetCode.Algorithms.MaximumNumberOfJumpsToReachTheLastIndex;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfJumpsToReachTheLastIndex;

public abstract class MaximumNumberOfJumpsToReachTheLastIndexTestsBase<T> where T : IMaximumNumberOfJumpsToReachTheLastIndex, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 6, 4, 1, 2 }, 2, 3)]
    [DataRow(new[] { 1, 3, 6, 4, 1, 2 }, 3, 5)]
    [DataRow(new[] { 1, 3, 6, 4, 1, 2 }, 0, -1)]
    [DataRow(new[] { 1, 2 }, 1, 1)]
    [DataRow(new[] { 1, 2 }, 0, -1)]
    [DataRow(new[] { 5, 5 }, 0, 1)]
    [DataRow(new[] { 5, 5, 5, 5 }, 0, 3)]
    [DataRow(new[] { 1, 10, 20 }, 100, 2)]
    [DataRow(new[] { 1, 10, 20 }, 5, -1)]
    [DataRow(new[] { 10, 7, 4, 1 }, 3, 3)]
    [DataRow(new[] { 10, 6, 2 }, 3, -1)]
    [DataRow(new[] { -5, -3, -1, 1 }, 2, 3)]
    [DataRow(new[] { -5, 0, 5 }, 5, 2)]
    [DataRow(new[] { -5, 0, 6 }, 5, -1)]
    [DataRow(new[] { 1, 4, 2, 5, 3 }, 2, 2)]
    [DataRow(new[] { 1, 100, 2, 3, 4 }, 2, 3)]
    [DataRow(new[] { 1, 100, 101, 102 }, 1, -1)]
    [DataRow(new[] { 1, 100, 2, 100, 3 }, 1, 2)]
    [DataRow(new[] { 0, -1, -2, -3, -4 }, 1, 4)]
    [DataRow(new[] { 0, 2, 4, 6, 8 }, 2, 4)]
    [DataRow(new[] { 0, 3, 6, 9 }, 2, -1)]
    [DataRow(new[] { 1_000_000_000, 0, -1_000_000_000 }, 2_000_000_000, 2)]
    public void MaximumJumps_WithGivenNums_ReturnsMaximumJumpsOrMinusOne(int[] nums, int target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumJumps(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}