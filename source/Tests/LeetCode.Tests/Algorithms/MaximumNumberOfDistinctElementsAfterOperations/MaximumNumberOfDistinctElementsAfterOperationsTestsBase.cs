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