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
    public void MaximumValueSum_WithValuesEdgesAndXorKey_ReturnsHighestPossibleSumAfterOperations(int[] nums,
        int k, int[][] edges, long expectedResult)
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

        yield return
        [
            new[] { 7, 7, 7, 7, 7, 7 }, 3,
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 0, 4 }, new[] { 0, 5 } }, 42L
        ];

        yield return
        [
            new[] { 24, 78, 1, 97, 44 }, 6,
            new[] { new[] { 0, 2 }, new[] { 1, 2 }, new[] { 4, 2 }, new[] { 3, 4 } }, 260L
        ];
    }
}