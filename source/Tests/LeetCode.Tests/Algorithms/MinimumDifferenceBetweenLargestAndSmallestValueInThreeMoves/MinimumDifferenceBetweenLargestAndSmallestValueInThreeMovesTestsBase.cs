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

using LeetCode.Algorithms.MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves;

namespace LeetCode.Tests.Algorithms.MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves;

public abstract class MinimumDifferenceBetweenLargestAndSmallestValueInThreeMovesTestsBase<T>
    where T : IMinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 3, 2, 4 }, 0)]
    [DataRow(new[] { 1, 5, 0, 10, 14 }, 1)]
    [DataRow(new[] { 3, 100, 20 }, 0)]
    [DataRow(new[] { 6, 6, 0, 1, 1, 4, 6 }, 2)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4 }, 0)]
    [DataRow(new[] { -1000000000, 1000000000, 0, 5 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { -1000000000, 0, 0, 0, 1000000000 }, 0)]
    [DataRow(new[] { -1000000000, 1000000000, 1000000000, 1000000000, 1000000000 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4)]
    [DataRow(new[] { 10, 1, 10, 1, 10, 1, 10, 1 }, 9)]
    [DataRow(new[] { 1, 100, 200, 300, 400, 500, 600 }, 299)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 0, 100 }, 0)]
    [DataRow(new[] { -5, -4, -3, -2, -1, 0, 1 }, 3)]
    [DataRow(new[] { 9, 1, 9, 2, 9, 3, 9, 4, 9 }, 5)]
    [DataRow(new[] { 100, 1, 2, 3, 4, 5, 6, 200 }, 4)]
    [DataRow(new[] { 1000000000, 1000000000, -1000000000, -1000000000, 0, 0, 7 }, 1000000000)]
    public void MinDifference_WithUpToThreeChanges_ReturnsSmallestPossibleValueRange(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinDifference(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}