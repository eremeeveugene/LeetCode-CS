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

using LeetCode.Algorithms.SingleNumber2;

namespace LeetCode.Tests.Algorithms.SingleNumber2;

public abstract class SingleNumber2TestsBase<T> where T : ISingleNumber2, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 2, 3, 2 }, 3)]
    [DataRow(new[] { 0, 1, 0, 1, 0, 1, 99 }, 99)]
    [DataRow(new[] { 5 }, 5)]
    [DataRow(new[] { -5 }, -5)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 2147483647 }, 2147483647)]
    [DataRow(new[] { -2147483648 }, -2147483648)]
    [DataRow(new[] { 1, 1, 1, 2 }, 2)]
    [DataRow(new[] { -1, -1, -1, 0 }, 0)]
    [DataRow(new[] { 7, 3, 3, 3, 7, 7, 9 }, 9)]
    [DataRow(new[] { 2147483647, 2147483647, 2147483647, -2147483648 }, -2147483648)]
    [DataRow(new[] { -2147483648, -2147483648, -2147483648, 2147483647 }, 2147483647)]
    [DataRow(new[] { 10, 10, 10, -10 }, -10)]
    [DataRow(new[] { 4, 5, 4, 5, 4, 5, 6 }, 6)]
    [DataRow(new[] { 0, 0, 0, 1, 1, 1, -7 }, -7)]
    [DataRow(new[] { 100, 200, 100, 200, 100, 200, 300 }, 300)]
    [DataRow(new[] { -3, -3, -3, -4, -4, -4, -5 }, -5)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 42 }, 42)]
    [DataRow(new[] { 9, 8, 9, 8, 9, 8, 0 }, 0)]
    [DataRow(new[] { 1000000000, 1000000000, 1000000000, -1000000000 }, -1000000000)]
    public void SingleNumber_WithIntegerArray_ReturnsUniqueNumber(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SingleNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}