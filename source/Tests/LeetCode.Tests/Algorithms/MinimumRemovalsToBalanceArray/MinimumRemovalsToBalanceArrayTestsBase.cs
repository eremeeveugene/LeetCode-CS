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

using LeetCode.Algorithms.MinimumRemovalsToBalanceArray;

namespace LeetCode.Tests.Algorithms.MinimumRemovalsToBalanceArray;

public abstract class MinimumRemovalsToBalanceArrayTestsBase<T> where T : IMinimumRemovalsToBalanceArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 5 }, 2, 1)]
    [DataRow(new[] { 1, 6, 2, 9 }, 3, 2)]
    [DataRow(new[] { 4, 6 }, 2, 0)]
    [DataRow(new[] { 1 }, 1, 0)]
    [DataRow(new[] { 7 }, 100000, 0)]
    [DataRow(new[] { 1, 1, 1, 1 }, 1, 0)]
    [DataRow(new[] { 1, 2 }, 1, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 0)]
    [DataRow(new[] { 1000000000, 1 }, 1, 1)]
    [DataRow(new[] { 1, 1000000000 }, 100000, 1)]
    [DataRow(new[] { 1000000000, 1, 1000000000 }, 100000, 1)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 1, 0)]
    [DataRow(new[] { 10, 4, 2, 1 }, 2, 2)]
    [DataRow(new[] { 10, 4, 2, 1 }, 10, 0)]
    [DataRow(new[] { 3, 6, 12, 24 }, 2, 2)]
    [DataRow(new[] { 3, 6, 12, 24 }, 4, 1)]
    [DataRow(new[] { 3, 6, 12, 24 }, 8, 0)]
    [DataRow(new[] { 2, 2, 2, 3 }, 1, 1)]
    [DataRow(new[] { 100, 1, 100, 1, 100 }, 1, 2)]
    [DataRow(new[] { 1, 3, 5, 7, 9, 11 }, 3, 2)]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, 2, 0)]
    [DataRow(new[] { 1, 100000 }, 100000, 0)]
    [DataRow(new[] { 1, 100001 }, 100000, 1)]
    public void MinRemoval_WithNumsAndK_ReturnsMinimumNumberOfRemovals(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinRemoval(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}