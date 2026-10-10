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

using LeetCode.Algorithms.MaximumAverageSubarray1;

namespace LeetCode.Tests.Algorithms.MaximumAverageSubarray1;

public abstract class MaximumAverageSubarray1TestsBase<T> where T : IMaximumAverageSubarray1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75)]
    [DataRow(new[] { 5 }, 1, 5)]
    [DataRow(new[] { -1 }, 1, -1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 5.0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 3.0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 4.5)]
    [DataRow(new[] { -1, -2, -3 }, 2, -1.5)]
    [DataRow(new[] { 0, 0, 0 }, 3, 0.0)]
    [DataRow(new[] { 0, 1, 1, 3, 3 }, 4, 2.0)]
    [DataRow(new[] { 4, 2, 1, 3, 3 }, 2, 3.0)]
    [DataRow(new[] { -5, -3, -1, -7 }, 1, -1.0)]
    [DataRow(new[] { 10000, 10000, 10000 }, 2, 10000.0)]
    [DataRow(new[] { -10000, -10000 }, 2, -10000.0)]
    [DataRow(new[] { 7, 4, 5, 8, 8, 3, 9, 8, 12, 6 }, 4, 8.75)]
    [DataRow(new[] { 1, -1, 1, -1, 1, -1 }, 2, 0.0)]
    [DataRow(new[] { 5, 5 }, 2, 5.0)]
    [DataRow(new[] { 3, -2, 7 }, 3, 2.6666666666666665)]
    [DataRow(new[] { 100, -100, 50, -50, 25 }, 3, 16.666666666666668)]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3 }, 3, 8.0)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2, 2, 2 }, 8, 2.0)]
    public void FindMaxAverage_GivenNumsAndK_ReturnsMaxAverage(int[] nums, int k, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMaxAverage(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}