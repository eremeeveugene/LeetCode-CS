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

using LeetCode.Algorithms.FindCommonElementsBetweenTwoArrays;

namespace LeetCode.Tests.Algorithms.FindCommonElementsBetweenTwoArrays;

public abstract class FindCommonElementsBetweenTwoArraysTestsBase<T> where T : IFindCommonElementsBetweenTwoArrays, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 2 }, new[] { 1, 2 }, new[] { 2, 1 })]
    [DataRow(new[] { 4, 3, 2, 3, 1 }, new[] { 2, 2, 5, 2, 3, 6 }, new[] { 3, 4 })]
    [DataRow(new[] { 3, 4, 2, 3 }, new[] { 1, 5 }, new[] { 0, 0 })]
    [DataRow(new[] { 1 }, new[] { 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 1 }, new[] { 2 }, new[] { 0, 0 })]
    [DataRow(new[] { 5, 5, 5 }, new[] { 5 }, new[] { 3, 1 })]
    [DataRow(new[] { 5 }, new[] { 5, 5, 5 }, new[] { 1, 3 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, new[] { 3, 3 })]
    [DataRow(new[] { 1, 1, 2, 2 }, new[] { 2, 3 }, new[] { 2, 1 })]
    [DataRow(new[] { 100 }, new[] { 100, 100 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8 }, new[] { 0, 0 })]
    [DataRow(new[] { 6, 7, 3, 4 }, new[] { 2 }, new[] { 0, 0 })]
    [DataRow(new[] { 4, 9, 4 }, new[] { 1, 8, 8, 8, 7, 8, 10 }, new[] { 0, 0 })]
    [DataRow(new[] { 7, 2, 8, 4 }, new[] { 5 }, new[] { 0, 0 })]
    [DataRow(new[] { 7, 8, 7, 2, 5, 2, 2, 7, 10 }, new[] { 2, 1, 6, 4, 2, 8, 9 }, new[] { 4, 3 })]
    [DataRow(new[] { 10, 3, 10, 2 }, new[] { 1, 8, 4, 3, 10, 8, 10, 8, 5 }, new[] { 3, 3 })]
    [DataRow(new[] { 6, 7, 3, 3, 10, 2, 9, 6, 6 }, new[] { 9, 10, 4, 5, 3, 6, 9, 5 }, new[] { 7, 5 })]
    [DataRow(new[] { 2, 9, 9, 4, 6, 4, 1, 5, 6 }, new[] { 5, 1, 7, 5 }, new[] { 2, 3 })]
    [DataRow(new[] { 5, 7, 3, 7, 2, 3, 1 }, new[] { 3, 5, 2, 1 }, new[] { 5, 4 })]
    [DataRow(new[] { 6, 3, 10, 7, 4, 3, 7 }, new[] { 8, 7, 7, 2, 10, 2, 5, 2, 1, 2 }, new[] { 3, 3 })]
    public void FindIntersectionValues_WithTwoIntegerArrays_ReturnsIntersectionCounts(int[] nums1, int[] nums2, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindIntersectionValues(nums1, nums2);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}