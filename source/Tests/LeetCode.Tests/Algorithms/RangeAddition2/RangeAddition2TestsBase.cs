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

using LeetCode.Algorithms.RangeAddition2;

namespace LeetCode.Tests.Algorithms.RangeAddition2;

public abstract class RangeAddition2TestsBase<T> where T : IRangeAddition2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxCount_WithMatrixDimensionsAndOperations_ReturnsCountOfMaximumIntegers(int m, int n, int[][] ops, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxCount(m, n, ops);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [3, 3, new[] { new[] { 2, 2 }, new[] { 3, 3 } }, 4];

        yield return
        [
            3,
            3,
            new[]
            {
                new[] { 2, 2 },
                new[] { 3, 3 },
                new[] { 3, 3 },
                new[] { 3, 3 },
                new[] { 2, 2 },
                new[] { 3, 3 },
                new[] { 3, 3 },
                new[] { 3, 3 },
                new[] { 2, 2 },
                new[] { 3, 3 },
                new[] { 3, 3 },
                new[] { 3, 3 }
            },
            4
        ];

        yield return [3, 3, Array.Empty<int[]>(), 9];

        yield return [1, 1, Array.Empty<int[]>(), 1];

        yield return [1, 1, new[] { new[] { 1, 1 } }, 1];

        yield return [40000, 40000, Array.Empty<int[]>(), 1600000000];

        yield return [40000, 40000, new[] { new[] { 40000, 40000 } }, 1600000000];

        yield return [40000, 40000, new[] { new[] { 1, 1 } }, 1];

        yield return [5, 7, new[] { new[] { 3, 4 } }, 12];

        yield return [5, 7, new[] { new[] { 3, 4 }, new[] { 2, 6 } }, 8];

        yield return [5, 7, new[] { new[] { 5, 7 } }, 35];

        yield return [4, 4, new[] { new[] { 1, 4 }, new[] { 4, 1 } }, 1];

        yield return [10, 10, new[] { new[] { 9, 9 }, new[] { 8, 8 }, new[] { 7, 7 } }, 49];

        yield return [10, 3, new[] { new[] { 10, 1 } }, 10];

        yield return [3, 10, new[] { new[] { 1, 10 } }, 10];

        yield return [2, 2, new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 2, 2 } }, 1];

        yield return [100, 200, new[] { new[] { 50, 60 }, new[] { 70, 40 }, new[] { 100, 200 } }, 2000];

        yield return [6, 6, new[] { new[] { 3, 3 }, new[] { 3, 3 }, new[] { 3, 3 } }, 9];

        yield return [39999, 40000, new[] { new[] { 39999, 39999 } }, 1599920001];

        yield return [7, 5, new[] { new[] { 6, 2 }, new[] { 2, 5 } }, 4];

        yield return [9, 9, new[] { new[] { 9, 1 }, new[] { 1, 9 } }, 1];

        yield return [8, 8, new[] { new[] { 4, 5 }, new[] { 5, 4 } }, 16];
    }

    [TestMethod]
    public void MaxCount_WithMaxNumberOfOperations_ReturnsCountOfMaximumIntegers()
    {
        // Arrange
        var solution = new T();

        var ops = new int[10000][];

        for (var i = 0; i < ops.Length; i++)
        {
            ops[i] = [40000 - i, 40000 - i];
        }

        // Act
        var actualResult = solution.MaxCount(40000, 40000, ops);

        // Assert
        Assert.AreEqual(30001 * 30001, actualResult);
    }
}