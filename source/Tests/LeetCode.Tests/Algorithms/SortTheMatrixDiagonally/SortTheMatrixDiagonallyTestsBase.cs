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

using LeetCode.Algorithms.SortTheMatrixDiagonally;

namespace LeetCode.Tests.Algorithms.SortTheMatrixDiagonally;

public abstract class SortTheMatrixDiagonallyTestsBase<T> where T : ISortTheMatrixDiagonally, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void DiagonalSort_WithUnsortedMatrixDiagonals_ReturnsMatrixWithEachDiagonalSortedAscending(int[][] mat, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DiagonalSort(mat);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 3, 3, 1, 1 }, new[] { 2, 2, 1, 2 }, new[] { 1, 1, 1, 2 } },
            new[] { new[] { 1, 1, 1, 1 }, new[] { 1, 2, 2, 2 }, new[] { 1, 2, 3, 3 } }
        ];

        yield return
        [
            new[]
            {
                new[] { 11, 25, 66, 1, 69, 7 },
                new[] { 23, 55, 17, 45, 15, 52 },
                new[] { 75, 31, 36, 44, 58, 8 },
                new[] { 22, 27, 33, 25, 68, 4 },
                new[] { 84, 28, 14, 11, 5, 50 }
            },
            new[]
            {
                new[] { 5, 17, 4, 1, 52, 7 },
                new[] { 11, 11, 25, 45, 8, 69 },
                new[] { 14, 23, 25, 44, 58, 15 },
                new[] { 22, 27, 31, 36, 50, 66 },
                new[] { 84, 28, 75, 33, 55, 68 }
            }
        ];
    }
}