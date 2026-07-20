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

using LeetCode.Algorithms.Shift2DGrid;

namespace LeetCode.Tests.Algorithms.Shift2DGrid;

public abstract class Shift2DGridTestsBase<T> where T : IShift2DGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ShiftGrid_WithGridAndNumberOfShifts_ReturnsShiftedGrid(int[][] grid, int k, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ShiftGrid(grid, k);

        // Assert
        Assert.AreEquivalent<IEnumerable<IEnumerable<int>>>(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            1,
            new[] { new[] { 9, 1, 2 }, new[] { 3, 4, 5 }, new[] { 6, 7, 8 } }
        ];

        yield return
        [
            new[] { new[] { 3, 8, 1, 9 }, new[] { 19, 7, 2, 5 }, new[] { 4, 6, 11, 10 }, new[] { 12, 0, 21, 13 } },
            4,
            new[] { new[] { 12, 0, 21, 13 }, new[] { 3, 8, 1, 9 }, new[] { 19, 7, 2, 5 }, new[] { 4, 6, 11, 10 } }
        ];

        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            9,
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }
        ];

        yield return [new[] { new[] { 1 } }, 0, new[] { new[] { 1 } }];

        yield return [new[] { new[] { 1 } }, 5, new[] { new[] { 1 } }];

        yield return [new[] { new[] { 1, 2 } }, 1, new[] { new[] { 2, 1 } }];

        yield return [new[] { new[] { 1, 2 } }, 2, new[] { new[] { 1, 2 } }];

        yield return [new[] { new[] { 1, 2 } }, 3, new[] { new[] { 2, 1 } }];

        yield return [new[] { new[] { 1 }, new[] { 2 } }, 1, new[] { new[] { 2 }, new[] { 1 } }];

        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }, 2, new[] { new[] { 2 }, new[] { 3 }, new[] { 1 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 1, new[] { new[] { 4, 1 }, new[] { 2, 3 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 2, new[] { new[] { 3, 4 }, new[] { 1, 2 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 3, new[] { new[] { 2, 3 }, new[] { 4, 1 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 4, new[] { new[] { 1, 2 }, new[] { 3, 4 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 5, new[] { new[] { 4, 1 }, new[] { 2, 3 } }];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, 2, new[] { new[] { 5, 6, 1 }, new[] { 2, 3, 4 } }];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, 7, new[] { new[] { 6, 1, 2 }, new[] { 3, 4, 5 } }];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 5, new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }];

        yield return [new[] { new[] { 5, 10, 15, 20 } }, 2, new[] { new[] { 15, 20, 5, 10 } }];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 } }, 3, new[] { new[] { 6, 7, 8, 1 }, new[] { 2, 3, 4, 5 } }];

        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            100,
            new[] { new[] { 9, 1, 2 }, new[] { 3, 4, 5 }, new[] { 6, 7, 8 } }
        ];

        yield return [new[] { new[] { 7 } }, 100, new[] { new[] { 7 } }];

        yield return
        [
            new[] { new[] { 10, 20 }, new[] { 30, 40 }, new[] { 50, 60 } }, 4, new[] { new[] { 30, 40 }, new[] { 50, 60 }, new[] { 10, 20 } }
        ];

        yield return [new[] { new[] { 2, 4, 6, 8, 10 } }, 6, new[] { new[] { 10, 2, 4, 6, 8 } }];

        yield return
        [
            new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 }, new[] { 5 } },
            3,
            new[] { new[] { 3 }, new[] { 4 }, new[] { 5 }, new[] { 1 }, new[] { 2 } }
        ];

        yield return [new[] { new[] { 9, 8 }, new[] { 7, 6 } }, 0, new[] { new[] { 9, 8 }, new[] { 7, 6 } }];
    }
}