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

using LeetCode.Algorithms.CountPartitionsWithEvenSumDifference;

namespace LeetCode.Tests.Algorithms.CountPartitionsWithEvenSumDifference;

public abstract class CountPartitionsWithEvenSumDifferenceTestsBase<T> where T : ICountPartitionsWithEvenSumDifference, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2 }, 0)]
    [DataRow(new[] { 2, 4, 6, 8 }, 3)]
    [DataRow(new[] { 10, 10, 3, 7, 6 }, 4)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 2, 2 }, 1)]
    [DataRow(new[] { 100, 100 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1 }, 3)]
    [DataRow(new[] { 1, 1, 1 }, 0)]
    [DataRow(new[] { 5, 6, 7, 8 }, 3)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 0)]
    [DataRow(new[] { 2, 3, 4, 5, 6, 7 }, 0)]
    [DataRow(new[] { 99, 100 }, 0)]
    [DataRow(new[] { 50, 50, 50 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0)]
    [DataRow(new[] { 9, 9, 9, 9, 9, 9 }, 5)]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, 4)]
    [DataRow(new[] { 1, 100, 1, 100 }, 3)]
    [DataRow(new[] { 3, 3, 4 }, 2)]
    [DataRow(new[] { 10, 20, 31, 41 }, 3)]
    public void CountPartitions_WithIntegerArray_ReturnsNumberOfValidPartitions(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountPartitions(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}