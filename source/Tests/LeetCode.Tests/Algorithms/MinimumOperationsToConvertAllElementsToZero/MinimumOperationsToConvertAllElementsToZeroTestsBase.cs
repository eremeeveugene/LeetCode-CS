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

using LeetCode.Algorithms.MinimumOperationsToConvertAllElementsToZero;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToConvertAllElementsToZero;

public abstract class MinimumOperationsToConvertAllElementsToZeroTestsBase<T> where T : IMinimumOperationsToConvertAllElementsToZero, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 2 }, 1)]
    [DataRow(new[] { 3, 1, 2, 1 }, 3)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 4)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 5 }, 1)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 1, 1, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, 3)]
    [DataRow(new[] { 3, 2, 1 }, 3)]
    [DataRow(new[] { 2, 0, 2 }, 2)]
    [DataRow(new[] { 1, 0, 2, 0, 1 }, 3)]
    [DataRow(new[] { 5, 3, 5 }, 3)]
    [DataRow(new[] { 4, 2, 4, 2, 4 }, 4)]
    [DataRow(new[] { 100000 }, 1)]
    [DataRow(new[] { 100000, 1, 100000 }, 3)]
    [DataRow(new[] { 7, 0, 7, 3, 3, 0, 3 }, 4)]
    [DataRow(new[] { 1, 3, 0, 0, 4, 0, 2, 4 }, 5)]
    [DataRow(new[] { 4, 1, 0 }, 2)]
    [DataRow(new[] { 3, 3, 0, 1 }, 2)]
    [DataRow(new[] { 4, 3, 0, 4 }, 3)]
    [DataRow(new[] { 1, 4, 0, 4 }, 3)]
    [DataRow(new[] { 0, 1, 0, 4, 1, 2, 3, 1, 4 }, 6)]
    [DataRow(new[] { 4, 2, 4, 1 }, 4)]
    [DataRow(new[] { 4, 4, 1, 2 }, 3)]
    [DataRow(new[] { 4, 0, 4, 0 }, 2)]
    public void MinOperations_WithNumsArray_ReturnsMinimumOperationsToZeroAllElements(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void MinOperations_WithMaxLengthAscendingNums_ReturnsNumsLength()
    {
        // Arrange
        var nums = new int[100000];

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = i + 1;
        }

        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums);

        // Assert
        Assert.AreEqual(100000, actualResult);
    }
}