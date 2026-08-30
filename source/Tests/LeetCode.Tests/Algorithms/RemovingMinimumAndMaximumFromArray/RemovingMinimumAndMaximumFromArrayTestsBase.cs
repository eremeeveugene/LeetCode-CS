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

using LeetCode.Algorithms.RemovingMinimumAndMaximumFromArray;

namespace LeetCode.Tests.Algorithms.RemovingMinimumAndMaximumFromArray;

public abstract class RemovingMinimumAndMaximumFromArrayTestsBase<T> where T : IRemovingMinimumAndMaximumFromArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 10, 7, 5, 4, 1, 8, 6 }, 5)]
    [DataRow(new[] { 0, -4, 19, 1, 8, -2, -3, 5 }, 3)]
    [DataRow(new[] { 101 }, 1)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 2, 1 }, 2)]
    [DataRow(new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 3, 2, 1 }, 2)]
    [DataRow(new[] { 2, 1, 3 }, 2)]
    [DataRow(new[] { 2, 3, 1 }, 2)]
    [DataRow(new[] { 1, 4, 3, 2 }, 2)]
    [DataRow(new[] { 4, 1, 2, 3 }, 2)]
    [DataRow(new[] { 2, 3, 4, 1 }, 2)]
    [DataRow(new[] { 3, 2, 1, 4 }, 2)]
    [DataRow(new[] { 5, 1, 3, 4, 2, 6 }, 3)]
    [DataRow(new[] { 6, 2, 3, 4, 1, 5 }, 3)]
    [DataRow(new[] { 3, 1, 4, 5, 2 }, 4)]
    [DataRow(new[] { 3, 5, 4, 1, 2 }, 4)]
    [DataRow(new[] { -5, -1, -3, -2, -4 }, 2)]
    [DataRow(new[] { -1, -5, -3, -4, -2 }, 2)]
    [DataRow(new[] { -2, -3, -4, -5, -1 }, 2)]
    [DataRow(new[] { -2, -1, -4, -3, -5 }, 3)]
    [DataRow(new[] { -4, -5, -2, -1, -3 }, 4)]
    [DataRow(new[] { -100_000, 0, 100_000 }, 2)]
    [DataRow(new[] { 0, 100_000, -100_000, 1 }, 3)]
    [DataRow(new[] { 8, 6, 7, 5, 3, 0, 9 }, 2)]
    public void MinimumDeletions_WithGivenDistinctNumbers_ReturnsMinimumDeletionsFromArrayEnds(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumDeletions(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}