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