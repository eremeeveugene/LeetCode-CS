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

using LeetCode.Algorithms.CyclicallyShiftRowsAndColumns;

namespace LeetCode.Tests.Algorithms.CyclicallyShiftRowsAndColumns;

public abstract class CyclicallyShiftRowsAndColumnsTestsBase<T> where T : ICyclicallyShiftRowsAndColumns, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CyclicShift_WithGivenGridAndShifts_ReturnsShiftedGrid(int n, int[][] grid, int[] rowShift, int[] colShift, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CyclicShift(n, grid, rowShift, colShift);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 1, 0 }, new[] { 0, 1 }, new[] { new[] { 2, 4 }, new[] { 3, 1 } }];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 1, 2, 0 },
            new[] { 2, 2, 1 },
            new[] { new[] { 7, 8, 5 }, new[] { 2, 3, 9 }, new[] { 6, 4, 1 } }
        ];

        yield return [1, new[] { new[] { 100 } }, new[] { 0 }, new[] { 0 }, new[] { new[] { 100 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { new[] { 1, 2 }, new[] { 3, 4 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 1, 0 }, new[] { 0, 0 }, new[] { new[] { 2, 1 }, new[] { 3, 4 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 0, 1 }, new[] { 0, 0 }, new[] { new[] { 1, 2 }, new[] { 4, 3 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 1, 1 }, new[] { 0, 0 }, new[] { new[] { 2, 1 }, new[] { 4, 3 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 0, 0 }, new[] { 1, 0 }, new[] { new[] { 3, 2 }, new[] { 1, 4 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 0, 0 }, new[] { 0, 1 }, new[] { new[] { 1, 4 }, new[] { 3, 2 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 0, 0 }, new[] { 1, 1 }, new[] { new[] { 3, 4 }, new[] { 1, 2 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { new[] { 4, 3 }, new[] { 2, 1 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { new[] { 3, 1 }, new[] { 2, 4 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { new[] { 4, 2 }, new[] { 1, 3 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 0, 1 }, new[] { 0, 1 }, new[] { new[] { 1, 3 }, new[] { 4, 2 } }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 0, 1 }, new[] { 1, 1 }, new[] { new[] { 4, 3 }, new[] { 1, 2 } }];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 0, 0, 0 },
            new[] { 0, 0, 0 },
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }
        ];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 1, 1, 1 },
            new[] { 0, 0, 0 },
            new[] { new[] { 2, 3, 1 }, new[] { 5, 6, 4 }, new[] { 8, 9, 7 } }
        ];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 2, 2, 2 },
            new[] { 0, 0, 0 },
            new[] { new[] { 3, 1, 2 }, new[] { 6, 4, 5 }, new[] { 9, 7, 8 } }
        ];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 0, 0, 0 },
            new[] { 1, 1, 1 },
            new[] { new[] { 4, 5, 6 }, new[] { 7, 8, 9 }, new[] { 1, 2, 3 } }
        ];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 0, 0, 0 },
            new[] { 2, 2, 2 },
            new[] { new[] { 7, 8, 9 }, new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }
        ];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 2, 2, 2 },
            new[] { 2, 2, 2 },
            new[] { new[] { 9, 7, 8 }, new[] { 3, 1, 2 }, new[] { 6, 4, 5 } }
        ];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 0, 1, 2 },
            new[] { 0, 1, 2 },
            new[] { new[] { 1, 6, 8 }, new[] { 5, 7, 3 }, new[] { 9, 2, 4 } }
        ];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 2, 0, 1 },
            new[] { 1, 0, 2 },
            new[] { new[] { 4, 1, 7 }, new[] { 8, 5, 2 }, new[] { 3, 9, 6 } }
        ];

        yield return
        [
            3,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { 0, 2, 0 },
            new[] { 2, 0, 1 },
            new[] { new[] { 7, 2, 5 }, new[] { 1, 4, 9 }, new[] { 6, 8, 3 } }
        ];

        yield return [2, new[] { new[] { 1, 100 }, new[] { 100, 1 } }, new[] { 1, 0 }, new[] { 1, 0 }, new[] { new[] { 100, 1 }, new[] { 100, 1 } }];

        yield return
        [
            3,
            new[] { new[] { 7, 7, 7 }, new[] { 7, 7, 7 }, new[] { 7, 7, 7 } },
            new[] { 1, 2, 0 },
            new[] { 2, 1, 0 },
            new[] { new[] { 7, 7, 7 }, new[] { 7, 7, 7 }, new[] { 7, 7, 7 } }
        ];

        yield return
        [
            4,
            new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 }, new[] { 13, 14, 15, 16 } },
            new[] { 0, 1, 2, 3 },
            new[] { 3, 2, 1, 0 },
            new[] { new[] { 16, 12, 8, 4 }, new[] { 1, 13, 9, 5 }, new[] { 6, 2, 14, 10 }, new[] { 11, 7, 3, 15 } }
        ];

        yield return
        [
            10,
            new[]
            {
                new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                new[] { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
                new[] { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
                new[] { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
                new[] { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
                new[] { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
                new[] { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
                new[] { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
                new[] { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
            },
            new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 },
            new[]
            {
                new[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 },
                new[] { 1, 91, 81, 71, 61, 51, 41, 31, 21, 11 },
                new[] { 12, 2, 92, 82, 72, 62, 52, 42, 32, 22 },
                new[] { 23, 13, 3, 93, 83, 73, 63, 53, 43, 33 },
                new[] { 34, 24, 14, 4, 94, 84, 74, 64, 54, 44 },
                new[] { 45, 35, 25, 15, 5, 95, 85, 75, 65, 55 },
                new[] { 56, 46, 36, 26, 16, 6, 96, 86, 76, 66 },
                new[] { 67, 57, 47, 37, 27, 17, 7, 97, 87, 77 },
                new[] { 78, 68, 58, 48, 38, 28, 18, 8, 98, 88 },
                new[] { 89, 79, 69, 59, 49, 39, 29, 19, 9, 99 }
            }
        ];
    }
}