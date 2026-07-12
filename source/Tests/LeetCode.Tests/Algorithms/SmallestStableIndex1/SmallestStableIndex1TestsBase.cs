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

using LeetCode.Algorithms.SmallestStableIndex1;

namespace LeetCode.Tests.Algorithms.SmallestStableIndex1;

public abstract class SmallestStableIndex1TestsBase<T> where T : ISmallestStableIndex1, new()
{
    [TestMethod]
    [DataRow(new[] { 0 }, 0, 0)]
    [DataRow(new[] { 5, 0, 1, 4 }, 3, 3)]
    [DataRow(new[] { 3, 2, 1 }, 1, -1)]
    [DataRow(new[] { 1 }, 0, 0)]
    [DataRow(new[] { 1 }, 1, 0)]
    [DataRow(new[] { 1, 1 }, 0, 0)]
    [DataRow(new[] { 1, 2 }, 0, 0)]
    [DataRow(new[] { 2, 1 }, 0, -1)]
    [DataRow(new[] { 1, 2, 3 }, 0, 0)]
    [DataRow(new[] { 3, 2, 1 }, 2, 0)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 3, -1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0, 0)]
    [DataRow(new[] { 2, 2, 2, 2 }, 0, 0)]
    [DataRow(new[] { 0, 1_000_000_000 }, 0, 0)]
    [DataRow(new[] { 1_000_000_000, 0 }, 1_000_000_000, 0)]
    [DataRow(new[] { 10, 1, 10, 1, 10 }, 0, 4)]
    [DataRow(new[] { 4, 1, 2, 3 }, 1, 3)]
    [DataRow(new[] { 4, 1, 2, 3 }, 0, -1)]
    [DataRow(new[] { 7, 0, 5, 6 }, 2, 2)]
    [DataRow(new[] { 2, 0, 2, 0, 2 }, 2, 0)]
    public void FirstStableIndex_WithGivenArrayAndThreshold_ReturnsSmallestStableIndexOrNegativeOneWhenNoStableIndexExists(
        int[] nums,
        int k,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FirstStableIndex(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}