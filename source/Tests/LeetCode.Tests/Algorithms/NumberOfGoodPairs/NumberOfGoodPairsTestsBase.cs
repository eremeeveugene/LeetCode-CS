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

using LeetCode.Algorithms.NumberOfGoodPairs;

namespace LeetCode.Tests.Algorithms.NumberOfGoodPairs;

public abstract class NumberOfGoodPairsTestsBase<T> where T : INumberOfGoodPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 1, 1, 3 }, 4)]
    [DataRow(new[] { 1, 1, 1, 1 }, 6)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(
        new[]
        {
            6,
            5,
            1,
            5,
            7,
            7,
            9,
            1,
            5,
            7,
            1,
            6,
            10,
            9,
            7,
            4,
            1,
            8,
            7,
            1,
            1,
            8,
            6,
            4,
            7,
            4,
            10,
            5,
            3,
            9,
            10,
            1,
            9,
            5,
            5,
            4,
            1,
            7,
            4,
            2,
            9,
            2,
            6,
            6,
            4,
            2,
            10,
            3,
            5,
            3,
            6,
            4,
            7,
            4,
            6,
            4,
            4,
            6,
            3,
            4,
            10,
            1,
            10,
            6,
            10,
            4,
            9,
            6,
            6,
            4,
            8,
            6,
            9,
            5,
            4
        },
        303)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 100, 100, 100 }, 3)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 10)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0)]
    [DataRow(new[] { 2, 2, 3, 3, 4, 4 }, 3)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 6)]
    [DataRow(new[] { 100, 1, 100, 1, 100 }, 4)]
    [DataRow(new[] { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 }, 4950)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }, 0)]
    [DataRow(new[] { 3, 3, 3, 1, 1, 2 }, 4)]
    [DataRow(new[] { 2, 2, 1, 3, 3, 1, 3, 3, 1, 1 }, 13)]
    [DataRow(new[] { 1, 3, 3, 2, 2, 2, 4, 1, 4, 5, 5, 2, 1, 4, 4, 3, 1, 3, 3, 3, 2, 1, 5, 4, 5, 4, 1, 5, 1, 3 }, 77)]
    [DataRow(new[] { 2, 5, 10, 1, 10, 9, 6, 8, 6, 7, 9, 3, 6, 9, 3, 10, 4, 3, 1, 2, 6, 8, 3, 6, 10, 4, 1, 5, 7, 6, 2, 10, 1, 6, 7, 3, 4, 3, 7, 3, 8, 10, 1, 3, 6, 1, 2, 2, 7, 9 }, 119)]
    [DataRow(new[] { 80, 95, 7, 6, 62, 63, 89, 18, 63, 54, 83, 18, 49, 70, 1, 23, 6, 25, 4, 58, 26, 44, 66, 63, 43, 92, 43, 51, 13, 67, 3, 61, 31, 79, 6, 20, 62, 36, 80, 94, 50, 87, 29, 54, 54, 61, 11, 56, 92, 6, 10, 53, 73, 16, 44, 34, 12, 22, 19, 57, 59, 28, 9, 2, 60, 55, 41, 76, 46, 6, 52, 24, 25, 29, 62, 96, 65, 38, 71, 74, 49, 79, 86, 53, 72, 3, 97, 51, 46, 3, 84, 47, 1, 10, 20, 46, 73, 46, 86, 86 }, 47)]
    [DataRow(new[] { 1, 7, 4, 3, 3, 2, 6, 3, 6, 7, 6, 7, 5, 3, 7, 6, 5, 7, 1, 1, 4, 1, 3, 7, 1, 7, 4, 1, 6, 3, 1, 4, 3, 1, 2, 4, 2, 5, 7, 7, 2, 1, 3, 6, 2, 2, 5, 6, 5, 2, 4, 1, 1, 3, 4, 4, 7, 4, 2, 4, 6, 5, 7, 2, 3, 4, 1, 5, 3, 7, 6, 6, 5, 4, 5, 1, 2, 7, 3, 6, 2, 6, 3, 6, 3, 7, 1, 2, 2, 6, 5, 5, 3, 4, 2, 5, 4, 4, 5, 2 }, 666)]
    public void NumIdenticalPairs_WithIntegerArray_ReturnsCountOfGoodPairsWhereElementsAreEqualAndIndexIsOrdered(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumIdenticalPairs(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}