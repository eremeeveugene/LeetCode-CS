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

using LeetCode.Algorithms.SubarrayProductLessThanK;

namespace LeetCode.Tests.Algorithms.SubarrayProductLessThanK;

public abstract class SubarrayProductLessThanKTestsBase<T> where T : ISubarrayProductLessThanK, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 5, 2, 6 }, 100, 8)]
    [DataRow(new[] { 1, 2, 3 }, 0, 0)]
    [DataRow(new[] { 1, 1, 1 }, 2, 6)]
    public void NumSubarrayProductLessThanK_GivenArrayAndThreshold_ReturnsCount(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSubarrayProductLessThanK(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}