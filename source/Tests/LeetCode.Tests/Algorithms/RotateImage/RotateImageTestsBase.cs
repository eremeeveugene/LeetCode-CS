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

using LeetCode.Algorithms.RotateImage;

namespace LeetCode.Tests.Algorithms.RotateImage;

public abstract class RotateImageTestsBase<T> where T : IRotateImage, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Rotate_WithSquareMatrix_RotatesMatrixClockwiseInPlace(int[][] matrix, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        solution.Rotate(matrix);

        // Assert
        Assert.AreEquivalent(expectedResult, matrix);
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { new[] { 7, 4, 1 }, new[] { 8, 5, 2 }, new[] { 9, 6, 3 } }
        ];

        yield return
        [
            new[] { new[] { 5, 1, 9, 11 }, new[] { 2, 4, 8, 10 }, new[] { 13, 3, 6, 7 }, new[] { 15, 14, 12, 16 } },
            new[] { new[] { 15, 13, 2, 5 }, new[] { 14, 3, 4, 1 }, new[] { 12, 6, 8, 9 }, new[] { 16, 7, 10, 11 } }
        ];

        yield return [new[] { new[] { 5, 1 }, new[] { 2, 4 } }, new[] { new[] { 2, 5 }, new[] { 4, 1 } }];

        yield return [new[] { new[] { 1 } }, new[] { new[] { 1 } }];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, new[] { new[] { 1, 1 }, new[] { 1, 1 } }];

        yield return
        [
            new[] { new[] { 2, 2, 2 }, new[] { 3, 3, 3 }, new[] { 4, 4, 4 } }, new[] { new[] { 4, 3, 2 }, new[] { 4, 3, 2 }, new[] { 4, 3, 2 } }
        ];

        yield return [new[] { new[] { -1, -2 }, new[] { -3, -4 } }, new[] { new[] { -3, -1 }, new[] { -4, -2 } }];

        yield return [new[] { new[] { -1, 2 }, new[] { 3, -4 } }, new[] { new[] { 3, -1 }, new[] { -4, 2 } }];

        yield return
        [
            new[] { new[] { 1, 2, 1 }, new[] { 2, 3, 2 }, new[] { 1, 2, 1 } }, new[] { new[] { 1, 2, 1 }, new[] { 2, 3, 2 }, new[] { 1, 2, 1 } }
        ];

        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3 } }, new[] { new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 3, 3, 3 } }
        ];

        yield return
        [
            new[] { new[] { 3, 2, 1 }, new[] { 3, 2, 1 }, new[] { 3, 2, 1 } }, new[] { new[] { 3, 3, 3 }, new[] { 2, 2, 2 }, new[] { 1, 1, 1 } }
        ];

        yield return
        [
            new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 }, new[] { 13, 14, 15, 16 } },
            new[] { new[] { 13, 9, 5, 1 }, new[] { 14, 10, 6, 2 }, new[] { 15, 11, 7, 3 }, new[] { 16, 12, 8, 4 } }
        ];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, new[] { new[] { 0, 0 }, new[] { 0, 0 } }];

        yield return
        [
            new[] { new[] { 1, 0, 0 }, new[] { 0, 2, 0 }, new[] { 0, 0, 3 } }, new[] { new[] { 0, 0, 1 }, new[] { 0, 2, 0 }, new[] { 3, 0, 0 } }
        ];

        yield return
        [
            new[] { new[] { 0, 0, 1 }, new[] { 0, 2, 0 }, new[] { 3, 0, 0 } }, new[] { new[] { 3, 0, 0 }, new[] { 0, 2, 0 }, new[] { 0, 0, 1 } }
        ];

        yield return
        [
            new[] { new[] { 7, 7, 7 }, new[] { 7, 7, 7 }, new[] { 7, 7, 7 } }, new[] { new[] { 7, 7, 7 }, new[] { 7, 7, 7 }, new[] { 7, 7, 7 } }
        ];

        yield return [new[] { new[] { 1, 0 }, new[] { 0, 1 } }, new[] { new[] { 0, 1 }, new[] { 1, 0 } }];

        yield return
        [
            new[] { new[] { 1, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 1 } }, new[] { new[] { 0, 0, 1 }, new[] { 0, 1, 0 }, new[] { 1, 0, 0 } }
        ];

        yield return [new[] { new[] { int.MaxValue, 1 }, new[] { 2, int.MinValue } }, new[] { new[] { 2, int.MaxValue }, new[] { int.MinValue, 1 } }];

        yield return
        [
            new[] { new[] { 8, 3, 6 }, new[] { 1, 5, 7 }, new[] { 4, 9, 2 } }, new[] { new[] { 4, 1, 8 }, new[] { 9, 5, 3 }, new[] { 2, 7, 6 } }
        ];
    }
}