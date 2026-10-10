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

using LeetCode.Algorithms.PartitionEqualSubsetSum;

namespace LeetCode.Tests.Algorithms.PartitionEqualSubsetSum;

public abstract class PartitionEqualSubsetSumTestsBase<T> where T : IPartitionEqualSubsetSum, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 5, 11, 5 }, true)]
    [DataRow(new[] { 1, 2, 3, 5 }, false)]
    [DataRow(new[] { 1 }, false)]
    [DataRow(new[] { 2, 2 }, true)]
    [DataRow(new[] { 1, 2 }, false)]
    [DataRow(new[] { 1, 1 }, true)]
    [DataRow(new[] { 100 }, false)]
    [DataRow(new[] { 100, 100 }, true)]
    [DataRow(new[] { 1, 2, 5 }, false)]
    [DataRow(new[] { 3, 3, 3, 3 }, true)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, false)]
    [DataRow(new[] { 2, 3, 5 }, true)]
    [DataRow(new[] { 4, 4, 4, 4, 4 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, true)]
    [DataRow(new[] { 99, 1, 100 }, true)]
    [DataRow(new[] { 100, 100, 100, 100 }, true)]
    [DataRow(new[] { 100, 99, 98, 97, 1 }, false)]
    [DataRow(new[] { 1, 1, 1, 1, 2, 2, 2, 8 }, true)]
    [DataRow(new[] { 10, 13, 24, 11, 7, 10, 6, 2, 12, 11, 6, 30, 25, 21, 15 }, false)]
    [DataRow(new[] { 19, 21, 26, 19, 30, 24, 1, 3, 22, 29 }, true)]
    [DataRow(new[] { 22, 28, 18, 9, 23, 29, 7, 19, 5, 5, 16, 25, 30, 21, 28 }, false)]
    [DataRow(new[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 }, true)]
    [DataRow(new[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 99 }, false)]
    public void CanPartition_WithGivenIntegerArray_ReturnsWhetherItCanBePartitionedIntoEqualSumSubsets(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanPartition(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}