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

using LeetCode.Algorithms.KthLargestElementInAnArray;

namespace LeetCode.Tests.Algorithms.KthLargestElementInAnArray;

public abstract class KthLargestElementInAnArrayTestsBase<T> where T : IKthLargestElementInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
    [DataRow(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1, 2 }, 1, 2)]
    [DataRow(new[] { 1, 2 }, 2, 1)]
    [DataRow(new[] { 2, 1 }, 1, 2)]
    [DataRow(new[] { 2, 1 }, 2, 1)]
    [DataRow(new[] { 1, 1 }, 1, 1)]
    [DataRow(new[] { 1, 1 }, 2, 1)]
    [DataRow(new[] { 5, 5, 5, 5 }, 1, 5)]
    [DataRow(new[] { 5, 5, 5, 5 }, 4, 5)]
    [DataRow(new[] { -1, -2, -3, -4 }, 1, -1)]
    [DataRow(new[] { -1, -2, -3, -4 }, 4, -4)]
    [DataRow(new[] { -1, 2, 0, -3, 5 }, 1, 5)]
    [DataRow(new[] { -1, 2, 0, -3, 5 }, 3, 0)]
    [DataRow(new[] { -1, 2, 0, -3, 5 }, 5, -3)]
    [DataRow(new[] { 10000, -10000, 0, 9999, -9999 }, 1, 10000)]
    [DataRow(new[] { 10000, -10000, 0, 9999, -9999 }, 5, -10000)]
    [DataRow(new[] { 4, 4, 4, 3, 3, 2, 1 }, 4, 3)]
    [DataRow(new[] { 7, 10, 4, 3, 20, 15 }, 3, 10)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 4)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 2, 4)]
    [DataRow(new[] { 4, 1, 3, 2, 5 }, 3, 3)]
    [DataRow(new[] { 9, 8, 7, 1, 2, 3 }, 4, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 0 }, 5, 0)]
    [DataRow(new[] { 2, 1, 2, 1, 2, 1 }, 3, 2)]
    [DataRow(new[] { 6, 5, 5, 5, 4, 3 }, 4, 5)]
    [DataRow(new[] { 0, -1, -1, 2, 2, 2, -3 }, 5, -1)]
    [DataRow(new[] { -10000, -10000, -9999 }, 2, -10000)]
    [DataRow(new[] { 9999, 10000, 10000 }, 2, 10000)]
    [DataRow(new[] { 12, 3, 5, 7, 19, 1, 8, 15, 6, 10 }, 5, 8)]
    public void FindKthLargest_WithGivenArrayAndK_ReturnsKthLargestElement(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindKthLargest(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}