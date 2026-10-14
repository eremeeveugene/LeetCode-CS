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

using LeetCode.Algorithms.ConstructProductMatrix;

namespace LeetCode.Tests.Algorithms.ConstructProductMatrix;

public abstract class ConstructProductMatrixTestsBase<T> where T : IConstructProductMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ConstructProductMatrix_WithValidGrid_ReturnsProductOfAllOtherElementsModulo(int[][] grid, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ConstructProductMatrix(grid);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { new[] { 24, 12 }, new[] { 8, 6 } }];

        yield return [new[] { new[] { 12345 }, new[] { 2 }, new[] { 1 } }, new[] { new[] { 2 }, new[] { 0 }, new[] { 0 } }];

        yield return [new[] { new[] { 1, 1 } }, new[] { new[] { 1, 1 } }];

        yield return [new[] { new[] { 1 }, new[] { 1 } }, new[] { new[] { 1 }, new[] { 1 } }];

        yield return [new[] { new[] { 2, 3 } }, new[] { new[] { 3, 2 } }];

        yield return [new[] { new[] { 7, 8, 9 } }, new[] { new[] { 72, 63, 56 } }];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, new[] { new[] { 720, 360, 240 }, new[] { 180, 144, 120 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } }, new[] { new[] { 720, 360 }, new[] { 240, 180 }, new[] { 144, 120 } }];

        yield return [new[] { new[] { 10, 10 }, new[] { 10, 10 } }, new[] { new[] { 1000, 1000 }, new[] { 1000, 1000 } }];

        yield return [new[] { new[] { 100000, 2 } }, new[] { new[] { 2, 1240 } }];

        yield return [new[] { new[] { 3, 3, 3 }, new[] { 3, 3, 3 }, new[] { 3, 3, 3 } }, new[] { new[] { 6561, 6561, 6561 }, new[] { 6561, 6561, 6561 }, new[] { 6561, 6561, 6561 } }];

        yield return [new[] { new[] { 12345, 1 } }, new[] { new[] { 1, 0 } }];

        yield return [new[] { new[] { 4115, 3 } }, new[] { new[] { 3, 4115 } }];

        yield return [new[] { new[] { 2469, 5 } }, new[] { new[] { 5, 2469 } }];

        yield return [new[] { new[] { 99999, 99999 } }, new[] { new[] { 1239, 1239 } }];

        yield return [new[] { new[] { 9, 8 }, new[] { 7, 6 } }, new[] { new[] { 336, 378 }, new[] { 432, 504 } }];

        yield return [new[] { new[] { 1, 1, 1, 1 } }, new[] { new[] { 1, 1, 1, 1 } }];

        yield return [new[] { new[] { 6 }, new[] { 7 }, new[] { 8 }, new[] { 9 } }, new[] { new[] { 504 }, new[] { 432 }, new[] { 378 }, new[] { 336 } }];

        yield return [new[] { new[] { 123, 456 }, new[] { 789, 1011 } }, new[] { new[] { 8544, 8802 }, new[] { 4383, 8952 } }];

        yield return [new[] { new[] { 2, 2 }, new[] { 2, 2 } }, new[] { new[] { 8, 8 }, new[] { 8, 8 } }];
    }
}