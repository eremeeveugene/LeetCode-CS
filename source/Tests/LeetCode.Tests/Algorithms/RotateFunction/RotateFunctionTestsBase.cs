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

using LeetCode.Algorithms.RotateFunction;

namespace LeetCode.Tests.Algorithms.RotateFunction;

public abstract class RotateFunctionTestsBase<T> where T : IRotateFunction, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 3, 2, 6 }, 26)]
    [DataRow(new[] { 100 }, 0)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 1, 2, 3 }, 8)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { -1, -2, -3 }, -5)]
    [DataRow(new[] { -1, 0, 1 }, 2)]
    [DataRow(new[] { 10, -10, 5 }, 20)]
    [DataRow(new[] { 1, 1, 1, 1 }, 6)]
    [DataRow(new[] { 5, 1, 2, 3, 4 }, 40)]
    [DataRow(new[] { 8, 3, 1, 2 }, 29)]
    [DataRow(new[] { 1, 20, 2, 10 }, 72)]
    [DataRow(new[] { -5 }, 0)]
    [DataRow(new[] { -1, 5 }, 5)]
    [DataRow(new[] { 5, -1 }, 5)]
    [DataRow(new[] { 2, 0, 1 }, 5)]
    [DataRow(new[] { 3, 3, 3 }, 9)]
    [DataRow(new[] { 9, 8, 7, 6 }, 44)]
    [DataRow(new[] { 6, 7, 8, 9 }, 50)]
    [DataRow(new[] { -2, -1, 0, 1, 2 }, 10)]
    public void MaxRotateFunction_WithGivenNums_ReturnsMaximumRotationFunctionValue(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxRotateFunction(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}