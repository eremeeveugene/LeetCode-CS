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

using LeetCode.Algorithms.BitwiseXOROfAllPairings;

namespace LeetCode.Tests.Algorithms.BitwiseXOROfAllPairings;

public abstract class BitwiseXOROfAllPairingsTestsBAse<T> where T : IBitwiseXOROfAllPairings, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 3 }, new[] { 10, 2, 5, 0 }, 13)]
    [DataRow(new[] { 1, 2 }, new[] { 3, 4 }, 0)]
    public void XorAllNums_WithTwoIntegerArrays_ReturnsBitwiseXorValue(int[] nums1, int[] nums2,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.XorAllNums(nums1, nums2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}