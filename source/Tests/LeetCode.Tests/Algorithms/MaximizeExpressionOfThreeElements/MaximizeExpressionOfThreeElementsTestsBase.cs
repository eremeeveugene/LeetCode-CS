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

using LeetCode.Algorithms.MaximizeExpressionOfThreeElements;

namespace LeetCode.Tests.Algorithms.MaximizeExpressionOfThreeElements;

public abstract class MaximizeExpressionOfThreeElementsTestsBase<T> where T : IMaximizeExpressionOfThreeElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 2, 5 }, 8)]
    [DataRow(new[] { -2, 0, 5, -2, 4 }, 11)]
    [DataRow(new[] { 1, 2, 3 }, 4)]
    [DataRow(new[] { 3, 2, 1 }, 4)]
    [DataRow(new[] { -1, -2, -3 }, 0)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 100, 100, 100 }, 100)]
    [DataRow(new[] { -100, -100, -100 }, -100)]
    [DataRow(new[] { 100, -100, 100 }, 300)]
    [DataRow(new[] { -100, 100, -100, 100 }, 300)]
    [DataRow(new[] { 5, 5, 5, 5 }, 5)]
    [DataRow(new[] { 1, -1, 1, -1, 1 }, 3)]
    [DataRow(new[] { -5, -3, -1 }, 1)]
    [DataRow(new[] { -100, 0, 100 }, 200)]
    [DataRow(new[] { 100, 99, -100, -99 }, 299)]
    [DataRow(new[] { 7, 7, -7 }, 21)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5 }, 9)]
    [DataRow(new[] { -3, -2, -1, 0, 1, 2, 3 }, 8)]
    [DataRow(new[] { 10, -10, 20, -20, 30, -30 }, 80)]
    [DataRow(new[] { 50, -50, 50 }, 150)]
    [DataRow(new[] { 4, 8, 9, -95, -66, -52, 0 }, 112)]
    [DataRow(new[] { 65, 47, 25 }, 87)]
    [DataRow(new[] { -81, 11, -37, -30, 67, -89 }, 167)]
    [DataRow(new[] { -54, -43, 20, 57, 55, -94, 47, 83 }, 234)]
    [DataRow(new[] { 73, 10, 40, 71 }, 134)]
    public void MaximizeExpressionOfThree_WithGivenNums_ReturnsMaximumExpressionValue(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximizeExpressionOfThree(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}