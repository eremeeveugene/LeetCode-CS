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

using LeetCode.Algorithms.FindMissingAndRepeatedValues;

namespace LeetCode.Tests.Algorithms.FindMissingAndRepeatedValues;

public abstract class FindMissingAndRepeatedValuesTestsBase<T> where T : IFindMissingAndRepeatedValues, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindMissingAndRepeatedValues_GivenGrid_ReturnsMissingAndRepeatedNumbers(int[][] grid, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMissingAndRepeatedValues(grid);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 3 }, new[] { 2, 2 } }, new[] { 2, 4 }];

        yield return [new[] { new[] { 9, 1, 7 }, new[] { 8, 9, 2 }, new[] { 3, 4, 6 } }, new[] { 9, 5 }];

        yield return [new[] { new[] { 3, 1 }, new[] { 2, 3 } }, new[] { 3, 4 }];

        yield return [new[] { new[] { 2, 2 }, new[] { 4, 3 } }, new[] { 2, 1 }];

        yield return [new[] { new[] { 6, 7, 8 }, new[] { 1, 4, 9 }, new[] { 2, 3, 7 } }, new[] { 7, 5 }];

        yield return [new[] { new[] { 5, 2, 6 }, new[] { 8, 4, 9 }, new[] { 3, 8, 1 } }, new[] { 8, 7 }];

        yield return [new[] { new[] { 6, 9, 3 }, new[] { 5, 1, 3 }, new[] { 8, 7, 2 } }, new[] { 3, 4 }];

        yield return [new[] { new[] { 6, 12, 13, 9 }, new[] { 10, 4, 14, 16 }, new[] { 7, 6, 15, 8 }, new[] { 1, 11, 3, 2 } }, new[] { 6, 5 }];

        yield return [new[] { new[] { 5, 14, 7, 11 }, new[] { 10, 13, 2, 15 }, new[] { 4, 12, 1, 16 }, new[] { 14, 8, 3, 9 } }, new[] { 14, 6 }];

        yield return [new[] { new[] { 10, 7, 6, 1 }, new[] { 15, 3, 4, 8 }, new[] { 12, 14, 9, 13 }, new[] { 5, 8, 16, 11 } }, new[] { 8, 2 }];

        yield return [new[] { new[] { 3, 15, 8, 14, 11 }, new[] { 21, 6, 13, 24, 9 }, new[] { 20, 22, 7, 17, 5 }, new[] { 7, 12, 2, 19, 1 }, new[] { 4, 23, 18, 16, 25 } }, new[] { 7, 10 }];

        yield return [new[] { new[] { 19, 23, 1, 17, 22 }, new[] { 21, 9, 15, 10, 25 }, new[] { 16, 4, 5, 18, 14 }, new[] { 7, 6, 2, 12, 3 }, new[] { 24, 11, 7, 13, 8 } }, new[] { 7, 20 }];

        yield return [new[] { new[] { 9, 13, 31, 12, 34, 18 }, new[] { 24, 10, 15, 21, 29, 1 }, new[] { 33, 6, 36, 32, 3, 16 }, new[] { 4, 8, 2, 19, 21, 25 }, new[] { 23, 5, 26, 27, 17, 7 }, new[] { 22, 20, 28, 14, 30, 35 } }, new[] { 21, 11 }];

        yield return [new[] { new[] { 14, 36, 3, 10, 5, 2 }, new[] { 22, 24, 8, 19, 28, 16 }, new[] { 26, 9, 31, 27, 1, 6 }, new[] { 23, 32, 7, 17, 21, 11 }, new[] { 12, 34, 25, 30, 20, 33 }, new[] { 35, 13, 18, 15, 35, 29 } }, new[] { 35, 4 }];

        yield return [new[] { new[] { 15, 13, 44, 1, 41, 48, 26 }, new[] { 23, 28, 3, 11, 14, 36, 38 }, new[] { 2, 43, 19, 33, 18, 17, 8 }, new[] { 21, 40, 42, 27, 10, 31, 24 }, new[] { 30, 12, 16, 5, 47, 25, 41 }, new[] { 34, 22, 46, 37, 20, 49, 7 }, new[] { 29, 6, 35, 32, 39, 4, 9 } }, new[] { 41, 45 }];

        yield return [new[] { new[] { 23, 56, 48, 63, 27, 15, 45, 47 }, new[] { 58, 33, 19, 13, 2, 34, 5, 41 }, new[] { 21, 39, 42, 14, 26, 11, 53, 9 }, new[] { 44, 61, 32, 31, 1, 25, 24, 38 }, new[] { 54, 22, 43, 52, 64, 35, 30, 62 }, new[] { 12, 3, 35, 18, 57, 40, 28, 37 }, new[] { 46, 36, 20, 59, 50, 10, 8, 7 }, new[] { 17, 51, 16, 55, 29, 4, 49, 6 } }, new[] { 35, 60 }];

        yield return [new[] { new[] { 18, 2, 25, 13, 14 }, new[] { 24, 1, 3, 8, 17 }, new[] { 23, 24, 22, 6, 10 }, new[] { 7, 9, 20, 15, 11 }, new[] { 5, 21, 16, 4, 19 } }, new[] { 24, 12 }];

        yield return [new[] { new[] { 10, 1, 12, 6 }, new[] { 5, 9, 8, 7 }, new[] { 4, 7, 15, 13 }, new[] { 2, 3, 16, 14 } }, new[] { 7, 11 }];

        yield return [new[] { new[] { 3, 6, 7 }, new[] { 8, 4, 1 }, new[] { 7, 9, 2 } }, new[] { 7, 5 }];

        yield return [new[] { new[] { 2, 3 }, new[] { 4, 2 } }, new[] { 2, 1 }];
    }
}