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

using LeetCode.Algorithms.MinimumCapacityBox;

namespace LeetCode.Tests.Algorithms.MinimumCapacityBox;

public abstract class MinimumCapacityBoxTestsBase<T> where T : IMinimumCapacityBox, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 5, 3, 7 }, 3, 2)]
    [DataRow(new[] { 3, 5, 4, 3 }, 2, 0)]
    [DataRow(new[] { 3 }, 5, -1)]
    [DataRow(new[] { 1 }, 1, 0)]
    [DataRow(new[] { 1 }, 2, -1)]
    [DataRow(new[] { 5, 5, 5 }, 5, 0)]
    [DataRow(new[] { 5, 5, 5 }, 6, -1)]
    [DataRow(new[] { 2, 4, 6, 8 }, 5, 2)]
    [DataRow(new[] { 8, 6, 4, 2 }, 5, 1)]
    [DataRow(new[] { 10, 3, 7, 3, 9 }, 3, 1)]
    [DataRow(new[] { 10, 3, 7, 3, 9 }, 4, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 4)]
    [DataRow(new[] { 100, 50, 75 }, 60, 2)]
    [DataRow(new[] { 4, 4, 4, 4 }, 1, 0)]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, 10, -1)]
    [DataRow(new[] { 1000000000, 1 }, 1000000000, 0)]
    [DataRow(new[] { 6, 2, 6, 2 }, 2, 1)]
    [DataRow(new[] { 3, 9, 3, 9, 3 }, 4, 1)]
    [DataRow(new[] { 7, 1, 7 }, 1, 1)]
    public void MinimumIndex_WithCapacitiesAndItemSize_ReturnsIndexOfSmallestSufficientCapacity(int[] capacities, int itemSize, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumIndex(capacities, itemSize);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}