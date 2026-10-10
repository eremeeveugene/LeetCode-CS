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

using LeetCode.Algorithms.TargetSum;

namespace LeetCode.Tests.Algorithms.TargetSum;

public abstract class TargetSumTestsBase<T> where T : ITargetSum, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1, 0 }, 1, 2)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 3, 5)]
    [DataRow(new[] { 2, 1, 3, 2, 1, 3, 3 }, 9, 7)]
    [DataRow(new[] { 100, 100 }, -300, 0)]
    [DataRow(new[] { 12, 25, 42, 49, 41, 15, 22, 34, 28, 31 }, 35, 8)]
    [DataRow(new[] { 3, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 2, 7, 9, 13, 27, 31, 37, 47, 53 }, 107, 0)]
    [DataRow(new[] { 3, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 2, 107, 109, 113, 127, 131, 137, 47, 53 }, 4, 2780)]
    [DataRow(new[] { 0 }, 0, 2)]
    [DataRow(new[] { 0, 0, 0 }, 0, 8)]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 0, 32)]
    [DataRow(new[] { 1, 2 }, 3, 1)]
    [DataRow(new[] { 1, 2 }, 4, 0)]
    [DataRow(new[] { 5 }, -5, 1)]
    [DataRow(new[] { 1000 }, 1000, 1)]
    [DataRow(new[] { 1000 }, -1000, 1)]
    [DataRow(new[] { 1000 }, 0, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, -15, 1)]
    [DataRow(new[] { 7, 9, 3, 8, 0, 2, 4, 8, 3, 9 }, 0, 0)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 0, 184756)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 20, 1)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 2, 167960)]
    [DataRow(new[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 }, 0, 184756)]
    [DataRow(new[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 }, -100, 167960)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, 10, 40)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0, 1048576)]
    [DataRow(new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 }, 1, 24)]
    [DataRow(new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71 }, 5, 4696)]
    public void FindTargetSumWays_WithJsonAndTarget_ReturnsNumberOfWaysToAchieveTarget(int[] nums, int target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindTargetSumWays(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}