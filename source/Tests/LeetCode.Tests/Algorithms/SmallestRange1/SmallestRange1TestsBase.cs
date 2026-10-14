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

using LeetCode.Algorithms.SmallestRange1;

namespace LeetCode.Tests.Algorithms.SmallestRange1;

public abstract class SmallestRange1TestsBase<T> where T : ISmallestRange1, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 0, 0)]
    [DataRow(new[] { 0, 10 }, 2, 6)]
    [DataRow(new[] { 1, 3, 6 }, 3, 0)]
    [DataRow(new[] { 0 }, 0, 0)]
    [DataRow(new[] { 5 }, 10000, 0)]
    [DataRow(new[] { 0, 10000 }, 0, 10000)]
    [DataRow(new[] { 0, 10000 }, 10000, 0)]
    [DataRow(new[] { 0, 10000 }, 4999, 2)]
    [DataRow(new[] { 0, 10000 }, 5000, 0)]
    [DataRow(new[] { 10000, 10000 }, 0, 0)]
    [DataRow(new[] { 3, 3, 3 }, 5, 0)]
    [DataRow(new[] { 1, 2 }, 0, 1)]
    [DataRow(new[] { 2, 1 }, 1, 0)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5 }, 1, 3)]
    [DataRow(new[] { 9, 0, 4 }, 2, 5)]
    [DataRow(new[] { 7, 7, 8 }, 0, 1)]
    [DataRow(new[] { 100, 200, 300, 400 }, 50, 200)]
    [DataRow(new[] { 100, 200, 300, 400 }, 49, 202)]
    [DataRow(new[] { 5, 5 }, 10000, 0)]
    [DataRow(new[] { 8, 1, 6, 3 }, 1, 5)]
    public void SmallestRangeI_WithArrayAndAdjustmentLimit_ReturnsMinimumPossibleScore(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestRangeI(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}