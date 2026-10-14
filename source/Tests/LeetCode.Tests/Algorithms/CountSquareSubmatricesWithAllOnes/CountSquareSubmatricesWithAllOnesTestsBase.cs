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

using LeetCode.Algorithms.CountSquareSubmatricesWithAllOnes;

namespace LeetCode.Tests.Algorithms.CountSquareSubmatricesWithAllOnes;

public abstract class CountSquareSubmatricesWithAllOnesTestsBase<T> where T : ICountSquareSubmatricesWithAllOnes, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountSquares_WithMatrixContainingOnesAndZeros_ReturnsTotalSquareSubmatricesWithAllOnes(int[][] matrix, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSquares(matrix);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 0, 1, 1, 1 } }, 15];

        yield return [new[] { new[] { 1, 0, 1 }, new[] { 1, 1, 0 }, new[] { 1, 1, 0 } }, 7];

        yield return [new[] { new[] { 1 } }, 1];

        yield return [new[] { new[] { 0 } }, 0];

        yield return [new[] { new[] { 1, 1 } }, 2];

        yield return [new[] { new[] { 1 }, new[] { 1 } }, 2];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 5];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 0 } }, 3];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 0];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 14];

        yield return [new[] { new[] { 1, 0, 1 }, new[] { 0, 1, 0 }, new[] { 1, 0, 1 } }, 5];

        yield return [new[] { new[] { 1, 1, 1, 1 } }, 4];

        yield return [new[] { new[] { 1, 1, 0 }, new[] { 1, 1, 1 }, new[] { 0, 1, 1 } }, 9];

        yield return [new[] { new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 } }, 30];

        yield return [new[] { new[] { 0, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 0, 1, 1, 1 } }, 15];

        yield return [new[] { new[] { 1, 1, 1, 1, 0 }, new[] { 1, 0, 0, 1, 0 }, new[] { 1, 0, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1 } }, 27];

        yield return [new[] { new[] { 1, 1, 1, 1, 1, 1 }, new[] { 0, 1, 1, 1, 1, 1 }, new[] { 1, 1, 0, 1, 0, 1 }, new[] { 1, 1, 1, 0, 0, 1 } }, 24];

        yield return [new[] { new[] { 1, 0, 0 }, new[] { 0, 1, 1 }, new[] { 1, 1, 1 }, new[] { 0, 1, 1 }, new[] { 1, 1, 0 }, new[] { 1, 0, 1 } }, 14];

        yield return [new[] { new[] { 0, 1, 1, 1, 0, 1, 1 }, new[] { 0, 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 0, 1, 1, 0, 1 }, new[] { 1, 1, 1, 1, 1, 0, 1 }, new[] { 1, 1, 1, 1, 1, 0, 1 } }, 38];

        yield return [new[] { new[] { 1, 0, 1, 0, 1 }, new[] { 0, 1, 1, 1, 1 } }, 7];
    }
}