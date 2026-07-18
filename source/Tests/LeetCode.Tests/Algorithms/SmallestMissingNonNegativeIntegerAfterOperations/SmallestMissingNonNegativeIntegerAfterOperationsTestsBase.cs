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

using LeetCode.Algorithms.SmallestMissingNonNegativeIntegerAfterOperations;

namespace LeetCode.Tests.Algorithms.SmallestMissingNonNegativeIntegerAfterOperations;

public abstract class SmallestMissingNonNegativeIntegerAfterOperationsTestsBase<T> where T : ISmallestMissingNonNegativeIntegerAfterOperations, new()
{
    [TestMethod]
    [DataRow(new[] { 1, -10, 7, 13, 6, 8 }, 5, 4)]
    [DataRow(new[] { 1, -10, 7, 13, 6, 8 }, 7, 2)]
    [DataRow(new[] { 0 }, 1, 1)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { -1 }, 1, 1)]
    [DataRow(new[] { 0 }, 2, 1)]
    [DataRow(new[] { 1 }, 2, 0)]
    [DataRow(new[] { 0, 1 }, 2, 2)]
    [DataRow(new[] { 0, 1, 2, 3 }, 2, 4)]
    [DataRow(new[] { 0, 0, 0 }, 3, 1)]
    [DataRow(new[] { 3, 0, 3, 2, 4, 2, 1, 1, 0, 4 }, 5, 10)]
    [DataRow(new[] { -1, -2, -3 }, 3, 3)]
    [DataRow(new[] { 5, 10, 15 }, 5, 1)]
    [DataRow(new[] { 1000000000 }, 1, 1)]
    [DataRow(new[] { -1000000000 }, 1, 1)]
    [DataRow(new[] { 2, 4, 6, 8 }, 2, 1)]
    [DataRow(new[] { 1, 3, 5, 7 }, 2, 0)]
    [DataRow(new[] { 0, 1, 2, 3, 4 }, 5, 5)]
    [DataRow(new[] { 4, 3, 2, 1, 0 }, 5, 5)]
    [DataRow(new[] { 0, 5, 1, 6, 2, 7 }, 5, 3)]
    [DataRow(new[] { -5, -4, -3, -2, -1 }, 5, 5)]
    [DataRow(new[] { 7, 7, 7, 7 }, 3, 0)]
    [DataRow(new[] { 0, 1, 1, 2 }, 3, 3)]
    public void FindSmallestInteger_WithIntegerArrayAndValue_ReturnsMaximumMex(int[] nums, int value, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindSmallestInteger(nums, value);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}