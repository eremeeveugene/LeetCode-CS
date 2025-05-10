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

using LeetCode.Algorithms.BitwiseXOROfAllPairings;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BitwiseXOROfAllPairings;

public abstract class BitwiseXOROfAllPairingsTestsBAse<T> where T : IBitwiseXOROfAllPairings, new()
{
    [TestMethod]
    [DataRow("[2,1,3]", "[10,2,5,0]", 13)]
    [DataRow("[1,2]", "[3,4]", 0)]
    public void XorAllNums_WithTwoIntegerArrays_ReturnsBitwiseXorValue(string nums1Json, string nums2Json,
        int expectedResult)
    {
        // Arrange
        var nums1 = JsonHelper<int>.DeserializeToArray(nums1Json);
        var nums2 = JsonHelper<int>.DeserializeToArray(nums2Json);

        var solution = new T();

        // Act
        var actualResult = solution.XorAllNums(nums1, nums2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}