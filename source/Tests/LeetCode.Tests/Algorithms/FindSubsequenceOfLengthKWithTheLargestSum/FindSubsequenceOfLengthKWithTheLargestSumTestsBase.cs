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
    public void MaxSubsequence_WithGivenArrayAndK_ReturnsSubsequenceWithLargestSum(int[] nums, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxSubsequence(nums, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}