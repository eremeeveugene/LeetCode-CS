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

using LeetCode.Algorithms.FindTheMaximumSumOfNodeValues;

namespace LeetCode.Tests.Algorithms.FindTheMaximumSumOfNodeValues;

public abstract class FindTheMaximumSumOfNodeValuesTestsBase<T> where T : IFindTheMaximumSumOfNodeValues, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaximumValueSum_WithValuesEdgesAndXorKey_ReturnsHighestPossibleSumAfterOperations(
        int[] nums,
        int k,
        int[][] edges,
        long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumValueSum(nums, k, edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 2, 1 }, 3, new[] { new[] { 0, 1 }, new[] { 0, 2 } }, 6L];

        yield return [new[] { 2, 3 }, 7, new[] { new[] { 0, 1 } }, 9L];

        yield return [new[] { 7, 7, 7, 7, 7, 7 }, 3, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 0, 4 }, new[] { 0, 5 } }, 42L];

        yield return [new[] { 24, 78, 1, 97, 44 }, 6, new[] { new[] { 0, 2 }, new[] { 1, 2 }, new[] { 4, 2 }, new[] { 3, 4 } }, 260L];

        yield return [new[] { 10, 5 }, 1, new[] { new[] { 0, 1 } }, 15L];

        yield return [new[] { 12, 12 }, 5, new[] { new[] { 0, 1 } }, 24L];

        yield return [new[] { 8, 4, 11 }, 2, new[] { new[] { 0, 1 }, new[] { 0, 2 } }, 27L];

        yield return [new[] { 2, 6, 8 }, 7, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, 26L];

        yield return [new[] { 9, 2, 10, 4 }, 3, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 } }, 29L];

        yield return [new[] { 5, 3, 7, 3 }, 1, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 } }, 18L];

        yield return [new[] { 10, 8, 3, 3, 1 }, 6, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 1, 4 } }, 41L];

        yield return [new[] { 3, 5, 6, 4, 9 }, 2, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 1, 4 } }, 31L];

        yield return [new[] { 7, 5, 1, 6, 7, 3 }, 4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 3 }, new[] { 2, 4 }, new[] { 2, 5 } }, 37L];

        yield return [new[] { 10, 10, 1 }, 1, new[] { new[] { 0, 1 }, new[] { 0, 2 } }, 23L];

        yield return [new[] { 5, 6, 5, 8 }, 9, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 } }, 40L];

        yield return [new[] { 8, 12, 3, 1, 5 }, 3, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 0, 4 } }, 37L];

        yield return [new[] { 9, 7, 6, 7, 10, 1 }, 1, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 1, 4 }, new[] { 4, 5 } }, 42L];

        yield return [new[] { 4, 2 }, 3, new[] { new[] { 0, 1 } }, 8L];

        yield return [new[] { 8, 6, 9, 6 }, 5, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 3 } }, 37L];

        yield return [new[] { 10, 12, 6, 5, 1 }, 8, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 2, 4 } }, 50L];
    }
}