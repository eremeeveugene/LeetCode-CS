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

using LeetCode.Algorithms.FindGreatestCommonDivisorOfArray;

namespace LeetCode.Tests.Algorithms.FindGreatestCommonDivisorOfArray;

public abstract class FindGreatestCommonDivisorOfArrayTestsBase<T> where T : IFindGreatestCommonDivisorOfArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 5, 6, 9, 10 }, 2)]
    [DataRow(new[] { 7, 5, 6, 8, 3 }, 1)]
    [DataRow(new[] { 3, 3 }, 3)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 1000 }, 1)]
    [DataRow(new[] { 1000, 1000 }, 1000)]
    [DataRow(new[] { 2, 4, 6, 8 }, 2)]
    [DataRow(new[] { 10, 100 }, 10)]
    [DataRow(new[] { 12, 18, 6 }, 6)]
    [DataRow(new[] { 5, 10, 15, 20 }, 5)]
    [DataRow(new[] { 9, 27, 81 }, 9)]
    [DataRow(new[] { 13, 26 }, 13)]
    [DataRow(new[] { 17, 19 }, 1)]
    [DataRow(new[] { 100, 75, 50, 25 }, 25)]
    [DataRow(new[] { 8, 12 }, 4)]
    [DataRow(new[] { 21, 14, 7 }, 7)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 6, 10, 15 }, 3)]
    [DataRow(new[] { 1000, 500, 250 }, 250)]
    [DataRow(new[] { 36, 60, 48 }, 12)]
    [DataRow(new[] { 7, 7, 7, 7 }, 7)]
    [DataRow(new[] { 999, 3 }, 3)]
    public void FindGCD_WithIntegerArray_ReturnsGreatestCommonDivisorOfSmallestAndLargest(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindGCD(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}