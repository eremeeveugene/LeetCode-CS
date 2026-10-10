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

using LeetCode.Algorithms.MaximumMatrixSum;

namespace LeetCode.Tests.Algorithms.MaximumMatrixSum;

public abstract class MaximumMatrixSumTestsBase<T> where T : IMaximumMatrixSum, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxMatrixSum_WithMatrix_ReturnsMaximumSumAfterFlips(int[][] matrix, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxMatrixSum(matrix);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, -1 }, new[] { -1, 1 } }, 4L];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { -1, -2, -3 }, new[] { 1, 2, 3 } }, 16L];

        yield return [new[] { new[] { -2, -4 }, new[] { -1, 3 } }, 8L];

        yield return [new[] { new[] { 96559, 96475 }, new[] { 86808, -21245 } }, 258597L];

        yield return [new[] { new[] { 6, -9, 8 }, new[] { 6, 1, 4 }, new[] { -9, 0, -1 } }, 44L];

        yield return [new[] { new[] { 8969, 38867, -34486 }, new[] { 22886, 60582, -57104 }, new[] { 85783, -94565, -27454 } }, 430696L];

        yield return [new[] { new[] { -3, -1, -3 }, new[] { -2, -1, -3 }, new[] { -1, -3, -3 } }, 18L];

        yield return [new[] { new[] { 8, 1, 2 }, new[] { 3, 6, 8 }, new[] { 7, 6, 4 } }, 45L];

        yield return [new[] { new[] { 0, 5, -2, 19 }, new[] { -4, -1, 3, 6 }, new[] { 16, 14, 1, -8 }, new[] { 20, 13, 12, 14 } }, 138L];

        yield return [new[] { new[] { 21992, 48521, 99017, 97692 }, new[] { -16163, -24195, 23346, -94870 }, new[] { 9571, -99850, 48318, -30640 }, new[] { 50188, 77519, -27770, 4007 } }, 773659L];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 0L];

        yield return [new[] { new[] { 0, -1 }, new[] { -1, 0 } }, 2L];

        yield return [new[] { new[] { -1, -1 }, new[] { -1, 1 } }, 2L];

        yield return [new[] { new[] { -5, 3 }, new[] { 2, 4 } }, 10L];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, -4 } }, 8L];

        yield return [new[] { new[] { -100000, -100000, -100000 }, new[] { -100000, -100000, -100000 }, new[] { -100000, -100000, -100000 } }, 700000L];

        yield return [new[] { new[] { 100000, 100000 }, new[] { 100000, 100000 } }, 400000L];

        yield return [new[] { new[] { 0, -1, -1 }, new[] { 1, -1, -1 }, new[] { -1, 1, -1 } }, 8L];

        yield return [new[] { new[] { 1, -2, 0, 1 }, new[] { 1, -1, 2, -2 }, new[] { -2, -1, 0, 1 }, new[] { 1, 0, -1, -2 } }, 18L];

        yield return [new[] { new[] { 2, 7, 7, 7 }, new[] { 0, 0, 0, 6 }, new[] { 0, 5, 6, 0 }, new[] { 0, 0, 5, 7 } }, 52L];
    }
}