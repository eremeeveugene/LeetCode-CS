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

using LeetCode.Algorithms.SmallestMissingMultipleOfK;

namespace LeetCode.Tests.Algorithms.SmallestMissingMultipleOfK;

public abstract class SmallestMissingMultipleOfKTestsBase<T> where T : ISmallestMissingMultipleOfK, new()
{
    [TestMethod]
    [DataRow(new[] { 8, 2, 3, 4, 6 }, 2, 10)]
    [DataRow(new[] { 1, 4, 7, 10, 15 }, 5, 5)]
    [DataRow(new[] { 1, 2, 3 }, 1, 4)]
    [DataRow(new[] { 5, 10, 15 }, 5, 20)]
    [DataRow(new[] { 3, 6, 9 }, 3, 12)]
    [DataRow(new[] { 1 }, 1, 2)]
    [DataRow(new[] { 2 }, 1, 1)]
    [DataRow(new[] { 100 }, 1, 1)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 2, 2)]
    [DataRow(new[] { 2, 4, 6, 8, 10 }, 2, 12)]
    [DataRow(new[] { 7, 14, 21 }, 7, 28)]
    [DataRow(new[] { 1, 2, 4, 5, 7 }, 3, 3)]
    [DataRow(new[] { 3 }, 3, 6)]
    [DataRow(new[] { 10, 20, 30, 40, 50 }, 10, 60)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 20)]
    [DataRow(new[] { 25, 50, 75, 100 }, 25, 125)]
    [DataRow(new[] { 6, 12, 18 }, 6, 24)]
    [DataRow(new[] { 4, 8 }, 4, 12)]
    [DataRow(new[] { 9, 18, 27 }, 9, 36)]
    [DataRow(new[] { 11, 22, 33, 44 }, 11, 55)]
    [DataRow(new[] { 60 }, 60, 120)]
    [DataRow(new[] { 1 }, 60, 60)]
    public void MissingMultiple_WithArrayAndMultipleK_ReturnsSmallestMissingPositiveMultipleOfK(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MissingMultiple(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}