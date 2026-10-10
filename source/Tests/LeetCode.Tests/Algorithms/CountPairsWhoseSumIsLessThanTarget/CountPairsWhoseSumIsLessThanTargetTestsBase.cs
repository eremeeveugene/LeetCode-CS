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

using LeetCode.Algorithms.CountPairsWhoseSumIsLessThanTarget;

namespace LeetCode.Tests.Algorithms.CountPairsWhoseSumIsLessThanTarget;

public abstract class CountPairsWhoseSumIsLessThanTargetTestsBase<T> where T : ICountPairsWhoseSumIsLessThanTarget, new()
{
    [TestMethod]
    [DataRow(new[] { -1, 1, 2, 3, 1 }, 2, 3)]
    [DataRow(new[] { -6, 2, 5, -2, -7, -1, 3 }, -2, 10)]
    [DataRow(new[] { 1 }, 5, 0)]
    [DataRow(new[] { 1, 2 }, 3, 0)]
    [DataRow(new[] { 1, 2 }, 4, 1)]
    [DataRow(new[] { -50, -50 }, -100, 0)]
    [DataRow(new[] { -50, -50 }, -99, 1)]
    [DataRow(new[] { 50, 50 }, 100, 0)]
    [DataRow(new[] { 50, 50 }, 101, 1)]
    [DataRow(new[] { 0, 0, 0 }, 0, 0)]
    [DataRow(new[] { 0, 0, 0 }, 1, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 6, 4)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 6, 4)]
    [DataRow(new[] { -3, -2, -1, 0, 1, 2, 3 }, 0, 9)]
    [DataRow(new[] { 10, -10, 20, -20 }, 0, 2)]
    [DataRow(new[] { 7, 7, 7, 7 }, 14, 0)]
    [DataRow(new[] { 7, 7, 7, 7 }, 15, 6)]
    [DataRow(new[] { -1, -1, -1 }, -1, 3)]
    [DataRow(new[] { 1, -1, 2, -2, 3, -3 }, 100, 15)]
    [DataRow(new[] { 1, -1, 2, -2, 3, -3 }, -100, 0)]
    public void CountPairs_WithArrayAndTarget_ReturnsNumberOfPairsWithSumLessThanTarget(int[] nums, int target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountPairs(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}