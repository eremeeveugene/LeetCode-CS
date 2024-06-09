// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
    [DataRow(new int[] { }, 5, 0)]
    [DataRow(new[] { 4, 5, 0, -2, -3, 1 }, 5, 7)]
    [DataRow(new[] { 5 }, 9, 0)]
    [DataRow(new[] { 0 }, 1, 1)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { -1 }, 1, 1)]
    [DataRow(new[] { -5, -10, 5 }, 5, 6)]
    [DataRow(new[] { 0, 0, 0 }, 5, 6)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 15)]
    public void SubarraysDivByK_GivenArrayAndDivisor_ReturnsCountOfSubarraysDivisibleByK(int[] nums, int k,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SubarraysDivByK(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}