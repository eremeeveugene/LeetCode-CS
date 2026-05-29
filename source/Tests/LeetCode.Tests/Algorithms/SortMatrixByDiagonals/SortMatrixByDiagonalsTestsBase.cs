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

using LeetCode.Algorithms.SortMatrixByDiagonals;

namespace LeetCode.Tests.Algorithms.SortMatrixByDiagonals;

public abstract class SortMatrixByDiagonalsTestsBase<T> where T : ISortMatrixByDiagonals, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SortMatrix_WithSquareMatrix_SortsBottomLeftDiagonalsDescendingAndTopRightDiagonalsAscending(
        int[][] grid, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortMatrix(grid);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1 } }, new[] { new[] { 1 } }];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { new[] { 2, 1 }, new[] { 1, 0 } }];

        yield return [new[] { new[] { 1, 7, 3 }, new[] { 9, 8, 2 }, new[] { 4, 5, 6 } }, new[] { new[] { 8, 2, 3 }, new[] { 9, 6, 7 }, new[] { 4, 5, 1 } }];

        yield return [new[] { new[] { 2, -4, 0 }, new[] { 2, 0, -4 }, new[] { -4, 2, 0 } }, new[] { new[] { 2, -4, 0 }, new[] { 2, 0, -4 }, new[] { -4, 2, 0 } }];
    }
}
