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

using LeetCode.Algorithms.LargestLocalValuesInMatrix;

namespace LeetCode.Tests.Algorithms.LargestLocalValuesInMatrix;

public abstract class LargestLocalValuesInMatrixTestsBase<T> where T : ILargestLocalValuesInMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LargestLocal_WithGridInput_ReturnsMatrixOfMaxValuesFrom3x3Neighborhoods(int[][] grid, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestLocal(grid);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 9, 9, 8, 1 }, new[] { 5, 6, 2, 6 }, new[] { 8, 2, 6, 4 }, new[] { 6, 2, 2, 2 } },
            new[] { new[] { 9, 9 }, new[] { 8, 6 } }
        ];

        yield return
        [
            new[] { new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 2, 1, 1 }, new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1 } },
            new[] { new[] { 2, 2, 2 }, new[] { 2, 2, 2 }, new[] { 2, 2, 2 } }
        ];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, new[] { new[] { 1 } }];
        yield return [new[] { new[] { 5, 4, 3 }, new[] { 2, 9, 1 }, new[] { 7, 6, 8 } }, new[] { new[] { 9 } }];
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { new[] { 9 } }];
        yield return [new[] { new[] { 100, 100, 100 }, new[] { 100, 100, 100 }, new[] { 100, 100, 100 } }, new[] { new[] { 100 } }];

        yield return
        [
            new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 }, new[] { 13, 14, 15, 16 } },
            new[] { new[] { 11, 12 }, new[] { 15, 16 } }
        ];

        yield return
        [
            new[] { new[] { 16, 15, 14, 13 }, new[] { 12, 11, 10, 9 }, new[] { 8, 7, 6, 5 }, new[] { 4, 3, 2, 1 } },
            new[] { new[] { 16, 15 }, new[] { 12, 11 } }
        ];

        yield return
        [
            new[] { new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 100 }, new[] { 1, 1, 1, 1 } },
            new[] { new[] { 1, 100 }, new[] { 1, 100 } }
        ];

        yield return
        [
            new[] { new[] { 100, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 } },
            new[] { new[] { 100, 1 }, new[] { 1, 1 } }
        ];

        yield return
        [
            new[] { new[] { 1, 1, 1, 1, 1 }, new[] { 1, 9, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 7, 1 }, new[] { 1, 1, 1, 1, 1 } },
            new[] { new[] { 9, 9, 1 }, new[] { 9, 9, 7 }, new[] { 1, 7, 7 } }
        ];

        yield return
        [
            new[] { new[] { 73, 38, 3, 84 }, new[] { 55, 9, 75, 70 }, new[] { 40, 70, 11, 43 }, new[] { 11, 36, 95, 14 } },
            new[] { new[] { 75, 84 }, new[] { 95, 95 } }
        ];

        yield return
        [
            new[] { new[] { 11, 4, 82, 84, 19 }, new[] { 13, 96, 84, 55, 32 }, new[] { 92, 29, 63, 98, 67 }, new[] { 44, 98, 59, 51, 45 }, new[] { 44, 43, 87, 18, 64 } },
            new[] { new[] { 96, 98, 98 }, new[] { 98, 98, 98 }, new[] { 98, 98, 98 } }
        ];

        yield return
        [
            new[] { new[] { 69, 93, 10, 91, 80, 6 }, new[] { 53, 97, 86, 45, 1, 49 }, new[] { 12, 60, 70, 82, 4, 68 }, new[] { 47, 91, 2, 15, 54, 54 }, new[] { 19, 32, 95, 21, 82, 49 }, new[] { 88, 22, 42, 27, 50, 55 } },
            new[] { new[] { 97, 97, 91, 91 }, new[] { 97, 97, 86, 82 }, new[] { 95, 95, 95, 82 }, new[] { 95, 95, 95, 82 } }
        ];

        yield return
        [
            new[] { new[] { 36, 8, 61, 40, 94 }, new[] { 15, 39, 83, 20, 100 }, new[] { 23, 8, 97, 59, 3 }, new[] { 75, 62, 5, 41, 14 }, new[] { 26, 24, 46, 28, 76 } },
            new[] { new[] { 97, 97, 100 }, new[] { 97, 97, 100 }, new[] { 97, 97, 97 } }
        ];

        yield return
        [
            new[] { new[] { 77, 92, 61, 77 }, new[] { 66, 29, 57, 24 }, new[] { 36, 52, 23, 97 }, new[] { 40, 81, 71, 71 } },
            new[] { new[] { 92, 97 }, new[] { 81, 97 } }
        ];

        yield return
        [
            new[] { new[] { 34, 63, 52, 44, 85, 71 }, new[] { 99, 12, 62, 29, 52, 7 }, new[] { 28, 18, 50, 68, 67, 100 }, new[] { 36, 8, 85, 31, 2, 61 }, new[] { 48, 58, 32, 92, 54, 78 }, new[] { 21, 54, 21, 99, 42, 19 } },
            new[] { new[] { 99, 68, 85, 100 }, new[] { 99, 85, 85, 100 }, new[] { 85, 92, 92, 100 }, new[] { 85, 99, 99, 99 } }
        ];

        yield return
        [
            new[] { new[] { 67, 17, 82, 95, 80 }, new[] { 35, 67, 69, 7, 20 }, new[] { 74, 99, 23, 1, 27 }, new[] { 20, 17, 11, 46, 35 }, new[] { 79, 92, 68, 13, 62 } },
            new[] { new[] { 99, 99, 95 }, new[] { 99, 99, 69 }, new[] { 99, 99, 68 } }
        ];

        yield return
        [
            new[] { new[] { 11, 96, 76, 70, 65, 39 }, new[] { 3, 25, 54, 25, 88, 12 }, new[] { 57, 27, 5, 70, 53, 68 }, new[] { 64, 21, 40, 41, 40, 52 }, new[] { 10, 72, 40, 60, 86, 92 }, new[] { 9, 47, 10, 88, 18, 14 } },
            new[] { new[] { 96, 96, 88, 88 }, new[] { 64, 70, 88, 88 }, new[] { 72, 72, 86, 92 }, new[] { 72, 88, 88, 92 } }
        ];

        yield return
        [
            new[] { new[] { 87, 60, 96, 16, 84, 57 }, new[] { 2, 49, 92, 91, 61, 31 }, new[] { 38, 73, 15, 59, 99, 2 }, new[] { 93, 27, 79, 20, 38, 81 }, new[] { 49, 70, 96, 39, 44, 97 }, new[] { 51, 72, 86, 12, 33, 25 } },
            new[] { new[] { 96, 96, 99, 99 }, new[] { 93, 92, 99, 99 }, new[] { 96, 96, 99, 99 }, new[] { 96, 96, 96, 97 } }
        ];
    }
}