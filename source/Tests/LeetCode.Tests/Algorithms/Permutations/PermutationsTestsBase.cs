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

using LeetCode.Algorithms.Permutations;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.Permutations;

public abstract class PermutationsTestsBase<T> where T : IPermutations, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Permute_WithDifferentArraySizes_ReturnsAllPermutations(int[] nums, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Permute(nums);

        // Assert
        NestedCollectionAssert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 0 }, new[] { new[] { 0 } }];

        yield return [new[] { 0, 1 }, new[] { new[] { 0, 1 }, new[] { 1, 0 } }];

        yield return [new[] { 0, 1, 2 }, new[] { new[] { 1, 2, 0 }, new[] { 1, 0, 2 }, new[] { 2, 1, 0 }, new[] { 2, 0, 1 }, new[] { 0, 1, 2 }, new[] { 0, 2, 1 } }];
    }
}