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

using LeetCode.Algorithms.PartitionArraySuchThatMaximumDifferenceIsK;

namespace LeetCode.Tests.Algorithms.PartitionArraySuchThatMaximumDifferenceIsK;

public abstract class PartitionArraySuchThatMaximumDifferenceIsKTestsBase<T> where T : IPartitionArraySuchThatMaximumDifferenceIsK, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 6, 1, 2, 5 }, 2, 2)]
    [DataRow(new[] { 1, 2, 3 }, 1, 2)]
    [DataRow(new[] { 2, 2, 4, 5 }, 0, 3)]
    [DataRow(new[] { 1 }, 0, 1)]
    [DataRow(new[] { 5 }, 5, 1)]
    [DataRow(new[] { 1, 1, 1, 1 }, 0, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4, 1)]
    [DataRow(new[] { 1, 10 }, 0, 2)]
    [DataRow(new[] { 1, 10 }, 9, 1)]
    [DataRow(new[] { 0, 0, 0 }, 0, 1)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 2, 3)]
    [DataRow(new[] { 1, 2, 3, 10, 11, 12 }, 2, 2)]
    [DataRow(new[] { 1, 100 }, 100, 1)]
    [DataRow(new[] { 5, 5, 5 }, 0, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 0, 4)]
    [DataRow(new[] { 1, 2, 3, 4 }, 3, 1)]
    [DataRow(new[] { 0, 5, 10, 15 }, 5, 2)]
    public void PartitionArray_WithElementsDifferingByK_ReturnsMinimumSubsequenceCount(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PartitionArray(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}