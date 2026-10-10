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

using LeetCode.Algorithms.MissingNumber;

namespace LeetCode.Tests.Algorithms.MissingNumber;

public abstract class MissingNumberTestsBase<T> where T : IMissingNumber, new()
{
    [TestMethod]
    [DataRow(new int[] { }, 0)]
    [DataRow(new[] { 3, 0, 1 }, 2)]
    [DataRow(new[] { 0, 1 }, 2)]
    [DataRow(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    [DataRow(new[] { 0 }, 1)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 0, 1, 2 }, 3)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 0, 2 }, 1)]
    [DataRow(new[] { 2, 0 }, 1)]
    [DataRow(new[] { 1, 0 }, 2)]
    [DataRow(new[] { 4, 2, 1, 0 }, 3)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 0)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 10)]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 0)]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 0 }, 1)]
    [DataRow(new[] { 2, 0, 3 }, 1)]
    [DataRow(new[] { 2, 3, 0, 5, 4 }, 1)]
    [DataRow(new[] { 4, 2, 0, 1 }, 3)]
    [DataRow(new[] { 5, 3, 1, 2, 4 }, 0)]
    [DataRow(new[] { 7, 0, 3, 8, 6, 4, 1, 2 }, 5)]
    [DataRow(new[] { 1, 6, 11, 12, 5, 8, 10, 9, 4, 0, 3, 2 }, 7)]
    [DataRow(new[] { 4, 8, 7, 11, 9, 10, 0, 1, 5, 3, 2 }, 6)]
    [DataRow(new[] { 6, 13, 0, 12, 1, 5, 8, 10, 3, 2, 11, 9, 7, 14 }, 4)]
    [DataRow(new[] { 1, 2, 4, 5, 3 }, 0)]
    [DataRow(new[] { 2, 1, 0 }, 3)]
    public void MissingNumber_WithIntArray_ReturnsMissingNumber(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MissingNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
    [TestMethod]
    public void MissingNumber_WithMaxLengthArray_ReturnsMissingNumber()
    {
        // Arrange
        var nums = new int[10000];

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = i < 5000 ? i : i + 1;
        }

        var solution = new T();

        // Act
        var actualResult = solution.MissingNumber(nums);

        // Assert
        Assert.AreEqual(5000, actualResult);
    }
}