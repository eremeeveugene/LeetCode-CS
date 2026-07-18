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

using LeetCode.Algorithms.CountHillsAndValleysInAnArray;

namespace LeetCode.Tests.Algorithms.CountHillsAndValleysInAnArray;

public abstract class CountHillsAndValleysInAnArrayTestsBase<T> where T : ICountHillsAndValleysInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 4, 1, 1, 6, 5 }, 3)]
    [DataRow(new[] { 6, 6, 5, 5, 4, 1 }, 0)]
    [DataRow(new[] { 1, 2, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 3, 2, 1 }, 0)]
    [DataRow(new[] { 1, 3, 2 }, 1)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 3)]
    [DataRow(new[] { 5, 5, 5 }, 0)]
    [DataRow(new[] { 1, 2, 2, 1 }, 1)]
    [DataRow(new[] { 1, 3, 1, 3, 1, 3 }, 4)]
    [DataRow(new[] { 0, 1, 0 }, 1)]
    [DataRow(new[] { 1, 1, 2 }, 0)]
    [DataRow(new[] { 2, 1, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3, 2, 1 }, 1)]
    [DataRow(new[] { 4, 4, 4, 4 }, 0)]
    [DataRow(new[] { 1, 3, 2, 3, 1 }, 3)]
    [DataRow(new[] { 1, 2, 1, 1, 2, 1 }, 3)]
    [DataRow(new[] { 1, 1, 3, 2, 2 }, 1)]
    [DataRow(new[] { 2, 3, 2, 2, 1 }, 1)]
    [DataRow(new[] { 1, 4, 3, 3, 2 }, 1)]
    [DataRow(new[] { 5, 4, 5, 5, 6 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 0)]
    [DataRow(new[] { 2, 3, 1, 4, 2, 4 }, 2)]
    [DataRow(new[] { 1, 1, 1, 2, 2, 1, 1 }, 0)]
    [DataRow(new[] { 3, 2, 1, 2, 3 }, 2)]
    [DataRow(new[] { 1, 3, 2, 3, 2, 3, 1 }, 3)]
    [DataRow(new[] { 2, 1, 3 }, 1)]
    [DataRow(new[] { 3, 1, 2 }, 1)]
    public void CountHillValley_WithArrayContainingHillsAndValleys_ReturnsTotalHillValleyCount(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountHillValley(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}