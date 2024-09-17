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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MedianOfTwoSortedArrays;

public abstract class MedianOfTwoSortedArraysTestsBase<T> where T : IMedianOfTwoSortedArrays, new()
{
    [TestMethod]
    [DataRow("[1,3]", "[2]", 2)]
    [DataRow("[1,2]", "[3,4]", 2.5)]
    [DataRow("[1,4]", "[2,3]", 2.5)]
    [DataRow("[1,3,5]", "[2,4,6]", 3.5)]
    [DataRow("[1,100]", "[2,3,4]", 3)]
    [DataRow("[]", "[1,2,3,4,5]", 3)]
    [DataRow("[1000,2000,3000]", "[1500,2500]", 2000)]
    [DataRow("[-5,-3,-1]", "[-4,-2,0]", -2.5)]
    [DataRow("[1]", "[2,3,4]", 2.5)]
    [DataRow("[1,2]", "[3]", 2)]
    [DataRow("[1,2,3]", "[4,5,6,7,8]", 4.5)]
    [DataRow("[1,3]", "[2,4,5]", 3)]
    [DataRow("[2]", "[1,3,4,5]", 3)]
    [DataRow("[1,2,3,4,5,6]", "[7,8,9,10]", 5.5)]
    [DataRow("[-10,-5,0,5,10]", "[1,2,3,4]", 2)]
    [DataRow("[-2147483648,0,2147483647]", "[-1,1]", 0)]
    public void FindMedianSortedArrays_GivenTwoArrays_ReturnsCorrectMedianValue(string nums1JsonArray,
        string nums2JsonArray, double expectedResult)
    {
        // Arrange
        var nums1 = JsonHelper<int>.DeserializeToArray(nums1JsonArray);
        var nums2 = JsonHelper<int>.DeserializeToArray(nums2JsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindMedianSortedArrays(nums1, nums2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}