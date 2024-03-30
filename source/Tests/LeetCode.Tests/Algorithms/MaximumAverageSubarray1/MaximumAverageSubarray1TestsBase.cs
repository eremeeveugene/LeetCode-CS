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

using LeetCode.Algorithms.MaximumAverageSubarray1;

namespace LeetCode.Tests.Algorithms.MaximumAverageSubarray1;

public abstract class MaximumAverageSubarray1TestsBase<T> where T : IMaximumAverageSubarray1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75)]
    [DataRow(new[] { 5 }, 1, 5)]
    [DataRow(new[] { -1 }, 1, -1)]
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