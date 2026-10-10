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

using LeetCode.Algorithms.FindSubsequenceOfLengthKWithTheLargestSum;

namespace LeetCode.Tests.Algorithms.FindSubsequenceOfLengthKWithTheLargestSum;

public abstract class FindSubsequenceOfLengthKWithTheLargestSumTestsBase<T> where T : IFindSubsequenceOfLengthKWithTheLargestSum, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 3, 3 }, 2, new[] { 3, 3 })]
    [DataRow(new[] { -1, -2, 3, 4 }, 3, new[] { -1, 3, 4 })]
    [DataRow(new[] { 3, 4, 3, 3 }, 2, new[] { 3, 4 })]
    [DataRow(new[] { 1 }, 1, new[] { 1 })]
    [DataRow(new[] { 5, 4 }, 1, new[] { 5 })]
    [DataRow(new[] { 5, 4 }, 2, new[] { 5, 4 })]
    [DataRow(new[] { -1, -2, -3 }, 2, new[] { -1, -2 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 3, 4, 5 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 2, new[] { 5, 4 })]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, new[] { 1, 1 })]
    [DataRow(new[] { -5, 10, -5, 10 }, 2, new[] { 10, 10 })]
    [DataRow(new[] { 0, 0, 0 }, 1, new[] { 0 })]
    [DataRow(new[] { 9, -9, 8, -8, 7 }, 3, new[] { 9, 8, 7 })]
    [DataRow(new[] { 100000, -100000 }, 1, new[] { 100000 })]
    [DataRow(new[] { 3, 1, 2 }, 3, new[] { 3, 1, 2 })]
    [DataRow(new[] { -3, -1, -2 }, 1, new[] { -1 })]
    [DataRow(new[] { 4, 1, 7, 2, 9, 3 }, 4, new[] { 4, 7, 9, 3 })]
    [DataRow(new[] { 10, 20, 30, 40 }, 1, new[] { 40 })]
    [DataRow(new[] { -1, 5, -1, 5, -1 }, 2, new[] { 5, 5 })]
    [DataRow(new[] { 2, 7, 1, 8, 2, 8 }, 3, new[] { 7, 8, 8 })]
    public void MaxSubsequence_WithGivenArrayAndK_ReturnsSubsequenceWithLargestSum(int[] nums, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxSubsequence(nums, k);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}