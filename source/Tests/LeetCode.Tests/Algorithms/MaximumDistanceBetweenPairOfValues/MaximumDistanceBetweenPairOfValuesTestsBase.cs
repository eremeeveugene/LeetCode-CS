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

using LeetCode.Algorithms.MaximumDistanceBetweenPairOfValues;

namespace LeetCode.Tests.Algorithms.MaximumDistanceBetweenPairOfValues;

public abstract class MaximumDistanceBetweenPairOfValuesTestsBase<T> where T : IMaximumDistanceBetweenPairOfValues, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 1 }, 0)]
    [DataRow(new[] { 5 }, new[] { 1 }, 0)]
    [DataRow(new[] { 1 }, new[] { 5, 3, 1 }, 2)]
    [DataRow(new[] { 5, 4 }, new[] { 5, 4 }, 0)]
    [DataRow(new[] { 5, 4, 3 }, new[] { 5, 4, 3, 2, 1 }, 0)]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, 2)]
    [DataRow(new[] { 100000 }, new[] { 100000 }, 0)]
    [DataRow(new[] { 10, 5, 3, 1 }, new[] { 10, 10, 10, 10, 10, 10 }, 5)]
    [DataRow(new[] { 2, 2, 2 }, new[] { 10, 10, 1 }, 1)]
    [DataRow(new[] { 30, 29, 19, 5 }, new[] { 25, 25, 25, 25, 25 }, 2)]
    [DataRow(new[] { 55, 30, 5, 4, 2 }, new[] { 100, 20, 10, 10, 5 }, 2)]
    public void MaxDistance_WithNonIncreasingArrays_ReturnsMaximumValidPairDistance(int[] nums1, int[] nums2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDistance(nums1, nums2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}