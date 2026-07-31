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

using LeetCode.Algorithms.FindTheMaximumLengthOfValidSubsequence1;

namespace LeetCode.Tests.Algorithms.FindTheMaximumLengthOfValidSubsequence1;

public abstract class FindTheMaximumLengthOfValidSubsequence1TestsBase<T> where T : IFindTheMaximumLengthOfValidSubsequence1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 1, 3 }, 2)]
    [DataRow(new[] { 1, 2, 1, 1, 2, 1, 2 }, 6)]
    [DataRow(new[] { 2, 3 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { 2, 4, 6, 8 }, 4)]
    [DataRow(new[] { 1, 3, 5, 7 }, 4)]
    [DataRow(new[] { 1, 1, 1, 1 }, 4)]
    [DataRow(new[] { 2, 2, 2, 2 }, 4)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1 }, 7)]
    [DataRow(new[] { 2, 1, 2, 1, 2, 1 }, 6)]
    [DataRow(new[] { 5 }, 1)]
    [DataRow(new[] { 4 }, 1)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 2, 1 }, 2)]
    [DataRow(new[] { 3, 3, 3, 4, 4, 4 }, 3)]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 9)]
    [DataRow(new[] { 10, 20, 30, 40 }, 4)]
    [DataRow(new[] { 1, 3, 2, 4, 6, 8, 5, 7 }, 4)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, 6)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 4, 4 }, 4)]
    [DataRow(new[] { 7, 7, 7, 7, 7 }, 5)]
    [DataRow(new[] { 2, 4, 1, 3, 6, 8, 5, 7, 9 }, 5)]
    [DataRow(new[] { 0, 1, 0, 1, 0 }, 5)]
    [DataRow(new[] { 100, 201, 302, 403 }, 4)]
    public void MaximumLength_WithInputArray_ReturnsLengthOfLongestValidSubsequence(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumLength(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}