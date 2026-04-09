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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindCommonElementsBetweenTwoArrays;

public abstract class FindCommonElementsBetweenTwoArraysTestsBase<T>
    where T : IFindCommonElementsBetweenTwoArrays, new()
{
    [TestMethod]
    [DataRow("[2,3,2]", "[1,2]", "[2,1]")]
    [DataRow("[4,3,2,3,1]", "[2,2,5,2,3,6]", "[3,4]")]
    [DataRow("[3,4,2,3]", "[1,5]", "[0,0]")]
    public void FindIntersectionValues_WithTwoIntegerArrays_ReturnsIntersectionCounts(string nums1Json,
        string nums2Json, string expectedResultJson)
    {
        // Arrange
        var nums1 = JsonHelper.Parse<int[]>(nums1Json);
        var nums2 = JsonHelper.Parse<int[]>(nums2Json);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindIntersectionValues(nums1, nums2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}