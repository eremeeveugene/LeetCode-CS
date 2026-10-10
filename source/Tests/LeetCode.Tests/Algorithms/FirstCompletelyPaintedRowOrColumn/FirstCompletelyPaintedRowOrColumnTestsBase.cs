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

using LeetCode.Algorithms.FirstCompletelyPaintedRowOrColumn;

namespace LeetCode.Tests.Algorithms.FirstCompletelyPaintedRowOrColumn;

public abstract class FirstCompletelyPaintedRowOrColumnTestsBase<T> where T : IFirstCompletelyPaintedRowOrColumn, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FirstCompleteIndex_WithSequenceAndMatrix_ReturnsFirstCompletedRowOrColumnIndex(int[] arr, int[][] mat, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FirstCompleteIndex(arr, mat);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 3, 4, 2 }, new[] { new[] { 1, 4 }, new[] { 2, 3 } }, 2];

        yield return [new[] { 2, 8, 7, 4, 1, 3, 5, 6, 9 }, new[] { new[] { 3, 2, 5 }, new[] { 1, 4, 6 }, new[] { 8, 7, 9 } }, 3];

        yield return [new[] { 1 }, new[] { new[] { 1 } }, 0];

        yield return [new[] { 1, 2 }, new[] { new[] { 2, 1 } }, 0];

        yield return [new[] { 2, 1 }, new[] { new[] { 1 }, new[] { 2 } }, 0];

        yield return [new[] { 5, 4, 1, 2, 3 }, new[] { new[] { 4, 2, 1, 5, 3 } }, 0];

        yield return [new[] { 5, 3, 1, 2, 4 }, new[] { new[] { 5 }, new[] { 2 }, new[] { 1 }, new[] { 3 }, new[] { 4 } }, 0];

        yield return [new[] { 4, 3, 2, 1 }, new[] { new[] { 1, 3 }, new[] { 4, 2 } }, 2];

        yield return [new[] { 6, 1, 2, 4, 3, 5 }, new[] { new[] { 6, 4, 1 }, new[] { 5, 3, 2 } }, 2];

        yield return [new[] { 6, 2, 5, 3, 4, 1 }, new[] { new[] { 4, 1 }, new[] { 5, 2 }, new[] { 3, 6 } }, 2];

        yield return [new[] { 5, 8, 1, 3, 4, 6, 9, 7, 2 }, new[] { new[] { 9, 4, 1 }, new[] { 3, 2, 5 }, new[] { 8, 6, 7 } }, 6];

        yield return [new[] { 6, 10, 1, 9, 7, 8, 3, 2, 11, 5, 4, 12 }, new[] { new[] { 8, 4, 10, 11 }, new[] { 9, 7, 3, 1 }, new[] { 12, 5, 2, 6 } }, 6];

        yield return [new[] { 7, 1, 9, 6, 12, 3, 8, 4, 5, 2, 11, 10 }, new[] { new[] { 7, 8, 9 }, new[] { 5, 3, 2 }, new[] { 4, 11, 12 }, new[] { 1, 10, 6 } }, 6];

        yield return [new[] { 13, 14, 8, 9, 12, 6, 5, 3, 10, 11, 1, 2, 16, 7, 4, 15 }, new[] { new[] { 3, 14, 15, 11 }, new[] { 12, 10, 13, 16 }, new[] { 4, 7, 5, 9 }, new[] { 2, 1, 6, 8 } }, 11];

        yield return [new[] { 5, 3, 1, 6, 9, 2, 10, 11, 12, 8, 7, 4 }, new[] { new[] { 11, 6, 1, 3, 8, 2 }, new[] { 7, 10, 9, 4, 12, 5 } }, 4];

        yield return [new[] { 3, 5, 9, 4, 12, 8, 11, 7, 2, 10, 6, 1 }, new[] { new[] { 5, 1 }, new[] { 2, 12 }, new[] { 11, 8 }, new[] { 9, 6 }, new[] { 3, 10 }, new[] { 4, 7 } }, 6];

        yield return [new[] { 20, 18, 14, 15, 6, 4, 12, 8, 25, 1, 24, 5, 19, 10, 17, 2, 7, 23, 3, 16, 13, 11, 9, 22, 21 }, new[] { new[] { 16, 18, 12, 25, 23 }, new[] { 14, 5, 17, 21, 24 }, new[] { 10, 11, 3, 22, 15 }, new[] { 2, 8, 19, 13, 4 }, new[] { 9, 20, 1, 6, 7 } }, 17];

        yield return [new[] { 21, 3, 7, 8, 10, 4, 11, 14, 15, 6, 20, 1, 19, 13, 17, 12, 2, 5, 9, 18, 16 }, new[] { new[] { 11, 20, 5, 17, 2, 12, 1 }, new[] { 21, 14, 7, 9, 6, 19, 10 }, new[] { 15, 18, 3, 4, 13, 16, 8 } }, 8];

        yield return [new[] { 1, 7, 4, 5, 6, 10, 8, 3, 9, 2 }, new[] { new[] { 7, 4, 9, 3, 8, 2, 10, 1, 5, 6 } }, 0];

        yield return [new[] { 7, 1, 6, 3, 4, 9, 5, 2, 10, 8 }, new[] { new[] { 8 }, new[] { 2 }, new[] { 6 }, new[] { 4 }, new[] { 7 }, new[] { 10 }, new[] { 5 }, new[] { 9 }, new[] { 1 }, new[] { 3 } }, 0];
    }
}