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

using LeetCode.Algorithms.SingleNumber;

namespace LeetCode.Tests.Algorithms.SingleNumber;

public abstract class SingleNumberTestsBase<T> where T : ISingleNumber, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 2, 1 }, 1)]
    [DataRow(new[] { 4, 1, 2, 1, 2 }, 4)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { -1 }, -1)]
    [DataRow(new[] { 30000 }, 30000)]
    [DataRow(new[] { -30000 }, -30000)]
    [DataRow(new[] { 5, 5, 7 }, 7)]
    [DataRow(new[] { 0, 0, -3 }, -3)]
    [DataRow(new[] { -1, -1, -2 }, -2)]
    [DataRow(new[] { 7, 3, 7 }, 3)]
    [DataRow(new[] { 1, 2, 3, 2, 1 }, 3)]
    [DataRow(new[] { -30000, 30000, -30000 }, 30000)]
    [DataRow(new[] { 30000, -30000, 30000, 1, 1 }, -30000)]
    [DataRow(new[] { 10, 20, 30, 20, 10 }, 30)]
    [DataRow(new[] { 0, 1, 0 }, 1)]
    [DataRow(new[] { 100, -100, 200, 100, -100 }, 200)]
    [DataRow(new[] { 9, 8, 7, 8, 9, 6, 7 }, 6)]
    [DataRow(new[] { -5, -5, -6, -6, -7 }, -7)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 4 }, 4)]
    public void SingleNumber_WithIntegerArray_ReturnsSingleNumber(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SingleNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}