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

using LeetCode.Algorithms.IntersectionOfTwoArrays;

namespace LeetCode.Tests.Algorithms.IntersectionOfTwoArrays;

public abstract class IntersectionOfTwoArraysTestsBase<T> where T : IIntersectionOfTwoArrays, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2 })]
    [DataRow(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 9, 4 })]
    public void Intersection_GivenTwoArrays_ReturnsCommonElements(int[] nums1, int[] nums2, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Intersection(nums1, nums2);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}