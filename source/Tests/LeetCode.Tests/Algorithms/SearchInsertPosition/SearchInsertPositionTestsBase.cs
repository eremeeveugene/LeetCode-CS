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

using LeetCode.Algorithms.SearchInsertPosition;

namespace LeetCode.Tests.Algorithms.SearchInsertPosition;

public abstract class SearchInsertPositionTestsBase<T> where T : ISearchInsertPosition, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 5, 6 }, 2, 1)]
    [DataRow(new[] { 1, 3, 5, 6 }, 5, 2)]
    [DataRow(new[] { 1, 3, 5, 6 }, 7, 4)]
    [DataRow(new[] { 1 }, 0, 0)]
    [DataRow(new[] { 1 }, 1, 0)]
    [DataRow(new[] { 1 }, 2, 1)]
    [DataRow(new[] { 1, 3 }, 2, 1)]
    [DataRow(new[] { 1, 3 }, 0, 0)]
    [DataRow(new[] { 1, 3 }, 4, 2)]
    [DataRow(new[] { -10, -5, 0, 5, 10 }, -7, 1)]
    [DataRow(new[] { -10, -5, 0, 5, 10 }, -10, 0)]
    [DataRow(new[] { -10, -5, 0, 5, 10 }, 10, 4)]
    [DataRow(new[] { -10, -5, 0, 5, 10 }, 11, 5)]
    [DataRow(new[] { -10, -5, 0, 5, 10 }, -11, 0)]
    [DataRow(new[] { -10000, 10000 }, 0, 1)]
    [DataRow(new[] { -10000, 10000 }, -10000, 0)]
    [DataRow(new[] { -10000, 10000 }, 10000, 1)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 7, 3)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 12, 5)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 1, 0)]
    public void SearchInsert_WithSortedArrayAndTarget_ReturnsInsertIndexOrTargetIndex(int[] nums, int target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SearchInsert(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}