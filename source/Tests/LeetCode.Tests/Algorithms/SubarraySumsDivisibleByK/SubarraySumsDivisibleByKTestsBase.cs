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

using LeetCode.Algorithms.SubarraySumsDivisibleByK;

namespace LeetCode.Tests.Algorithms.SubarraySumsDivisibleByK;

public abstract class SubarraySumsDivisibleByKTestsBase<T> where T : ISubarraySumsDivisibleByK, new()
{
    [TestMethod]
    [DataRow(new int[0], 5, 0)]
    [DataRow(new[] { 4, 5, 0, -2, -3, 1 }, 5, 7)]
    [DataRow(new[] { 5 }, 9, 0)]
    [DataRow(new[] { 0 }, 1, 1)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { -1 }, 1, 1)]
    [DataRow(new[] { -5, -10, 5 }, 5, 6)]
    [DataRow(new[] { 0, 0, 0 }, 5, 6)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 15)]
    [DataRow(new[] { 5, 0, -5 }, 5, 6)]
    [DataRow(new[] { 10, 20, 30 }, 10, 6)]
    [DataRow(new[] { 2, 3, 5 }, 5, 3)]
    [DataRow(new[] { -3, 3 }, 3, 3)]
    [DataRow(new[] { 1, -1, 1, -1 }, 2, 4)]
    [DataRow(new[] { 7, 3, 4, 6 }, 7, 3)]
    [DataRow(new[] { 6, 3, 5, 2, 3 }, 9, 1)]
    [DataRow(new[] { 5, 5, 5, 5 }, 5, 10)]
    [DataRow(new[] { 0, 0, 0, 0 }, 3, 10)]
    [DataRow(new[] { -2, 2 }, 2, 3)]
    [DataRow(new[] { 3, 6, 9 }, 3, 6)]
    public void SubarraysDivByK_GivenArrayAndDivisor_ReturnsCountOfSubarraysDivisibleByK(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SubarraysDivByK(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}