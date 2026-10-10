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

using LeetCode.Algorithms.SquaresOfSortedArray;

namespace LeetCode.Tests.Algorithms.SquaresOfSortedArray;

public abstract class SquaresOfSortedArrayTestsBase<T> where T : ISquaresOfSortedArray, new()
{
    [TestMethod]
    [DataRow(new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 })]
    [DataRow(new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 })]
    [DataRow(new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { -1 }, new[] { 1 })]
    [DataRow(new[] { 5 }, new[] { 25 })]
    [DataRow(new[] { -5, -5 }, new[] { 25, 25 })]
    [DataRow(new[] { -3, 0, 3 }, new[] { 0, 9, 9 })]
    [DataRow(new[] { -10000, 10000 }, new[] { 100000000, 100000000 })]
    [DataRow(new[] { -10000, -9999, 9999, 10000 }, new[] { 99980001, 99980001, 100000000, 100000000 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 4, 9, 16, 25 })]
    [DataRow(new[] { -5, -4, -3, -2, -1 }, new[] { 1, 4, 9, 16, 25 })]
    [DataRow(new[] { -1, 0, 0, 1 }, new[] { 0, 0, 1, 1 })]
    [DataRow(new[] { -2, -1, 0, 1, 2, 3 }, new[] { 0, 1, 1, 4, 4, 9 })]
    [DataRow(new[] { 2, 2, 2, 2 }, new[] { 4, 4, 4, 4 })]
    [DataRow(new[] { -8, -1, 1, 5, 6, 7 }, new[] { 1, 1, 25, 36, 49, 64 })]
    [DataRow(new[] { -100, -50, 0, 50, 100 }, new[] { 0, 2500, 2500, 10000, 10000 })]
    [DataRow(new[] { -7, -7, 7 }, new[] { 49, 49, 49 })]
    [DataRow(new[] { -3, -2, -1, 4 }, new[] { 1, 4, 9, 16 })]
    [DataRow(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
    [DataRow(new[] { -9999, 0, 9998 }, new[] { 0, 99960004, 99980001 })]
    [DataRow(new[] { -4, -3, 1, 2, 5, 6 }, new[] { 1, 4, 9, 16, 25, 36 })]
    public void SortedSquares_GivenArrayOfIntegers_ReturnsSortedArrayOfSquares(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortedSquares(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}