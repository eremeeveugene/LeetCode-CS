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

using LeetCode.Algorithms.MinimumAverageOfSmallestAndLargestElements;

namespace LeetCode.Tests.Algorithms.MinimumAverageOfSmallestAndLargestElements;

public abstract class MinimumAverageOfSmallestAndLargestElementsTestsBase<T> where T : IMinimumAverageOfSmallestAndLargestElements, new()
{
    [TestMethod]
    [DataRow(new[] { 7, 8, 3, 4, 15, 13, 4, 1 }, 5.5)]
    [DataRow(new[] { 1, 9, 8, 3, 10, 5 }, 5.5)]
    [DataRow(new[] { 1, 2, 3, 7, 8, 9 }, 5.0)]
    [DataRow(new[] { 1, 2 }, 1.5)]
    [DataRow(new[] { 5, 5 }, 5.0)]
    [DataRow(new[] { 1, 50 }, 25.5)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2.5)]
    [DataRow(new[] { 1, 2, 10, 20 }, 6.0)]
    [DataRow(new[] { 4, 1, 7, 3 }, 3.5)]
    [DataRow(new[] { 50, 1, 49, 2 }, 25.5)]
    [DataRow(new[] { 2, 2, 8, 8 }, 5.0)]
    [DataRow(new[] { 1, 1, 1, 50 }, 1.0)]
    [DataRow(new[] { 50, 50, 1, 1 }, 25.5)]
    [DataRow(new[] { 3, 6, 9, 12, 15, 18 }, 10.5)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 20 }, 7.0)]
    [DataRow(new[] { 8, 1, 2, 3, 4, 5 }, 3.5)]
    [DataRow(new[] { 10, 1, 5, 2, 8, 3, 7, 4 }, 4.5)]
    [DataRow(new[] { 1, 50, 2, 49, 3, 48 }, 25.5)]
    [DataRow(new[] { 10, 10, 10, 10 }, 10.0)]
    [DataRow(new[] { 1, 3, 3, 7 }, 3.0)]
    [DataRow(new[] { 6, 2, 9, 1, 12, 5 }, 5.5)]
    [DataRow(new[] { 20, 30, 10, 40 }, 25.0)]
    [DataRow(new[] { 1, 4, 6, 9 }, 5.0)]
    [DataRow(new[] { 1, 2, 2, 50 }, 2.0)]
    [DataRow(new[] { 25, 26 }, 25.5)]
    public void MinimumAverage_WithGivenNumbers_ReturnsMinimumAverage(int[] nums, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumAverage(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}