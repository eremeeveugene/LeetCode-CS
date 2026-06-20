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

using LeetCode.Algorithms.ModifyTheMatrix;

namespace LeetCode.Tests.Algorithms.ModifyTheMatrix;

public abstract class ModifyTheMatrixTestsBase<T> where T : IModifyTheMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ModifiedMatrix_WithMatrixContainingNegativeOnes_ReplacesEachWithColumnMaximum(int[][] matrix, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ModifiedMatrix(matrix);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, -1 }, new[] { 4, -1, 6 }, new[] { 7, 8, 9 } }, new[] { new[] { 1, 2, 9 }, new[] { 4, 8, 6 }, new[] { 7, 8, 9 } }];

        yield return [new[] { new[] { 3, -1 }, new[] { 5, 2 } }, new[] { new[] { 3, 2 }, new[] { 5, 2 } }];

        yield return [new[] { new[] { -1, 2 }, new[] { 3, 4 } }, new[] { new[] { 3, 2 }, new[] { 3, 4 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { new[] { 1, 2 }, new[] { 3, 4 } }];

        yield return [new[] { new[] { -1, -1 }, new[] { 1, 2 } }, new[] { new[] { 1, 2 }, new[] { 1, 2 } }];

        yield return [new[] { new[] { 5, -1 }, new[] { -1, 5 } }, new[] { new[] { 5, 5 }, new[] { 5, 5 } }];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, new[] { new[] { 0, 0 }, new[] { 0, 0 } }];

        yield return [new[] { new[] { -1, 0 }, new[] { 0, -1 } }, new[] { new[] { 0, 0 }, new[] { 0, 0 } }];

        yield return [new[] { new[] { 100, -1 }, new[] { -1, 100 } }, new[] { new[] { 100, 100 }, new[] { 100, 100 } }];

        yield return [new[] { new[] { 1, -1, 3 }, new[] { -1, 5, -1 }, new[] { 7, -1, 9 } }, new[] { new[] { 1, 5, 3 }, new[] { 7, 5, 9 }, new[] { 7, 5, 9 } }];

        yield return [new[] { new[] { 2, 4, 6 }, new[] { 1, 3, 5 }, new[] { 0, 2, 4 } }, new[] { new[] { 2, 4, 6 }, new[] { 1, 3, 5 }, new[] { 0, 2, 4 } }];

        yield return [new[] { new[] { -1, 1, 2 }, new[] { 3, -1, 4 }, new[] { 5, 6, -1 } }, new[] { new[] { 5, 1, 2 }, new[] { 3, 6, 4 }, new[] { 5, 6, 4 } }];

        yield return [new[] { new[] { 10, 20 }, new[] { 30, -1 } }, new[] { new[] { 10, 20 }, new[] { 30, 20 } }];

        yield return [new[] { new[] { -1, -1, -1 }, new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, new[] { new[] { 4, 5, 6 }, new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }];

        yield return [new[] { new[] { 7, 8, 9 }, new[] { -1, -1, -1 }, new[] { 1, 2, 3 } }, new[] { new[] { 7, 8, 9 }, new[] { 7, 8, 9 }, new[] { 1, 2, 3 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { -1, -1 } }, new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 2, 2 } }];

        yield return [new[] { new[] { 0, -1 }, new[] { -1, 0 } }, new[] { new[] { 0, 0 }, new[] { 0, 0 } }];

        yield return [new[] { new[] { 50, -1, 50 }, new[] { -1, 50, -1 }, new[] { 50, -1, 50 } }, new[] { new[] { 50, 50, 50 }, new[] { 50, 50, 50 }, new[] { 50, 50, 50 } }];

        yield return [new[] { new[] { 3, 3 }, new[] { 3, -1 } }, new[] { new[] { 3, 3 }, new[] { 3, 3 } }];

        yield return [new[] { new[] { -1, 5 }, new[] { 10, -1 }, new[] { 5, 10 } }, new[] { new[] { 10, 5 }, new[] { 10, 10 }, new[] { 5, 10 } }];

        yield return [new[] { new[] { 1, -1, 1, -1 }, new[] { -1, 2, -1, 2 }, new[] { 3, -1, 3, -1 } }, new[] { new[] { 1, 2, 1, 2 }, new[] { 3, 2, 3, 2 }, new[] { 3, 2, 3, 2 } }];

        yield return [new[] { new[] { 9, -1 }, new[] { -1, 9 } }, new[] { new[] { 9, 9 }, new[] { 9, 9 } }];

        yield return [new[] { new[] { 4, 0, -1 }, new[] { -1, 7, 2 }, new[] { 8, -1, 6 } }, new[] { new[] { 4, 0, 6 }, new[] { 8, 7, 2 }, new[] { 8, 7, 6 } }];
    }
}