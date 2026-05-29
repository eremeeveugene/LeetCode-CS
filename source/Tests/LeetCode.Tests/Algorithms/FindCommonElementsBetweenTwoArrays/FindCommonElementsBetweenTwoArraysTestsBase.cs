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

public abstract class FindCommonElementsBetweenTwoArraysTestsBase<T>
    where T : IFindCommonElementsBetweenTwoArrays, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 2 }, new[] { 1, 2 }, new[] { 2, 1 })]
    [DataRow(new[] { 4, 3, 2, 3, 1 }, new[] { 2, 2, 5, 2, 3, 6 }, new[] { 3, 4 })]
    [DataRow(new[] { 3, 4, 2, 3 }, new[] { 1, 5 }, new[] { 0, 0 })]
    public void FindIntersectionValues_WithTwoIntegerArrays_ReturnsIntersectionCounts(int[] nums1,
        int[] nums2, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindIntersectionValues(nums1, nums2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}