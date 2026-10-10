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

using LeetCode.Algorithms.SumOfVariableLengthSubarrays;

namespace LeetCode.Tests.Algorithms.SumOfVariableLengthSubarrays;

public abstract class SumOfVariableLengthSubarraysTestsBase<T> where T : ISumOfVariableLengthSubarrays, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 1 }, 11)]
    [DataRow(new[] { 3, 1, 1, 2 }, 13)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 100 }, 100)]
    [DataRow(new[] { 1, 1 }, 3)]
    [DataRow(new[] { 1, 1, 1 }, 5)]
    [DataRow(new[] { 3, 1, 2 }, 13)]
    [DataRow(new[] { 100, 100, 100 }, 600)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 35)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 38)]
    [DataRow(new[] { 1, 100, 1, 100, 1 }, 506)]
    [DataRow(new[] { 10, 1, 10, 1, 10, 1, 10 }, 139)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2 }, 30)]
    [DataRow(new[] { 3, 1, 1, 2, 1, 1 }, 18)]
    [DataRow(new[] { 1, 3, 2, 1, 4, 2 }, 32)]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 175)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 35)]
    [DataRow(new[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 }, 505000)]
    [DataRow(new[] { 1, 54, 7, 60, 13, 66, 19, 72, 25, 78, 31, 84, 37, 90, 43, 96, 49, 2, 55, 8, 61, 14, 67, 20, 73, 26, 79, 32, 85, 38, 91, 44, 97, 50, 3, 56, 9, 62, 15, 68, 21, 74, 27, 80, 33, 86, 39, 92, 45, 98, 51, 4, 57, 10, 63, 16, 69, 22, 75, 28, 81, 34, 87, 40, 93, 46, 99, 52, 5, 58, 11, 64, 17, 70, 23, 76, 29, 82, 35, 88, 41, 94, 47, 100, 53, 6, 59, 12, 65, 18, 71, 24, 77, 30, 83, 36, 89, 42, 95, 48 }, 173892)]
    [DataRow(new[] { 4, 3, 2, 1 }, 23)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 15)]
    public void SubarraySum_WithGivenArray_ReturnsMaximumSum(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SubarraySum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}