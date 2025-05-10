// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.IntersectionOfTwoArrays2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.IntersectionOfTwoArrays2;

public abstract class IntersectionOfTwoArrays2TestsBase<T> where T : IIntersectionOfTwoArrays2, new()
{
    [TestMethod]
    [DataRow("[1, 2, 2, 1]", "[2, 2]", "[2, 2]")]
    [DataRow("[4, 9, 5]", "[9, 4, 9, 8, 4]", "[4, 9]")]
    public void Intersect_WithTwoArrays_ReturnsCommonElements(string nums1Json, string nums2Json,
        string expectedResultJson)
    {
        // Arrange
        var nums1 = JsonHelper<int>.DeserializeToArray(nums1Json);
        var nums2 = JsonHelper<int>.DeserializeToArray(nums2Json);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.Intersect(nums1, nums2);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}