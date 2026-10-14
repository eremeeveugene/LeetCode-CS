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

using LeetCode.Algorithms.MinimumIndexOfValidSplit;

namespace LeetCode.Tests.Algorithms.MinimumIndexOfValidSplit;

public abstract class MinimumIndexOfValidSplitTestsBase<T> where T : IMinimumIndexOfValidSplit, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 2 }, 2)]
    [DataRow(new[] { 2, 1, 3, 1, 1, 1, 7, 1, 2, 1 }, 4)]
    [DataRow(new[] { 3, 3, 3, 3, 7, 2, 2 }, -1)]
    [DataRow(new[] { 1, 1 }, 0)]
    [DataRow(new[] { 2, 2, 2 }, 0)]
    [DataRow(new[] { 1, 2, 1 }, -1)]
    [DataRow(new[] { 1, 1, 2 }, -1)]
    [DataRow(new[] { 2, 1, 1 }, -1)]
    [DataRow(new[] { 1, 2, 2, 2, 2 }, 2)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 0)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, -1)]
    [DataRow(new[] { 3, 1, 3, 2, 3, 3 }, 0)]
    [DataRow(new[] { 1, 2, 3, 1, 1 }, -1)]
    [DataRow(new[] { 9, 9, 1, 9, 2, 9, 3, 9 }, 0)]
    [DataRow(new[] { 1, 1, 1, 2, 3, 4, 5 }, -1)]
    [DataRow(new[] { 1000000000, 1000000000, 1 }, -1)]
    [DataRow(new[] { 7, 1, 7, 2, 7, 3, 7, 4, 7 }, -1)]
    [DataRow(new[] { 5, 5, 7, 5, 5, 5 }, 0)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 }, 0)]
    [DataRow(new[] { 2, 7, 2, 6, 2, 2, 6, 2, 2, 2, 7, 2 }, 0)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 7, 1, 1, 1 }, 0)]
    [DataRow(new[] { 4, 4, 4, 4, 4, 8, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 }, 0)]
    public void MinimumIndex_WithMajorityElementInArray_ReturnsMinimumIndexOfValidSplit(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumIndex(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}