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

using LeetCode.Algorithms.MinimumOperationsToMakeArrayValuesEqualToK;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeArrayValuesEqualToK;

public abstract class MinimumOperationsToMakeArrayValuesEqualToKTestsBase<T> where T : IMinimumOperationsToMakeArrayValuesEqualToK, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 2, 5, 4, 5 }, 2, 2)]
    [DataRow(new[] { 2, 1, 2 }, 2, -1)]
    [DataRow(new[] { 9, 7, 5, 3 }, 1, 4)]
    [DataRow(new[] { 1 }, 1, 0)]
    [DataRow(new[] { 100 }, 1, 1)]
    [DataRow(new[] { 100 }, 100, 0)]
    [DataRow(new[] { 1, 2 }, 2, -1)]
    [DataRow(new[] { 5, 5, 5 }, 5, 0)]
    [DataRow(new[] { 5, 5, 5 }, 4, 1)]
    [DataRow(new[] { 100, 99, 98, 97 }, 1, 4)]
    [DataRow(new[] { 100, 100, 100, 100, 100 }, 99, 1)]
    [DataRow(new[] { 3, 2, 1 }, 2, -1)]
    [DataRow(new[] { 50, 100, 50, 100 }, 50, 1)]
    [DataRow(new[] { 2, 3, 4, 5 }, 2, 3)]
    [DataRow(new[] { 2, 100 }, 100, -1)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, 10, 9)]
    [DataRow(new[] { 1, 1, 1, 1 }, 1, 0)]
    [DataRow(new[] { 100, 100, 1 }, 2, -1)]
    [DataRow(new[] { 99, 100 }, 99, 1)]
    [DataRow(new[] { 7 }, 8, -1)]
    [DataRow(new[] { 1, 4, 7 }, 12, -1)]
    [DataRow(new[] { 10, 1 }, 2, -1)]
    [DataRow(new[] { 4, 4, 6, 1, 2, 3, 9, 1, 9, 2 }, 10, -1)]
    [DataRow(new[] { 9, 4, 7, 2, 7, 4, 11, 2 }, 12, -1)]
    [DataRow(new[] { 3, 3, 10, 12, 1, 1, 5, 9, 11, 10 }, 3, -1)]
    public void MinOperations_WithArrayAndTargetK_ReturnsMinimumStepsOrMinusOne(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}