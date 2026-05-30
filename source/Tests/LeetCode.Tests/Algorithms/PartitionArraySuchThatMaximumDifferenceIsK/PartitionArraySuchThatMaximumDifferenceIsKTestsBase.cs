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