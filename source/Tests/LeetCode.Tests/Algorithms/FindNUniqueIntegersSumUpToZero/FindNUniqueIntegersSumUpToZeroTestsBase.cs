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

using LeetCode.Algorithms.FindNUniqueIntegersSumUpToZero;

namespace LeetCode.Tests.Algorithms.FindNUniqueIntegersSumUpToZero;

public abstract class FindNUniqueIntegersSumUpToZeroTestsBase<T> where T : IFindNUniqueIntegersSumUpToZero, new()
{
    [TestMethod]
    [DataRow(1, new[] { 0 })]
    [DataRow(2, new[] { -1, 1 })]
    [DataRow(3, new[] { -1, 0, 1 })]
    [DataRow(4, new[] { -2, -1, 1, 2 })]
    [DataRow(5, new[] { -2, -1, 0, 1, 2 })]
    [DataRow(6, new[] { -3, -2, -1, 1, 2, 3 })]
    [DataRow(7, new[] { -3, -2, -1, 0, 1, 2, 3 })]
    [DataRow(8, new[] { -4, -3, -2, -1, 1, 2, 3, 4 })]
    [DataRow(9, new[] { -4, -3, -2, -1, 0, 1, 2, 3, 4 })]
    [DataRow(10, new[] { -5, -4, -3, -2, -1, 1, 2, 3, 4, 5 })]
    [DataRow(11, new[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 })]
    [DataRow(12, new[] { -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6 })]
    [DataRow(13, new[] { -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6 })]
    [DataRow(14, new[] { -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7 })]
    [DataRow(15, new[] { -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7 })]
    [DataRow(16, new[] { -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8 })]
    [DataRow(17, new[] { -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8 })]
    [DataRow(18, new[] { -9, -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    [DataRow(19, new[] { -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    [DataRow(20, new[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    public void SumZero_WithCountOfUniqueIntegers_ReturnsArraySummingToZero(int n, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumZero(n);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }
}