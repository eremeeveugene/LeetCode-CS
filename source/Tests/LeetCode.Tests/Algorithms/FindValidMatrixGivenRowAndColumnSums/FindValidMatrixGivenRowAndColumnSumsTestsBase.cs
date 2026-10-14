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

using LeetCode.Algorithms.FindValidMatrixGivenRowAndColumnSums;

namespace LeetCode.Tests.Algorithms.FindValidMatrixGivenRowAndColumnSums;

public abstract class FindValidMatrixGivenRowAndColumnSumsTestsBase<T> where T : IFindValidMatrixGivenRowAndColumnSums, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RestoreMatrix_WithGivenRowAndColumnSums_ReturnsRestoredMatrix(int[] rowSum, int[] colSum, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RestoreMatrix(rowSum, colSum);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 3, 8 }, new[] { 4, 7 }, new[] { new[] { 3, 0 }, new[] { 1, 7 } }];

        yield return [new[] { 5, 7, 10 }, new[] { 8, 6, 8 }, new[] { new[] { 5, 0, 0 }, new[] { 3, 4, 0 }, new[] { 0, 2, 8 } }];

        yield return [new[] { 0 }, new[] { 0 }, new[] { new[] { 0 } }];

        yield return [new[] { 7 }, new[] { 7 }, new[] { new[] { 7 } }];

        yield return [new[] { 5 }, new[] { 2, 3 }, new[] { new[] { 2, 3 } }];

        yield return [new[] { 2, 3 }, new[] { 5 }, new[] { new[] { 2 }, new[] { 3 } }];

        yield return [new[] { 1, 1 }, new[] { 1, 1 }, new[] { new[] { 1, 0 }, new[] { 0, 1 } }];

        yield return [new[] { 0, 4 }, new[] { 4, 0 }, new[] { new[] { 0, 0 }, new[] { 4, 0 } }];

        yield return [new[] { 4, 0 }, new[] { 0, 4 }, new[] { new[] { 0, 4 }, new[] { 0, 0 } }];

        yield return [new[] { 3, 3, 3 }, new[] { 9 }, new[] { new[] { 3 }, new[] { 3 }, new[] { 3 } }];

        yield return [new[] { 9 }, new[] { 3, 3, 3 }, new[] { new[] { 3, 3, 3 } }];

        yield return [new[] { 1, 2, 3, 4 }, new[] { 10 }, new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 } }];

        yield return [new[] { 10 }, new[] { 1, 2, 3, 4 }, new[] { new[] { 1, 2, 3, 4 } }];

        yield return [new[] { 2, 5, 3 }, new[] { 4, 4, 2 }, new[] { new[] { 2, 0, 0 }, new[] { 2, 3, 0 }, new[] { 0, 1, 2 } }];

        yield return [new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }];

        yield return [new[] { 100000000 }, new[] { 100000000 }, new[] { new[] { 100000000 } }];

        yield return [new[] { 100000000, 100000000 }, new[] { 100000000, 100000000 }, new[] { new[] { 100000000, 0 }, new[] { 0, 100000000 } }];

        yield return [new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, new[] { new[] { 1, 0, 0 }, new[] { 2, 0, 0 }, new[] { 0, 2, 1 } }];

        yield return [new[] { 6, 0, 6 }, new[] { 3, 3, 6 }, new[] { new[] { 3, 3, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 6 } }];

        yield return [new[] { 8, 4 }, new[] { 2, 2, 8 }, new[] { new[] { 2, 2, 4 }, new[] { 0, 0, 4 } }];
    }
}