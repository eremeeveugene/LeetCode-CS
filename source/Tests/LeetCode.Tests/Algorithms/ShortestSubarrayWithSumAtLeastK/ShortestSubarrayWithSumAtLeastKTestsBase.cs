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

using LeetCode.Algorithms.ShortestSubarrayWithSumAtLeastK;

namespace LeetCode.Tests.Algorithms.ShortestSubarrayWithSumAtLeastK;

public abstract class ShortestSubarrayWithSumAtLeastKTestsBase<T> where T : IShortestSubarrayWithSumAtLeastK, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1, 2 }, 4, -1)]
    [DataRow(new[] { 2, -1, 2 }, 3, 3)]
    [DataRow(new[] { 84, -37, 32, 40, 95 }, 167, 3)]
    [DataRow(new[] { -28, 81, -20, 28, -29 }, 89, 3)]
    [DataRow(new[] { 5 }, 5, 1)]
    [DataRow(new[] { 5 }, 6, -1)]
    [DataRow(new[] { -1 }, 1, -1)]
    [DataRow(new[] { 1, 1, 1, 1 }, 3, 3)]
    [DataRow(new[] { 1, 1, 1, 1 }, 5, -1)]
    [DataRow(new[] { -1, -1, 5 }, 5, 1)]
    [DataRow(new[] { 100000, -100000, 100000 }, 100000, 1)]
    [DataRow(new[] { 100000, 100000, 100000 }, 1000000000, -1)]
    [DataRow(new[] { 2, -1, 2, -1, 2 }, 3, 3)]
    [DataRow(new[] { -5, -5, -5 }, 1, -1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 15, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 9, 2)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 9, 2)]
    [DataRow(new[] { 10, -20, 30, -5, 40 }, 45, 3)]
    [DataRow(new[] { 48, 99, 37, 4, -31 }, 140, 2)]
    [DataRow(new[] { 1, -1, 1, -1, 1, -1, 10 }, 10, 1)]
    [DataRow(new[] { 3, 3, 3, 3 }, 1, 1)]
    [DataRow(new[] { -4, 8, 4, -7, -9 }, 5, 1)]
    [DataRow(new[] { -2, -6, -5, 0, -8, -5, -8 }, 12, -1)]
    [DataRow(new[] { -4, 9, -10, 5, 0, -2, 10, -5, -6, -9, -1 }, 11, 4)]
    public void ShortestSubarray_WithGivenArrayAndTargetSum_ReturnsLengthOfShortestValidSubarrayOrMinusOne(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ShortestSubarray(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}