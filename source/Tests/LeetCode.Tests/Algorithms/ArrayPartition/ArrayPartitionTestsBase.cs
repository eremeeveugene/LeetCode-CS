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

using LeetCode.Algorithms.ArrayPartition;

namespace LeetCode.Tests.Algorithms.ArrayPartition;

public abstract class ArrayPartitionTestsBase<T> where T : IArrayPartition, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 3, 2 }, 4)]
    [DataRow(new[] { 6, 2, 6, 5, 1, 2 }, 9)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 4, 3, 2, 1 }, 4)]
    [DataRow(new[] { 5, 5, 5, 5 }, 10)]
    [DataRow(new[] { -1, -2 }, -2)]
    [DataRow(new[] { -1, -2, -3, -4 }, -6)]
    [DataRow(new[] { 0, 0 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 9)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, 9)]
    [DataRow(new[] { -5, 5, -5, 5 }, 0)]
    [DataRow(new[] { 10000, -10000 }, -10000)]
    [DataRow(new[] { 10000, 10000, -10000, -10000 }, 0)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1 }, 3)]
    [DataRow(new[] { 3, 1, 2, 2 }, 3)]
    [DataRow(new[] { 7, 3, 1, 0, 0, 6 }, 7)]
    [DataRow(new[] { 2, 2, 3, 3, 4, 4 }, 9)]
    [DataRow(new[] { 100, 200, 300, 400 }, 400)]
    [DataRow(new[] { -1, 0, 1, 0 }, -1)]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2 }, 20)]
    public void ArrayPairSum_GivenArrayOfIntegers_ReturnsMaximumSumOfMinPairsInEveryPair(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ArrayPairSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}