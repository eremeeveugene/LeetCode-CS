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

public abstract class MaximizeSumOfAtMostKDistinctElementsTestsBase<T> where T : IMaximizeSumOfAtMostKDistinctElements, new()
{
    [TestMethod]
    [DataRow(new[] { 84, 93, 100, 77, 90 }, 3, new[] { 100, 93, 90 })]
    [DataRow(new[] { 84, 93, 100, 77, 93 }, 3, new[] { 100, 93, 84 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2 }, 6, new[] { 2, 1 })]
    [DataRow(new[] { 5 }, 1, new[] { 5 })]
    [DataRow(new[] { 5 }, 3, new[] { 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 5, 4 })]
    [DataRow(new[] { 5, 5, 5, 5 }, 2, new[] { 5 })]
    [DataRow(new[] { 100, 100, 1 }, 2, new[] { 100, 1 })]
    [DataRow(new[] { 1, 100 }, 1, new[] { 100 })]
    [DataRow(new[] { 3, 3, 2, 2, 1, 1 }, 3, new[] { 3, 2, 1 })]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 4, new[] { 10, 9, 8, 7 })]
    [DataRow(new[] { 7, 7, 7, 8, 8, 9 }, 2, new[] { 9, 8 })]
    [DataRow(new[] { 2, 1 }, 2, new[] { 2, 1 })]
    [DataRow(new[] { 50, 40, 50, 40, 30 }, 3, new[] { 50, 40, 30 })]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 5, new[] { 1 })]
    [DataRow(new[] { 6, 4, 6, 4, 8, 8 }, 2, new[] { 8, 6 })]
    [DataRow(new[] { 99, 98, 97, 96, 95, 94 }, 6, new[] { 99, 98, 97, 96, 95, 94 })]
    [DataRow(new[] { 1, 2 }, 1, new[] { 2 })]
    [DataRow(new[] { 18, 73, 98, 9, 33, 16, 64, 98, 58, 61, 84, 49, 27, 13, 63, 4, 50, 56, 78, 98, 99, 1, 90, 58, 35, 93, 30, 76, 14, 41 }, 7, new[] { 99, 98, 93, 90, 84, 78, 76 })]
    public void MaxKDistinct_WithNumsArrayAndLimitK_ReturnsKOrFewerDistinctNumbersWithMaxSumInDescendingOrder(int[] nums, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxKDistinct(nums, k);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}