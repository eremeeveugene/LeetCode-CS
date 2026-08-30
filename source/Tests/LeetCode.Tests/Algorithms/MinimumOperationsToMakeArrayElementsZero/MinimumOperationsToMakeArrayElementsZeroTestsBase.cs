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

using LeetCode.Algorithms.MinimumOperationsToMakeArrayElementsZero;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeArrayElementsZero;

public abstract class MinimumOperationsToMakeArrayElementsZeroTestsBase<T> where T : IMinimumOperationsToMakeArrayElementsZero, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinOperations_WithGivenQueries_ReturnsSumOfMinimumOperationCounts(int[][] queries, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(queries);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 4 } }, 3L];
        yield return [new[] { new[] { 2, 6 } }, 4L];
        yield return [new[] { new[] { 1, 2 } }, 1L];
        yield return [new[] { new[] { 1, 3 } }, 2L];
        yield return [new[] { new[] { 1, 4 } }, 3L];
        yield return [new[] { new[] { 3, 4 } }, 2L];
        yield return [new[] { new[] { 4, 5 } }, 2L];
        yield return [new[] { new[] { 4, 15 } }, 12L];
        yield return [new[] { new[] { 15, 16 } }, 3L];
        yield return [new[] { new[] { 16, 17 } }, 3L];
        yield return [new[] { new[] { 1, 15 } }, 14L];
        yield return [new[] { new[] { 1, 16 } }, 15L];
        yield return [new[] { new[] { 5, 10 } }, 6L];
        yield return [new[] { new[] { 14, 18 } }, 7L];
        yield return [new[] { new[] { 63, 64 } }, 4L];
        yield return [new[] { new[] { 64, 65 } }, 4L];
        yield return [new[] { new[] { 1, 63 } }, 86L];
        yield return [new[] { new[] { 1, 64 } }, 88L];
        yield return [new[] { new[] { 100, 200 } }, 202L];
        yield return [new[] { new[] { 255, 256 } }, 5L];
        yield return [new[] { new[] { 256, 257 } }, 5L];
        yield return [new[] { new[] { 999_999_999, 1_000_000_000 } }, 15L];
        yield return [new[] { new[] { 1, 3 }, new[] { 4, 5 }, new[] { 15, 16 } }, 7L];
        yield return [new[] { new[] { 10, 20 }, new[] { 30, 40 }, new[] { 100, 101 } }, 35L];
        yield return [new[] { new[] { 2, 3 }, new[] { 4, 15 }, new[] { 16, 63 }, new[] { 64, 255 } }, 469L];
    }
}