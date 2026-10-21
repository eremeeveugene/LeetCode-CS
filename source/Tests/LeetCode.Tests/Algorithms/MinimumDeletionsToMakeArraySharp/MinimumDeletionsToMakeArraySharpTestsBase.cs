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

using LeetCode.Algorithms.MinimumDeletionsToMakeArraySharp;

namespace LeetCode.Tests.Algorithms.MinimumDeletionsToMakeArraySharp;

public abstract class MinimumDeletionsToMakeArraySharpTestsBase<T> where T : IMinimumDeletionsToMakeArraySharp, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2, 2, 2, 3 }, 3)]
    [DataRow(new[] { 4, 4, 9, 4 }, 1)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 100, 100 }, 1)]
    [DataRow(new[] { 1, 2, 1 }, 0)]
    [DataRow(new[] { 1, 1, 1 }, 2)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 0)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 3)]
    [DataRow(new[] { 7, 3, 3, 7 }, 1)]
    [DataRow(new[] { 3, 3, 7, 7 }, 2)]
    [DataRow(new[] { 2, 2, 2, 1, 2, 2, 2 }, 4)]
    [DataRow(new[] { 1, 2, 2, 1 }, 1)]
    [DataRow(new[] { 9, 8, 8, 8, 9 }, 2)]
    [DataRow(new[] { 10, 20, 20, 30, 30, 30 }, 3)]
    [DataRow(new[] { 6, 6, 6, 6, 1 }, 3)]
    [DataRow(new[] { 1, 6, 6, 6, 6 }, 3)]
    [DataRow(new[] { 4, 5, 4, 5, 5, 4 }, 1)]
    [DataRow(new[] { 50, 51, 50, 50, 51, 51 }, 2)]
    [DataRow(new[] { 99, 100, 99, 100 }, 0)]
    [DataRow(new[] { 8, 8, 1, 1, 8, 8 }, 3)]
    [DataRow(new[] { 1, 3, 3, 3, 5, 5, 7 }, 3)]
    [DataRow(new[] { 12, 12, 12, 12, 12, 12, 12, 12 }, 7)]
    public void MinDeletions_WithNums_ReturnsMinimumDeletions(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinDeletions(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}