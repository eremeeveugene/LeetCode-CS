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

using LeetCode.Algorithms.FindMinimumOperationsToMakeAllElementsDivisibleByThree;

namespace LeetCode.Tests.Algorithms.FindMinimumOperationsToMakeAllElementsDivisibleByThree;

public abstract class FindMinimumOperationsToMakeAllElementsDivisibleByThreeTestsBase<T>
    where T : IFindMinimumOperationsToMakeAllElementsDivisibleByThree, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 3)]
    [DataRow(new[] { 3, 6, 9 }, 0)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 3 }, 0)]
    [DataRow(new[] { 2 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 3)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 4, 5, 6, 7 }, 3)]
    [DataRow(new[] { 9, 9, 9, 9 }, 0)]
    [DataRow(new[] { 50, 49, 48 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 7)]
    [DataRow(new[] { 43, 14, 28, 39, 35, 4, 9 }, 5)]
    [DataRow(new[] { 3, 47, 44, 40, 33, 11, 41, 28, 16, 48, 27, 46, 13, 45, 2, 43 }, 11)]
    [DataRow(new[] { 10, 9, 14, 39, 31, 49, 25, 24 }, 5)]
    [DataRow(new[] { 38, 2, 2, 48, 19, 35, 35, 8 }, 7)]
    [DataRow(new[] { 3, 42, 1, 30, 39, 43, 36, 21, 21, 43, 28, 28, 45, 13, 4, 17, 13 }, 9)]
    [DataRow(new[] { 25, 28, 39, 34, 10, 4, 7, 5, 9, 35, 36, 46, 50, 3, 4, 27, 14, 24, 39, 50 }, 13)]
    [DataRow(new[] { 35, 21, 7 }, 2)]
    [DataRow(new[] { 3, 27, 46, 30, 38, 5, 3, 23, 7, 44, 16, 6, 9, 44 }, 8)]
    [DataRow(new[] { 23, 49, 39, 50, 44, 45, 28, 23, 34 }, 7)]
    public void MinimumOperations_WithGivenNums_ReturnsMinimumOperationsCount(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumOperations(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}