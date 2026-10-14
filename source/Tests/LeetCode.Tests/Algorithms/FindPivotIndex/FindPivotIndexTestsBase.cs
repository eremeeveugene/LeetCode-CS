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

using LeetCode.Algorithms.FindPivotIndex;

namespace LeetCode.Tests.Algorithms.FindPivotIndex;

public abstract class FindPivotIndexTestsBase<T> where T : IFindPivotIndex, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, -1, 8, 4 }, 3)]
    [DataRow(new[] { 1, -1, 4 }, 2)]
    [DataRow(new[] { 2, 5 }, -1)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { -1 }, 0)]
    [DataRow(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [DataRow(new[] { 1, 2, 3 }, -1)]
    [DataRow(new[] { 2, 1, -1 }, 0)]
    [DataRow(new[] { -1, -1, 0, 1, 1, 0 }, 5)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 1, 0 }, 0)]
    [DataRow(new[] { 0, 1 }, 1)]
    [DataRow(new[] { -1, -1, -1, -1, -1, 0 }, 2)]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5, 5 }, 3)]
    [DataRow(new[] { 3, -3, 0, 3, -3 }, 2)]
    [DataRow(new[] { 1000, -1000, 1000 }, 0)]
    [DataRow(new[] { -5, 5, 0, 0 }, 2)]
    [DataRow(new[] { 0, -1, 1 }, 0)]
    [DataRow(new[] { 10, 2, 8 }, -1)]
    public void PivotIndex_WithIntegerArray_ReturnsIndexWhereLeftAndRightSumsAreEqualOrMinusOne(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PivotIndex(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}