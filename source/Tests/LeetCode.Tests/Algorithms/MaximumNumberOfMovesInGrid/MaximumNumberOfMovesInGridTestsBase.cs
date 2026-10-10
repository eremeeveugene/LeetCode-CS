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

using LeetCode.Algorithms.MaximumNumberOfMovesInGrid;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfMovesInGrid;

public abstract class MaximumNumberOfMovesInGridTestsBase<T> where T : IMaximumNumberOfMovesInGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxMoves_WithGridInput_ReturnsMaximumMoves(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxMoves(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 2, 4, 3, 5 }, new[] { 5, 4, 9, 3 }, new[] { 3, 4, 2, 11 }, new[] { 10, 9, 13, 15 } }, 3];

        yield return [new[] { new[] { 3, 2, 4 }, new[] { 2, 1, 9 }, new[] { 1, 1, 7 } }, 0];

        yield return [new[] { new[] { 3, 1 }, new[] { 1, 4 } }, 1];

        yield return [new[] { new[] { 6, 3, 10, 7, 4 }, new[] { 3, 7, 10, 8, 7 } }, 2];

        yield return [new[] { new[] { 7, 2 }, new[] { 10, 2 }, new[] { 5, 2 }, new[] { 1, 2 }, new[] { 2, 9 } }, 1];

        yield return [new[] { new[] { 9, 6, 3 }, new[] { 9, 8, 3 }, new[] { 2, 4, 1 } }, 1];

        yield return [new[] { new[] { 5, 11, 13, 19, 4, 10 }, new[] { 12, 11, 12, 1, 16, 7 }, new[] { 2, 20, 2, 19, 6, 6 }, new[] { 11, 14, 15, 4, 3, 7 } }, 3];

        yield return [new[] { new[] { 20, 8, 16, 16 }, new[] { 5, 13, 4, 4 }, new[] { 19, 15, 5, 15 }, new[] { 17, 3, 16, 19 }, new[] { 13, 12, 15, 8 }, new[] { 2, 7, 2, 15 } }, 3];

        yield return [new[] { new[] { 15, 14, 28, 93, 1 }, new[] { 91, 77, 79, 3, 84 }, new[] { 47, 56, 68, 12, 96 }, new[] { 97, 77, 65, 91, 73 }, new[] { 26, 65, 30, 42, 68 } }, 4];

        yield return [new[] { new[] { 25, 48, 34, 42, 13, 1, 19, 40 }, new[] { 19, 6, 48, 21, 26, 15, 41, 19 }, new[] { 6, 36, 27, 48, 24, 48, 21, 34 }, new[] { 20, 41, 23, 19, 42, 7, 13, 32 }, new[] { 24, 25, 38, 20, 14, 19, 26, 40 }, new[] { 25, 44, 34, 45, 47, 23, 44, 39 }, new[] { 38, 24, 44, 28, 13, 32, 34, 33 }, new[] { 6, 18, 11, 5, 32, 47, 18, 27 } }, 4];

        yield return [new[] { new[] { 817956, 122728, 654893, 869620, 865036, 287251, 305814, 287413, 843291, 865412 }, new[] { 528731, 281654, 290801, 931553, 662882, 431807, 256417, 378914, 257719, 260064 }, new[] { 828546, 529233, 783692, 480180, 262039, 245609, 852779, 850323, 625580, 550761 }, new[] { 870030, 204875, 385814, 520774, 818693, 110885, 831980, 117049, 406786, 88316 }, new[] { 686494, 179001, 818142, 594275, 448345, 965163, 47331, 824443, 954324, 143451 }, new[] { 23163, 639932, 200534, 718316, 277489, 91274, 100072, 485167, 482069, 910911 }, new[] { 701724, 949411, 295946, 970263, 593615, 97201, 132477, 636577, 374941, 907030 }, new[] { 684415, 69179, 335460, 829014, 40592, 876195, 964473, 88033, 900799, 143977 }, new[] { 685394, 843690, 384041, 868688, 78618, 854385, 241941, 759919, 38862, 628871 }, new[] { 828658, 334805, 233130, 311003, 780198, 374857, 342666, 69321, 545317, 943844 } }, 5];

        yield return [new[] { new[] { 4, 30, 24, 20, 12, 14, 6, 6, 9, 29, 13, 5 }, new[] { 14, 24, 26, 3, 4, 18, 8, 3, 10, 30, 6, 11 }, new[] { 24, 7, 4, 2, 2, 18, 26, 24, 6, 27, 6, 18 }, new[] { 21, 11, 10, 29, 8, 24, 17, 16, 4, 19, 23, 30 }, new[] { 3, 5, 30, 24, 5, 8, 11, 7, 14, 6, 6, 5 }, new[] { 25, 15, 2, 23, 29, 15, 19, 22, 20, 10, 14, 27 }, new[] { 30, 14, 19, 22, 29, 24, 30, 12, 23, 19, 23, 16 } }, 4];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 0];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 1 } }, 1];

        yield return [new[] { new[] { 1000000, 1000000 }, new[] { 1000000, 1000000 } }, 0];

        yield return [new[] { new[] { 1, 2, 3, 4, 5 }, new[] { 2, 3, 4, 5, 6 } }, 4];

        yield return [new[] { new[] { 5, 4, 3, 2, 1 }, new[] { 6, 5, 4, 3, 2 } }, 0];

        yield return [CreateColumnIncreasingGrid(1000, 1000), 999];

        yield return [CreateColumnIncreasingGrid(2, 1000), 999];

        yield return [new[] { new[] { 1, 3, 5 }, new[] { 2, 4, 6 }, new[] { 9, 1, 7 } }, 2];

        yield return [new[] { new[] { 7, 1, 8, 2 }, new[] { 3, 9, 4, 10 } }, 1];
    }

    private static int[][] CreateColumnIncreasingGrid(int rows, int columns)
    {
        var grid = new int[rows][];

        for (var i = 0; i < rows; i++)
        {
            grid[i] = new int[columns];

            for (var j = 0; j < columns; j++)
            {
                grid[i][j] = (j * rows) + i + 1;
            }
        }

        return grid;
    }
}