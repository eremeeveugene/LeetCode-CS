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

using LeetCode.Algorithms.MaximumDifferenceBetweenAdjacentElementsInCircularArray;

namespace LeetCode.Tests.Algorithms.MaximumDifferenceBetweenAdjacentElementsInCircularArray;

public abstract class MaximumDifferenceBetweenAdjacentElementsInCircularArrayTestsBase<T>
    where T : IMaximumDifferenceBetweenAdjacentElementsInCircularArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 4 }, 3)]
    [DataRow(new[] { -5, -10, -5 }, 5)]
    [DataRow(new[] { 1, 1 }, 0)]
    [DataRow(new[] { -100, 100 }, 200)]
    [DataRow(new[] { 100, -100 }, 200)]
    [DataRow(new[] { 5, 5, 5 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 4)]
    [DataRow(new[] { 0, 0, 0, 0 }, 0)]
    [DataRow(new[] { 10, -10, 10, -10 }, 20)]
    [DataRow(new[] { -1, -2, -3, -4, -5, -6 }, 5)]
    [DataRow(new[] { 50, 51, 52, 53, -50 }, 103)]
    [DataRow(new[] { 7, 7, 7, 8 }, 1)]
    [DataRow(new[] { -100, -100, 100, 100 }, 200)]
    [DataRow(new[] { 3, 9, 1, 8, 2 }, 8)]
    [DataRow(new[] { 1, 100, 1 }, 99)]
    [DataRow(new[] { -50, 0, 50, 0 }, 50)]
    [DataRow(new[] { 20, 30, 25, 28, 22, 90 }, 70)]
    [DataRow(new[] { -7, 3 }, 10)]
    [DataRow(new[] { -50, 49, 0 }, 99)]
    public void MaxAdjacentDistance_WithInputArray_ReturnsLargestDifferenceBetweenAdjacentElements(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxAdjacentDistance(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}