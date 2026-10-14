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

using LeetCode.Algorithms.NumberOfSubArraysWithOddSum;

namespace LeetCode.Tests.Algorithms.NumberOfSubArraysWithOddSum;

public abstract class NumberOfSubArraysWithOddSumTestsBase<T> where T : INumberOfSubArraysWithOddSum, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 5 }, 4)]
    [DataRow(new[] { 2, 4, 6 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 16)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 2 }, 0)]
    [DataRow(new[] { 100 }, 0)]
    [DataRow(new[] { 99 }, 1)]
    [DataRow(new[] { 1, 1 }, 2)]
    [DataRow(new[] { 2, 2 }, 0)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 2, 1 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1 }, 6)]
    [DataRow(new[] { 2, 4, 6, 8, 1 }, 5)]
    [DataRow(new[] { 100, 100, 100, 99 }, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 12)]
    [DataRow(new[] { 97, 98, 55, 50, 70, 90, 80, 64 }, 14)]
    [DataRow(new[] { 61, 35, 66, 64, 84, 62, 77, 5, 51, 64, 22, 61, 63, 25, 48, 63, 96, 19, 48, 62, 42, 74, 70 }, 128)]
    [DataRow(new[] { 61, 13, 15, 38, 53, 7, 69, 62, 79, 69, 99, 14, 38, 53, 76, 55, 82, 86, 94, 5, 36, 54, 29, 68, 36, 37, 25 }, 192)]
    [DataRow(new[] { 7, 3, 12, 3, 80, 73, 6, 56, 73, 97, 54, 41, 25, 8, 53, 79, 34, 55, 24, 35, 63, 88 }, 130)]
    [DataRow(new[] { 60, 37, 22, 92, 44, 89, 30, 82, 77, 35, 33, 42, 58, 37, 37, 65, 86 }, 81)]
    [DataRow(new[] { 17, 5, 48, 27, 89, 54, 12, 40, 37, 21, 91, 92, 22, 81, 73, 90, 51, 71, 58, 99, 34 }, 120)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 930)]
    public void NumOfSubarrays_WithGivenArray_ReturnsCountOfOddSumSubarrays(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumOfSubarrays(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}