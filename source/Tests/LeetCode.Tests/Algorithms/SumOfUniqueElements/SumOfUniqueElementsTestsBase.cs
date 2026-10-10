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

using LeetCode.Algorithms.SumOfUniqueElements;

namespace LeetCode.Tests.Algorithms.SumOfUniqueElements;

public abstract class SumOfUniqueElementsTestsBase<T> where T : ISumOfUniqueElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 2 }, 4)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 15)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 100 }, 100)]
    [DataRow(new[] { 1, 1 }, 0)]
    [DataRow(new[] { 1, 2 }, 3)]
    [DataRow(new[] { 5, 5, 5 }, 0)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 4 }, 5)]
    [DataRow(new[] { 100, 99, 100 }, 99)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 0)]
    [DataRow(new[] { 10, 20, 30, 10, 20 }, 30)]
    [DataRow(new[] { 7, 8, 9, 7, 8, 9, 10 }, 10)]
    [DataRow(new[] { 1, 100, 1, 100, 50 }, 50)]
    [DataRow(new[] { 3, 3, 3, 4, 4, 5 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }, 5050)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }, 3775)]
    [DataRow(new[] { 2, 4, 6, 8 }, 20)]
    [DataRow(new[] { 9, 9, 8, 8, 7 }, 7)]
    [DataRow(new[] { 50, 50, 50, 1, 2, 2 }, 1)]
    public void SumOfUnique_WithIntegerArray_ReturnsSumOfUniqueElements(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOfUnique(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}