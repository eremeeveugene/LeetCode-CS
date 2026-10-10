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

using LeetCode.Algorithms.MinimumIncrementToMakeArrayUnique;

namespace LeetCode.Tests.Algorithms.MinimumIncrementToMakeArrayUnique;

public abstract class MinimumIncrementToMakeArrayUniqueTestsBase<T> where T : IMinimumIncrementToMakeArrayUnique, new()
{
    [TestMethod]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 1, 2, 2 }, 1)]
    [DataRow(new[] { 3, 2, 1, 2, 1, 7 }, 6)]
    [DataRow(new[] { 9, 7, 6, 5, 1, 0 }, 0)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, 44)]
    [DataRow(new[] { 1, 2, 3, 1, 3, 2, 2, 1, 3, 2, 3, 1, 3, 2, 1, 3, 1, 2 }, 135)]
    [DataRow(new[] { 5 }, 0)]
    [DataRow(new[] { 100000 }, 0)]
    [DataRow(new[] { 0, 0 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 3)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 10)]
    [DataRow(new[] { 0, 1, 2, 3 }, 0)]
    [DataRow(new[] { 3, 3, 3, 3, 4, 4 }, 13)]
    [DataRow(new[] { 2, 2, 2, 5, 5 }, 4)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 9)]
    [DataRow(new[] { 4, 3, 2, 1, 1, 1 }, 9)]
    [DataRow(new[] { 100000, 100000, 100000 }, 3)]
    [DataRow(new[] { 0, 100000, 100000, 0 }, 2)]
    [DataRow(new[] { 7, 7, 8, 8, 9, 9, 10, 10 }, 16)]
    [DataRow(new[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, 45)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 5 }, 1)]
    [DataRow(new[] { 0, 0, 0, 3, 3, 3, 3 }, 9)]
    [DataRow(new[] { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 }, 66)]
    public void MinIncrementForUnique_WithIntegerArray_ReturnsMinimumMovesToMakeElementsUnique(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinIncrementForUnique(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}