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

using LeetCode.Algorithms.HeightChecker;

namespace LeetCode.Tests.Algorithms.HeightChecker;

public abstract class HeightCheckerTestsBase<T> where T : IHeightChecker, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 5, 1, 2, 3, 4 }, 5)]
    [DataRow(new[] { 1, 1, 4, 2, 1, 3 }, 3)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 100 }, 0)]
    [DataRow(new[] { 2, 1 }, 2)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 1, 1, 1 }, 0)]
    [DataRow(new[] { 3, 2, 1 }, 2)]
    [DataRow(new[] { 2, 3, 1 }, 3)]
    [DataRow(new[] { 1, 3, 2 }, 2)]
    [DataRow(new[] { 5, 5, 4, 4 }, 4)]
    [DataRow(new[] { 1, 2, 2, 1 }, 2)]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 10)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0)]
    [DataRow(new[] { 100, 1, 100, 1 }, 2)]
    [DataRow(new[] { 2, 2, 2, 1, 1, 1 }, 6)]
    [DataRow(new[] { 7, 3, 7, 3, 7 }, 2)]
    [DataRow(new[] { 10, 5, 6, 9, 1, 8 }, 4)]
    [DataRow(new[] { 4, 1, 3, 2, 6, 8, 4, 7, 9 }, 7)]
    [DataRow(new[] { 2, 10, 4, 1, 4, 7, 5, 3, 7, 3, 2, 3, 10, 10, 8, 3, 3, 1, 1, 4 }, 18)]
    [DataRow(new[] { 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 100)]
    [DataRow(new[] { 100, 28, 22, 22, 38, 41, 26, 70, 87, 81, 27, 24, 89, 26, 50, 39, 3, 47, 54, 22, 19, 34, 9, 43, 39, 78, 76, 1, 77, 87, 91, 44, 9, 40, 46, 40, 62, 90, 41, 24, 62, 61, 91, 23, 8, 33, 3, 96, 46, 52, 3, 71, 54, 47, 49, 75, 2, 58, 6, 91, 24, 80, 26, 16, 97, 32, 60, 45, 66, 46, 68, 33, 100, 60, 14, 76, 96, 100, 48, 38, 5, 56, 12, 27, 44, 66, 79, 47, 19, 44, 36, 90, 70, 12, 40, 88, 41, 40, 23, 11 }, 98)]
    public void HeightChecker_WithGivenArray_ReturnsCountOfIndicesWhereHeightsDoNotMatch(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HeightChecker(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}