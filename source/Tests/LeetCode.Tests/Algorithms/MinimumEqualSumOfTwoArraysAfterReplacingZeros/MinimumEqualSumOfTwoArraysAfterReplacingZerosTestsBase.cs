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

using LeetCode.Algorithms.MinimumEqualSumOfTwoArraysAfterReplacingZeros;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumEqualSumOfTwoArraysAfterReplacingZeros;

public abstract class MinimumEqualSumOfTwoArraysAfterReplacingZerosTestsBase<T>
    where T : IMinimumEqualSumOfTwoArraysAfterReplacingZeros, new()
{
    [TestMethod]
    [DataRow("[1,2,3,2]", "[1,4,3]", 8)]
    [DataRow("[3,2,0,1,0]", "[6,5,0]", 12)]
    [DataRow("[2,0,2,0]", "[1,4]", -1)]
    [DataRow("[2,0,2,0]", "[2,0,2,0]", 6)]
    [DataRow("[20,0,18,11,0,0,0,0,0,0,17,28,0,11,10,0,0,15,29]", "[16,9,25,16,1,9,20,28,8,0,1,0,1,27]", 169)]
    [DataRow("[0,17,20,17,5,0,14,19,7,8,16,18,6]", "[21,1,27,19,2,2,24,21,16,1,13,27,8,5,3,11,13,7,29,7]", 257)]
    public void MinSum_WithTwoIntegerArrays_ReturnsMinimumValidSumOrMinusOne(string nums1Json,
        string nums2Json, long expectedResult)
    {
        // Arrange
        var solution = new T();

        var nums1 = JsonHelper<int[]>.Parse(nums1Json);
        var nums2 = JsonHelper<int[]>.Parse(nums2Json);

        // Act
        var actualResult = solution.MinSum(nums1, nums2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}