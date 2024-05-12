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

using LeetCode.Algorithms.MedianOfTwoSortedArrays;

namespace LeetCode.Tests.Algorithms.MedianOfTwoSortedArrays;

public abstract class MedianOfTwoSortedArraysTestsBase<T> where T : IMedianOfTwoSortedArrays, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3 }, new[] { 2 }, 2)]
    [DataRow(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    [DataRow(new[] { 1, 4 }, new[] { 2, 3 }, 2.5)]
    [DataRow(new[] { 1, 3, 5 }, new[] { 2, 4, 6 }, 3.5)]
    [DataRow(new[] { 1, 100 }, new[] { 2, 3, 4 }, 3)]
    [DataRow(new int[] { }, new[] { 1, 2, 3, 4, 5 }, 3)]
    [DataRow(new[] { 1000, 2000, 3000 }, new[] { 1500, 2500 }, 2000)]
    [DataRow(new[] { -5, -3, -1 }, new[] { -4, -2, 0 }, -2.5)]
    public void FindMedianSortedArrays_GivenTwoArrays_ReturnsCorrectMedianValue(int[] nums1, int[] nums2,
        double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMedianSortedArrays(nums1, nums2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}