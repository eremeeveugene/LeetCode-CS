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

using LeetCode.Algorithms.SubarrayProductLessThanK;

namespace LeetCode.Tests.Algorithms.SubarrayProductLessThanK;

public abstract class SubarrayProductLessThanKTestsBase<T> where T : ISubarrayProductLessThanK, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 5, 2, 6 }, 100, 8)]
    [DataRow(new[] { 1, 2, 3 }, 0, 0)]
    [DataRow(new[] { 1, 1, 1 }, 2, 6)]
    [DataRow(new[] { 1 }, 2, 1)]
    [DataRow(new[] { 1 }, 1, 0)]
    [DataRow(new[] { 5 }, 5, 0)]
    [DataRow(new[] { 5 }, 6, 1)]
    [DataRow(new[] { 1000 }, 1000000, 1)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 2, 15)]
    [DataRow(new[] { 2, 3, 4 }, 25, 6)]
    [DataRow(new[] { 2, 3, 4 }, 24, 5)]
    [DataRow(new[] { 10, 5, 2, 6 }, 1, 0)]
    [DataRow(new[] { 10, 5, 2, 6 }, 1000, 10)]
    [DataRow(new[] { 100, 100, 100 }, 1000000, 5)]
    [DataRow(new[] { 1000, 1000 }, 1000000, 2)]
    [DataRow(new[] { 1000, 999, 1 }, 1000000, 6)]
    [DataRow(new[] { 3, 3, 3, 3, 3, 3 }, 10, 11)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 100, 17)]
    [DataRow(new[] { 7, 1, 1, 7, 1 }, 8, 13)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }, 1000000, 190)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 4, 13)]
    [DataRow(new[] { 8, 2, 5, 4 }, 10, 4)]
    public void NumSubarrayProductLessThanK_GivenArrayAndThreshold_ReturnsCount(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSubarrayProductLessThanK(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}