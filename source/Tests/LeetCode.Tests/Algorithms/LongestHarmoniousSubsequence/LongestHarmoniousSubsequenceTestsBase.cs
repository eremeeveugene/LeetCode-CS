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

using LeetCode.Algorithms.LongestHarmoniousSubsequence;

namespace LeetCode.Tests.Algorithms.LongestHarmoniousSubsequence;

public abstract class LongestHarmoniousSubsequenceTestsBase<T> where T : ILongestHarmoniousSubsequence, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 2, 2, 5, 2, 3, 7 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 1, 1, 2 }, 3)]
    [DataRow(new[] { 1, 3 }, 0)]
    [DataRow(new[] { -1, 0 }, 2)]
    [DataRow(new[] { -1, 0, 0, 1 }, 3)]
    [DataRow(new[] { 1, 2, 3, 3, 3, 4 }, 4)]
    [DataRow(new[] { 5, 5, 5, 6, 6, 8 }, 5)]
    [DataRow(new[] { 1000000000, 999999999, 999999999 }, 3)]
    [DataRow(new[] { 1, 4, 7, 10 }, 0)]
    [DataRow(new[] { 3, 3, 2, 2, 2, 1, 1, 1, 1 }, 7)]
    [DataRow(new[] { 0, 0, 0, 1 }, 4)]
    [DataRow(new[] { 1, 2, 2, 1, 3, 3, 3 }, 5)]
    [DataRow(new[] { 10, 11, 12, 13, 14, 14, 14 }, 4)]
    [DataRow(new[] { -3, -2, -2, -1, -1, -1 }, 5)]
    [DataRow(new[] { 2, 4, 6, 8, 9 }, 2)]
    [DataRow(new[] { 1, 1, 1, 2, 2, 3 }, 5)]
    public void FindLHS_WithNumsArray_ReturnsLongestHarmoniousSubsequenceLength(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindLHS(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}