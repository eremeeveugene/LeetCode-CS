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

using LeetCode.Algorithms.MaximumAbsoluteSumOfAnySubarray;

namespace LeetCode.Tests.Algorithms.MaximumAbsoluteSumOfAnySubarray;

public abstract class MaximumAbsoluteSumOfAnySubarrayTestsBase<T> where T : IMaximumAbsoluteSumOfAnySubarray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, -3, 2, 3, -4 }, 5)]
    [DataRow(new[] { 2, -5, 1, -4, 3, -2 }, 8)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { -1 }, 1)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 10000, -10000 }, 10000)]
    [DataRow(new[] { -10000, 10000 }, 10000)]
    [DataRow(new[] { 1, 2, 3, 4 }, 10)]
    [DataRow(new[] { -1, -2, -3, -4 }, 10)]
    [DataRow(new[] { 5, -5, 5, -5 }, 5)]
    [DataRow(new[] { 1, -1, 1, -1, 1 }, 1)]
    [DataRow(new[] { -3, 5, -2, 4, -8, 1 }, 8)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 100, -50, -50, 100 }, 100)]
    [DataRow(new[] { -7, 3, -2, 9, -11, 4 }, 11)]
    [DataRow(new[] { 2, 2, -10, 2, 2 }, 10)]
    [DataRow(new[] { 1, -3, 2, 3, -4, 10, -20 }, 20)]
    [DataRow(new[] { 9, -9, 8, -8, 7, -7, 1 }, 9)]
    [DataRow(new[] { 4, -1, -1, 4, -9, 2 }, 9)]
    [DataRow(new[] { -2, 7, -3, 1, -8, 6, 6 }, 12)]
    public void MaxAbsoluteSum_GivenArrayOfIntegers_ReturnsMaxAbsoluteSubarraySum(int[] nums, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxAbsoluteSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}