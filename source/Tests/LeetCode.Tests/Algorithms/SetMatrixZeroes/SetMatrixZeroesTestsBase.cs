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

using LeetCode.Algorithms.SetMatrixZeroes;

namespace LeetCode.Tests.Algorithms.SetMatrixZeroes;

public abstract class SetMatrixZeroesTestsBase<T> where T : ISetMatrixZeroes, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SetZeroes_WithMatrixContainingZeros_SetsEntireRowAndColumnToZero(int[][] matrix, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        solution.SetZeroes(matrix);

        // Assert
        Assert.AreEquivalent(expectedResult, matrix);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 1 } }, new[] { new[] { 1, 0, 1 }, new[] { 0, 0, 0 }, new[] { 1, 0, 1 } }
        ];

        yield return
        [
            new[] { new[] { 0, 1, 2, 0 }, new[] { 3, 4, 5, 2 }, new[] { 1, 3, 1, 5 } },
            new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 4, 5, 0 }, new[] { 0, 3, 1, 0 } }
        ];

        yield return [new[] { new[] { 0 } }, new[] { new[] { 0 } }];

        yield return [new[] { new[] { 1 } }, new[] { new[] { 1 } }];

        yield return [new[] { new[] { 1, 2, 3 } }, new[] { new[] { 1, 2, 3 } }];

        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }, new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, new[] { new[] { 0, 0 }, new[] { 0, 0 } }];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, new[] { new[] { 1, 1 }, new[] { 1, 1 } }];

        yield return [new[] { new[] { 1, 0 }, new[] { 1, 1 } }, new[] { new[] { 0, 0 }, new[] { 1, 0 } }];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 0 } }, new[] { new[] { 1, 0 }, new[] { 0, 0 } }];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 1 } }, new[] { new[] { 0, 0 }, new[] { 0, 1 } }];

        yield return [new[] { new[] { -1, 2147483647, 0 }, new[] { -2147483648, 5, 6 } }, new[] { new[] { 0, 0, 0 }, new[] { -2147483648, 5, 0 } }];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 0, 7, 8 }, new[] { 0, 10, 11, 12 }, new[] { 13, 14, 15, 0 } }, new[] { new[] { 0, 0, 3, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 } }];

        yield return [new[] { new[] { 0, 1, 1, 1, 1 } }, new[] { new[] { 0, 0, 0, 0, 0 } }];

        yield return [new[] { new[] { 1 }, new[] { 0 }, new[] { 1 }, new[] { 1 } }, new[] { new[] { 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 } }];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 0 } }, new[] { new[] { 1, 1, 0 }, new[] { 1, 1, 0 }, new[] { 0, 0, 0 } }];

        yield return [new[] { new[] { -4 }, new[] { 3 }, new[] { 1 }, new[] { 0 }, new[] { 9 } }, new[] { new[] { 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 } }];

        yield return [new[] { new[] { 9 }, new[] { 9 }, new[] { 0 }, new[] { 9 }, new[] { 1 } }, new[] { new[] { 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 }, new[] { 0 } }];

        yield return [new[] { new[] { 9, 9, 0, 1, 3 }, new[] { 9, -4, 1, 2, 9 } }, new[] { new[] { 0, 0, 0, 0, 0 }, new[] { 9, -4, 0, 2, 9 } }];

        yield return [new[] { new[] { 1, 9, 9 }, new[] { 9, 0, 9 }, new[] { -4, 0, 9 }, new[] { 0, 0, 1 }, new[] { 2, -4, 1 } }, new[] { new[] { 0, 0, 9 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } }];

        yield return [new[] { new[] { -4, 9, 0 }, new[] { 9, 2, 0 } }, new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }];

        yield return [new[] { new[] { 0, 0, 1 }, new[] { 9, 3, 3 }, new[] { 2, 3, 9 }, new[] { 9, 3, -4 }, new[] { -4, 9, 3 } }, new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 3 }, new[] { 0, 0, 9 }, new[] { 0, 0, -4 }, new[] { 0, 0, 3 } }];
    }
}