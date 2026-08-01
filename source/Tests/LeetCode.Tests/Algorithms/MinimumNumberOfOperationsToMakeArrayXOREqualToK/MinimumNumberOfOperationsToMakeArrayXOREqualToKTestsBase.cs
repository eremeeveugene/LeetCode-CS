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

using LeetCode.Algorithms.MinimumNumberOfOperationsToMakeArrayXOREqualToK;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfOperationsToMakeArrayXOREqualToK;

public abstract class MinimumNumberOfOperationsToMakeArrayXOREqualToKTestsBase<T> where T : IMinimumNumberOfOperationsToMakeArrayXOREqualToK, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 3, 4 }, 1, 2)]
    [DataRow(new[] { 2, 0, 2, 0 }, 0, 0)]
    [DataRow(new[] { 1 }, 4, 2)]
    [DataRow(new[] { 1, 2, 3 }, 0, 0)]
    [DataRow(new[] { 1, 2, 3 }, 1, 1)]
    [DataRow(new[] { 4, 4 }, 4, 1)]
    [DataRow(new[] { 4, 4 }, 0, 0)]
    [DataRow(new[] { 5 }, 5, 0)]
    [DataRow(new[] { 5 }, 2, 3)]
    [DataRow(new[] { 7 }, 0, 3)]
    [DataRow(new[] { 0 }, 0, 0)]
    [DataRow(new[] { 0 }, 7, 3)]
    [DataRow(new[] { 3, 5 }, 6, 0)]
    [DataRow(new[] { 3, 5 }, 0, 2)]
    [DataRow(new[] { 8, 8, 8 }, 8, 0)]
    [DataRow(new[] { 8, 8, 8 }, 0, 1)]
    [DataRow(new[] { 1, 1, 1 }, 1, 0)]
    [DataRow(new[] { 2, 3 }, 1, 0)]
    [DataRow(new[] { 2, 3 }, 2, 2)]
    [DataRow(new[] { 10, 20 }, 30, 0)]
    [DataRow(new[] { 10, 20 }, 0, 4)]
    [DataRow(new[] { 6 }, 1, 3)]
    [DataRow(new[] { 15 }, 15, 0)]
    [DataRow(new[] { 15 }, 0, 4)]
    [DataRow(new[] { 1, 2, 4, 8 }, 15, 0)]
    [DataRow(new[] { 1, 2, 4, 8 }, 0, 4)]
    public void MinOperations_WithNumsArrayAndK_ReturnsMinOperationsCount(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}