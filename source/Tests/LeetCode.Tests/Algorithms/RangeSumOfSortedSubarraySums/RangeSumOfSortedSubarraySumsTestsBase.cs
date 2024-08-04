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

using LeetCode.Algorithms.RangeSumOfSortedSubarraySums;

namespace LeetCode.Tests.Algorithms.RangeSumOfSortedSubarraySums;

public abstract class RangeSumOfSortedSubarraySumsTestsBase<T> where T : IRangeSumOfSortedSubarraySums, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 4, 1, 5, 13)]
    [DataRow(new[] { 1, 2, 3, 4 }, 4, 3, 4, 6)]
    [DataRow(new[] { 1, 2, 3, 4 }, 4, 1, 10, 50)]
    public void RangeSum_WithValidInputs_ReturnsCorrectSubarraySum(int[] nums, int n, int left, int right,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RangeSum(nums, n, left, right);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}