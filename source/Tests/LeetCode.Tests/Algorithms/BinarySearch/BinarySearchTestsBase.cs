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

using LeetCode.Algorithms.BinarySearch;

namespace LeetCode.Tests.Algorithms.BinarySearch;

public abstract class BinarySearchTestsBase<T> where T : IBinarySearch, new()
{
    [TestMethod]
    [DataRow(new[] { 0 }, 0, 0)]
    [DataRow(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [DataRow(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    [DataRow(new[] { 1, 2, 3 }, 5, -1)]
    [DataRow(new[] { 1, 2, 3 }, 0, -1)]
    [DataRow(new[] { 1, 2, 3 }, 1, 0)]
    [DataRow(new[] { 1, 2, 3 }, 2, 1)]
    [DataRow(new[] { 1, 2, 3 }, 3, 2)]
    [DataRow(new[] { 5 }, 5, 0)]
    [DataRow(new[] { 5 }, 3, -1)]
    [DataRow(new[] { 5 }, 7, -1)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 7, 3)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 8, -1)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 1, 0)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 9, 4)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 10, -1)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 6, 2)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 12, 5)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 13, -1)]
    [DataRow(new[] { -5, -3, -1, 0, 2 }, -3, 1)]
    [DataRow(new[] { -5, -3, -1, 0, 2 }, 2, 4)]
    [DataRow(new[] { -5, -3, -1, 0, 2 }, 3, -1)]
    [DataRow(new[] { 1, 4, 7, 10 }, 4, 1)]
    [DataRow(new[] { 10, 20, 30 }, 25, -1)]
    public void Search_WithSortedArrayAndTarget_ReturnsTargetIndexOrMinusOne(int[] nums, int target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Search(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}