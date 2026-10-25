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

using LeetCode.Algorithms.MaximumKToSortAPermutation;

namespace LeetCode.Tests.Algorithms.MaximumKToSortAPermutation;

public abstract class MaximumKToSortAPermutationTestsBase<T> where T : IMaximumKToSortAPermutation, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 3, 2, 1 }, 1)]
    [DataRow(new[] { 0, 1, 3, 2 }, 2)]
    [DataRow(new[] { 3, 2, 1, 0 }, 0)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 0, 1 }, 0)]
    [DataRow(new[] { 1, 0 }, 0)]
    [DataRow(new[] { 0, 1, 2, 3 }, 0)]
    [DataRow(new[] { 2, 1, 0 }, 0)]
    [DataRow(new[] { 0, 2, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3, 0 }, 0)]
    [DataRow(new[] { 0, 1, 2, 3, 5, 4 }, 4)]
    [DataRow(new[] { 0, 5, 2, 3, 4, 1 }, 1)]
    [DataRow(new[] { 0, 1, 6, 3, 4, 5, 2 }, 2)]
    [DataRow(new[] { 0, 1, 2, 3, 6, 5, 4 }, 4)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5, 7, 6 }, 6)]
    [DataRow(new[] { 0, 1, 2, 7, 4, 5, 6, 3 }, 3)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 7, 6, 5 }, 5)]
    [DataRow(new[] { 0, 1, 2, 3, 7, 5, 6, 4 }, 4)]
    [DataRow(new[] { 0, 1, 3, 7, 4, 5, 6, 2 }, 2)]
    [DataRow(new[] { 0, 7, 2, 5, 4, 3, 6, 1 }, 1)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 9, 8 }, 8)]
    [DataRow(new[] { 0, 1, 2, 11, 4, 5, 6, 7, 8, 9, 10, 3 }, 3)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 13, 6, 7, 8, 9, 10, 11, 12, 5, 14, 15 }, 5)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5, 6, 15, 8, 9, 10, 11, 12, 13, 14, 7 }, 7)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 14 }, 14)]
    public void SortPermutation_WithNums_ReturnsMaximumK(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortPermutation(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}