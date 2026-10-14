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

using LeetCode.Algorithms.MinimumMovesToEqualArrayElements3;

namespace LeetCode.Tests.Algorithms.MinimumMovesToEqualArrayElements3;

public abstract class MinimumMovesToEqualArrayElements3TestsBase<T> where T : IMinimumMovesToEqualArrayElements3, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 3 }, 3)]
    [DataRow(new[] { 4, 4, 5 }, 2)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 100 }, 0)]
    [DataRow(new[] { 1, 1 }, 0)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 100, 1 }, 99)]
    [DataRow(new[] { 5, 5, 5 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 10)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 10)]
    [DataRow(new[] { 10, 20, 30 }, 30)]
    [DataRow(new[] { 7, 7, 8 }, 2)]
    [DataRow(new[] { 1, 1, 1, 100 }, 297)]
    [DataRow(new[] { 99, 100, 98, 100 }, 3)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 30)]
    [DataRow(new[] { 50, 50, 50, 50, 1 }, 49)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 41)]
    [DataRow(new[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 }, 0)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }, 4950)]
    [DataRow(new[] { 64, 12, 77, 3, 45 }, 184)]
    public void MinMoves_WithNumsArray_ReturnsMinimumMovesToEqualArrayElements(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinMoves(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}