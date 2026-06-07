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

using LeetCode.Algorithms.MaximumNumberOfDistinctElementsAfterOperations;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfDistinctElementsAfterOperations;

public abstract class MaximumNumberOfDistinctElementsAfterOperationsTestsBase<T> where T : IMaximumNumberOfDistinctElementsAfterOperations, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 3, 3, 4 }, 2, 6)]
    [DataRow(new[] { 4, 4, 4, 4 }, 1, 3)]
    [DataRow(new[] { 1 }, 0, 1)]
    [DataRow(new[] { 5 }, 3, 1)]
    [DataRow(new[] { 1, 1 }, 0, 1)]
    [DataRow(new[] { 1, 2 }, 0, 2)]
    [DataRow(new[] { 1, 1, 1 }, 1, 3)]
    [DataRow(new[] { 1, 2, 3 }, 1, 3)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, 4)]
    [DataRow(new[] { 1, 2, 2, 2 }, 1, 4)]
    [DataRow(new[] { 3, 3, 3 }, 0, 1)]
    [DataRow(new[] { 1, 3, 5, 7 }, 1, 4)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 1, 5)]
    [DataRow(new[] { 10, 10, 10 }, 5, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0, 5)]
    [DataRow(new[] { 5, 5 }, 1, 2)]
    [DataRow(new[] { 1, 100 }, 0, 2)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 3, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 2, 6)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2 }, 3, 6)]
    public void MaxDistinctElements_WithNumsAndAdjustmentLimit_ReturnsMaximumDistinctCount(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDistinctElements(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}