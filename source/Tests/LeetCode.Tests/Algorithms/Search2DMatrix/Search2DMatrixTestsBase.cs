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

using LeetCode.Algorithms.Search2DMatrix;

namespace LeetCode.Tests.Algorithms.Search2DMatrix;

public abstract class Search2DMatrixTestsBase<T> where T : ISearch2DMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SearchMatrix_WithMatrixAndTarget_ReturnsWhetherTargetExists(int[][] matrix, int target, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SearchMatrix(matrix, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 3, true];

        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 13, false];

        yield return [new[] { new[] { 1 } }, 1, true];

        yield return [new[] { new[] { 1 } }, 2, false];

        yield return [new[] { new[] { 1, 3 } }, 3, true];

        yield return [new[] { new[] { 1, 3 } }, 2, false];

        yield return [new[] { new[] { 1 }, new[] { 3 } }, 3, true];

        yield return [new[] { new[] { 1 }, new[] { 3 } }, 2, false];

        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 1, true];

        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 60, true];

        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 0, false];

        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 61, false];

        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 7, true];

        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 10, true];

        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 8, false];

        yield return [new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } }, 9, false];

        yield return [new[] { new[] { -10, -5, 0, 3 }, new[] { 5, 8, 12, 15 } }, -5, true];

        yield return [new[] { new[] { -10, -5, 0, 3 }, new[] { 5, 8, 12, 15 } }, -6, false];

        yield return [new[] { new[] { -10, -5, 0, 3 }, new[] { 5, 8, 12, 15 } }, 0, true];

        yield return [new[] { new[] { int.MinValue, 0 }, new[] { int.MaxValue - 1, int.MaxValue } }, int.MaxValue, true];

        yield return [new[] { new[] { int.MinValue, 0 }, new[] { int.MaxValue - 1, int.MaxValue } }, int.MinValue, true];

        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, 5, true];

        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, 6, false];

        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 }, new[] { 5 } }, 4, true];

        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 }, new[] { 5 } }, 6, false];

        yield return [new[] { new[] { 2, 4, 6 }, new[] { 8, 10, 12 }, new[] { 14, 16, 18 } }, 12, true];

        yield return [new[] { new[] { 2, 4, 6 }, new[] { 8, 10, 12 }, new[] { 14, 16, 18 } }, 13, false];
    }
}