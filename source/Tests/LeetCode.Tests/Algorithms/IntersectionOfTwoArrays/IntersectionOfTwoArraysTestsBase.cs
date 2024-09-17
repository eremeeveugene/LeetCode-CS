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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.IntersectionOfTwoArrays;

public abstract class IntersectionOfTwoArraysTestsBase<T> where T : IIntersectionOfTwoArrays, new()
{
    [TestMethod]
    [DataRow("[1, 2, 2, 1]", "[2, 2]", "[2]")]
    [DataRow("[4, 9, 5]", "[9, 4, 9, 8, 4]", "[9, 4]")]
    public void Intersection_GivenTwoArrays_ReturnsCommonElements(string nums1JsonArray, string nums2JsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums1 = JsonHelper<int>.DeserializeToArray(nums1JsonArray);
        var nums2 = JsonHelper<int>.DeserializeToArray(nums2JsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.Intersection(nums1, nums2);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}