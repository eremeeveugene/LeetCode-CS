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

using LeetCode.Algorithms.FlipSquareSubmatrixVertically;

namespace LeetCode.Tests.Algorithms.FlipSquareSubmatrixVertically;

public abstract class FlipSquareSubmatrixVerticallyTestsBase<T> where T : IFlipSquareSubmatrixVertically, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ReverseSubmatrix_WithInputSubmatrix_ReversesSubmatrixRowsVerticallyAndReturnsUpdatedMatrix(
        int[][] grid,
        int x,
        int y,
        int k,
        int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseSubmatrix(grid, x, y, k);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 }, new[] { 13, 14, 15, 16 } },
            1,
            0,
            3,
            new[] { new[] { 1, 2, 3, 4 }, new[] { 13, 14, 15, 8 }, new[] { 9, 10, 11, 12 }, new[] { 5, 6, 7, 16 } }
        ];

        yield return [new[] { new[] { 3, 4, 2, 3 }, new[] { 2, 3, 4, 2 } }, 0, 2, 2, new[] { new[] { 3, 4, 4, 2 }, new[] { 2, 3, 2, 3 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 0, 0, 1, new[] { new[] { 1, 2 }, new[] { 3, 4 } }];

        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            0,
            0,
            3,
            new[] { new[] { 7, 8, 9 }, new[] { 4, 5, 6 }, new[] { 1, 2, 3 } }
        ];

        yield return
        [
            new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 } },
            0,
            1,
            2,
            new[] { new[] { 1, 6, 7, 4 }, new[] { 5, 2, 3, 8 }, new[] { 9, 10, 11, 12 } }
        ];

        yield return [new[] { new[] { 82 } }, 0, 0, 1, new[] { new[] { 82 } }];

        yield return [new[] { new[] { 5, 64, 43, 27, 17 } }, 0, 2, 1, new[] { new[] { 5, 64, 43, 27, 17 } }];

        yield return [new[] { new[] { 94 }, new[] { 73 }, new[] { 17 }, new[] { 81 }, new[] { 53 } }, 2, 0, 1, new[] { new[] { 94 }, new[] { 73 }, new[] { 17 }, new[] { 81 }, new[] { 53 } }];

        yield return [new[] { new[] { 14, 22 }, new[] { 56, 48 } }, 0, 0, 2, new[] { new[] { 56, 48 }, new[] { 14, 22 } }];

        yield return [new[] { new[] { 20, 8, 54 }, new[] { 38, 19, 59 }, new[] { 80, 22, 67 } }, 1, 1, 2, new[] { new[] { 20, 8, 54 }, new[] { 38, 22, 67 }, new[] { 80, 19, 59 } }];

        yield return [new[] { new[] { 59, 63, 89 }, new[] { 94, 41, 62 }, new[] { 36, 38, 61 } }, 0, 1, 2, new[] { new[] { 59, 41, 62 }, new[] { 94, 63, 89 }, new[] { 36, 38, 61 } }];

        yield return [new[] { new[] { 52, 19, 15 }, new[] { 49, 69, 23 }, new[] { 81, 64, 44 } }, 1, 0, 2, new[] { new[] { 52, 19, 15 }, new[] { 81, 64, 23 }, new[] { 49, 69, 44 } }];

        yield return [new[] { new[] { 24, 12, 63, 35 }, new[] { 66, 71, 65, 47 }, new[] { 9, 100, 46, 89 }, new[] { 76, 85, 5, 98 } }, 0, 0, 4, new[] { new[] { 76, 85, 5, 98 }, new[] { 9, 100, 46, 89 }, new[] { 66, 71, 65, 47 }, new[] { 24, 12, 63, 35 } }];

        yield return [new[] { new[] { 40, 47, 72, 91 }, new[] { 86, 36, 63, 34 }, new[] { 99, 89, 92, 38 }, new[] { 44, 84, 23, 75 } }, 2, 2, 2, new[] { new[] { 40, 47, 72, 91 }, new[] { 86, 36, 63, 34 }, new[] { 99, 89, 23, 75 }, new[] { 44, 84, 92, 38 } }];

        yield return [new[] { new[] { 2, 61, 71, 100, 33 }, new[] { 42, 86, 36, 60, 37 }, new[] { 65, 83, 87, 46, 45 }, new[] { 36, 83, 45, 95, 53 } }, 0, 1, 4, new[] { new[] { 2, 83, 45, 95, 53 }, new[] { 42, 83, 87, 46, 45 }, new[] { 65, 86, 36, 60, 37 }, new[] { 36, 61, 71, 100, 33 } }];

        yield return [new[] { new[] { 45, 23, 89, 58 }, new[] { 47, 43, 67, 19 }, new[] { 68, 22, 26, 47 }, new[] { 62, 37, 89, 11 }, new[] { 93, 86, 94, 54 } }, 1, 0, 4, new[] { new[] { 45, 23, 89, 58 }, new[] { 93, 86, 94, 54 }, new[] { 62, 37, 89, 11 }, new[] { 68, 22, 26, 47 }, new[] { 47, 43, 67, 19 } }];

        yield return [new[] { new[] { 22, 79, 100, 75, 67 }, new[] { 86, 54, 39, 80, 71 }, new[] { 100, 82, 35, 93, 4 }, new[] { 26, 21, 76, 57, 80 }, new[] { 84, 24, 29, 98, 88 } }, 0, 0, 3, new[] { new[] { 100, 82, 35, 75, 67 }, new[] { 86, 54, 39, 80, 71 }, new[] { 22, 79, 100, 93, 4 }, new[] { 26, 21, 76, 57, 80 }, new[] { 84, 24, 29, 98, 88 } }];

        yield return [new[] { new[] { 24, 81, 92, 6, 61 }, new[] { 29, 22, 7, 18, 15 }, new[] { 41, 24, 62, 25, 71 }, new[] { 5, 54, 60, 45, 49 }, new[] { 85, 79, 10, 76, 27 } }, 2, 2, 3, new[] { new[] { 24, 81, 92, 6, 61 }, new[] { 29, 22, 7, 18, 15 }, new[] { 41, 24, 10, 76, 27 }, new[] { 5, 54, 60, 45, 49 }, new[] { 85, 79, 62, 25, 71 } }];

        yield return [new[] { new[] { 31, 92, 48, 1, 45, 52 }, new[] { 36, 53, 15, 89, 71, 48 }, new[] { 5, 71, 79, 39, 13, 38 }, new[] { 70, 66, 44, 75, 38, 46 }, new[] { 17, 54, 53, 73, 83, 69 }, new[] { 48, 60, 19, 21, 77, 49 } }, 1, 1, 5, new[] { new[] { 31, 92, 48, 1, 45, 52 }, new[] { 36, 60, 19, 21, 77, 49 }, new[] { 5, 54, 53, 73, 83, 69 }, new[] { 70, 66, 44, 75, 38, 46 }, new[] { 17, 71, 79, 39, 13, 38 }, new[] { 48, 53, 15, 89, 71, 48 } }];

        yield return [new[] { new[] { 73, 62, 26 }, new[] { 18, 78, 12 }, new[] { 45, 85, 1 }, new[] { 49, 14, 42 }, new[] { 73, 79, 70 }, new[] { 19, 42, 81 }, new[] { 73, 49, 55 } }, 4, 0, 3, new[] { new[] { 73, 62, 26 }, new[] { 18, 78, 12 }, new[] { 45, 85, 1 }, new[] { 49, 14, 42 }, new[] { 73, 49, 55 }, new[] { 19, 42, 81 }, new[] { 73, 79, 70 } }];
    }
}