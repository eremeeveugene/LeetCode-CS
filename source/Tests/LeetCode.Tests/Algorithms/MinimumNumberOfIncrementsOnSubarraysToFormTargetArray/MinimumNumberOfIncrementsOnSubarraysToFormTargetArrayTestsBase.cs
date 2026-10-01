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

using LeetCode.Algorithms.MinimumNumberOfIncrementsOnSubarraysToFormTargetArray;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfIncrementsOnSubarraysToFormTargetArray;

public abstract class MinimumNumberOfIncrementsOnSubarraysToFormTargetArrayTestsBase<T>
    where T : IMinimumNumberOfIncrementsOnSubarraysToFormTargetArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 2, 1 }, 3)]
    [DataRow(new[] { 3, 1, 1, 2 }, 4)]
    [DataRow(new[] { 3, 1, 5, 4, 2 }, 7)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 2 }, 2)]
    [DataRow(new[] { 100000 }, 100000)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 100000, 100000 }, 100000)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 2, 1 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 5)]
    [DataRow(new[] { 7, 7, 7, 7, 7 }, 7)]
    [DataRow(new[] { 1, 5, 1 }, 5)]
    [DataRow(new[] { 5, 1, 5 }, 9)]
    [DataRow(new[] { 5, 5, 1, 1, 5, 5 }, 9)]
    [DataRow(new[] { 1, 3, 2, 4, 3, 5 }, 7)]
    [DataRow(new[] { 5, 3, 4, 2, 3, 1 }, 7)]
    [DataRow(new[] { 2, 2, 3, 3, 2, 2 }, 3)]
    [DataRow(new[] { 2, 4, 4, 2, 5, 5 }, 7)]
    [DataRow(new[] { 5, 1, 2, 3, 4, 5 }, 9)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 4)]
    [DataRow(new[] { 10, 1, 10, 1, 10 }, 28)]
    [DataRow(new[] { 100000, 1, 100000 }, 199999)]
    [DataRow(new[] { 1, 100000, 1, 100000 }, 199999)]
    [DataRow(new[] { 99999, 100000, 99999, 100000 }, 100001)]
    [DataRow(new[] { 4, 1, 3, 1, 2 }, 7)]
    [DataRow(new[] { 1, 1, 1, 100000 }, 100000)]
    [DataRow(new[] { 100000, 1, 1, 1 }, 100000)]
    [DataRow(new[] { 8, 6, 6, 3, 3, 1 }, 8)]
    [DataRow(new[] { 2, 5, 3, 3, 6, 1, 4 }, 11)]
    [DataRow(new[] { 4, 2, 2, 5, 1, 1, 3, 3 }, 9)]
    [DynamicData(nameof(GetLargeTestData))]
    public void MinNumberOperations_WithGivenTarget_ReturnsMinimumSubarrayIncrementCount(int[] target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinNumberOperations(target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [Enumerable.Repeat(1, 100000).ToArray(), 1];
        yield return [Enumerable.Repeat(100000, 100000).ToArray(), 100000];
        yield return [Enumerable.Range(1, 100000).ToArray(), 100000];
        yield return [Enumerable.Range(1, 100000).Reverse().ToArray(), 100000];
        yield return [Enumerable.Range(0, 100000).Select(i => i % 2 == 0 ? 1 : 40000).ToArray(), 1999950001];
        yield return [Enumerable.Range(0, 42950).Select(i => i % 2 == 0 ? 1 : 100000).Concat([1, 5122]).ToArray(), int.MaxValue];
    }
}