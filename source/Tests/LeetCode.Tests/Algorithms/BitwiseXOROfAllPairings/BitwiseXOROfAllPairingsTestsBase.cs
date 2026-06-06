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
    [DataRow(new[] { 1, 2 }, new[] { 3, 4, 5 }, 3)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, 7)]
    [DataRow(new[] { 7 }, new[] { 8 }, 15)]
    [DataRow(new[] { 1 }, new[] { 2, 3 }, 1)]
    [DataRow(new[] { 1, 2 }, new[] { 3 }, 3)]
    [DataRow(new[] { 0 }, new[] { 0 }, 0)]
    [DataRow(new[] { 5, 5 }, new[] { 6, 6 }, 0)]
    [DataRow(new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, 3)]
    [DataRow(new[] { 4 }, new[] { 1, 2, 3 }, 4)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 4 }, 4)]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, new[] { 1, 2, 3 }, 5)]
    [DataRow(new[] { 0, 0, 0 }, new[] { 1, 1, 1 }, 1)]
    [DataRow(new[] { 100 }, new[] { 200 }, 172)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 5 }, 4)]
    [DataRow(new[] { 5 }, new[] { 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 2, 4, 6 }, new[] { 1, 3, 5 }, 7)]
    [DataRow(new[] { 10, 20, 30 }, new[] { 40 }, 40)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 10 }, 11)]
    public void XorAllNums_WithTwoIntegerArrays_ReturnsBitwiseXorValue(int[] nums1, int[] nums2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.XorAllNums(nums1, nums2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}