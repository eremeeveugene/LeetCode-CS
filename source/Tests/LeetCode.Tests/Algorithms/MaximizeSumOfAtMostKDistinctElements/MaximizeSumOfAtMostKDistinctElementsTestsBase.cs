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

using LeetCode.Algorithms.MaximizeSumOfAtMostKDistinctElements;

namespace LeetCode.Tests.Algorithms.MaximizeSumOfAtMostKDistinctElements;

public abstract class MaximizeSumOfAtMostKDistinctElementsTestsBase<T>
    where T : IMaximizeSumOfAtMostKDistinctElements, new()
{
    [TestMethod]
    [DataRow(new[] { 84, 93, 100, 77, 90 }, 3, new[] { 100, 93, 90 })]
    [DataRow(new[] { 84, 93, 100, 77, 93 }, 3, new[] { 100, 93, 84 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2 }, 6, new[] { 2, 1 })]
    public void MaxKDistinct_WithNumsArrayAndLimitK_ReturnsKOrFewerDistinctNumbersWithMaxSumInDescendingOrder(
        int[] nums, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxKDistinct(nums, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}