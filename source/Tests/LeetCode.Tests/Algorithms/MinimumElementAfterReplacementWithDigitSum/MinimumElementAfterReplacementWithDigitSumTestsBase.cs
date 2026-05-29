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

using LeetCode.Algorithms.MinimumElementAfterReplacementWithDigitSum;

namespace LeetCode.Tests.Algorithms.MinimumElementAfterReplacementWithDigitSum;

public abstract class MinimumElementAfterReplacementWithDigitSumTestsBase<T> where T : IMinimumElementAfterReplacementWithDigitSum, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 12, 13, 14 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 1)]
    [DataRow(new[] { 999, 19, 199 }, 10)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 5 }, 5)]
    [DataRow(new[] { 9 }, 9)]
    [DataRow(new[] { 10000 }, 1)]
    [DataRow(new[] { 9999 }, 36)]
    [DataRow(new[] { 9, 9, 9 }, 9)]
    [DataRow(new[] { 10, 10, 10 }, 1)]
    [DataRow(new[] { 9999, 9999 }, 36)]
    [DataRow(new[] { 9, 18, 27, 36, 45 }, 9)]
    [DataRow(new[] { 11, 22, 33, 44 }, 2)]
    [DataRow(new[] { 19, 28, 37, 46, 55, 64, 73, 82, 91 }, 10)]
    [DataRow(new[] { 100, 200, 300, 400 }, 1)]
    [DataRow(new[] { 1234, 5678, 9012 }, 10)]
    [DataRow(new[] { 10000, 9999, 5000 }, 1)]
    [DataRow(new[] { 50, 50, 50, 50, 50 }, 5)]
    [DataRow(new[] { 99, 999, 9999 }, 18)]
    [DataRow(new[] { 12, 23, 34, 45, 56, 67, 78, 89 }, 3)]
    public void MinElement_WithGivenNums_ReturnsMinimumAfterReplacementWithDigitSum(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinElement(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}