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

using LeetCode.Algorithms.MinimumValueOfMergedIntegers;

namespace LeetCode.Tests.Algorithms.MinimumValueOfMergedIntegers;

public abstract class MinimumValueOfMergedIntegersTestsBase<T> where T : IMinimumValueOfMergedIntegers, new()
{
    [TestMethod]
    [DataRow(new[] { 23, 55, 42, 21 }, 2355)]
    [DataRow(new[] { 34, 7, 11, 11 }, 347)]
    [DataRow(new[] { 9, 20 }, 920)]
    [DataRow(new[] { 1, 1 }, 11)]
    [DataRow(new[] { 10, 10 }, 1010)]
    [DataRow(new[] { 3, 1000 }, 31000)]
    [DataRow(new[] { 1000, 3 }, 10003)]
    [DataRow(new[] { 1000, 1000 }, 10001000)]
    [DataRow(new[] { 5, 5, 5, 5 }, 55)]
    [DataRow(new[] { 1, 10, 1, 9 }, 19)]
    [DataRow(new[] { 1, 9, 9, 1 }, 19)]
    [DataRow(new[] { 9, 1, 1, 9 }, 19)]
    [DataRow(new[] { 10, 1, 1, 10 }, 101)]
    [DataRow(new[] { 9, 9, 10, 1 }, 99)]
    [DataRow(new[] { 99, 9, 9, 99 }, 999)]
    [DataRow(new[] { 50, 1, 2, 60 }, 260)]
    [DataRow(new[] { 2, 100, 3, 10 }, 310)]
    [DataRow(new[] { 100, 1, 1, 100 }, 1001)]
    [DataRow(new[] { 1, 1000, 2, 1 }, 21)]
    [DataRow(new[] { 1, 999, 1, 1000 }, 1999)]
    [DataRow(new[] { 1, 1000, 999, 9 }, 9999)]
    [DataRow(new[] { 999, 999, 1000, 1 }, 10001)]
    [DataRow(new[] { 1000, 1, 1, 1000 }, 10001)]
    [DataRow(new[] { 10, 100, 100, 10 }, 10010)]
    [DataRow(new[] { 100, 100, 99, 999 }, 99999)]
    [DataRow(new[] { 1000, 1000, 1000, 999 }, 1000999)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 12)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, 21)]
    [DataRow(new[] { 7, 8, 1, 2, 7, 8 }, 12)]
    [DataRow(new[] { 12, 34, 56, 78, 1, 9 }, 19)]
    public void MinMergedInteger_WithNums_ReturnsMinimumMergedInteger(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinMergedInteger(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}