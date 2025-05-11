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

using LeetCode.Algorithms.FindTheDifferenceOfTwoArrays;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.FindTheDifferenceOfTwoArrays;

public abstract class FindTheDifferenceOfTwoArraysTestsBase<T> where T : IFindTheDifferenceOfTwoArrays, new()
{
    [TestMethod]
    [DataRow("[1, 2, 3]", "[2, 4, 6]", "[[1,3],[4,6]]")]
    [DataRow("[1, 2, 3, 3]", "[1, 1, 2, 2]", "[[3],[]]")]
    public void FindDifference_WithTwoIntegerArrays_ReturnsUniqueElementsInEachArray(string nums1Json,
        string nums2Json, string jsonExpectedResult)
    {
        // Arrange
        var nums1 = JsonHelper<int[]>.Parse(nums1Json);
        var nums2 = JsonHelper<int[]>.Parse(nums2Json);
        var expectedResult = JsonHelper<IList<IList<int>>>.Parse(jsonExpectedResult);

        var solution = new T();

        // Act
        var actualResult = solution.FindDifference(nums1, nums2);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }
}