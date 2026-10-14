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

using LeetCode.Algorithms.MinimumNumberOfRemovalsToMakeMountainArray;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfRemovalsToMakeMountainArray;

public abstract class MinimumNumberOfRemovalsToMakeMountainArrayTestsBase<T> where T : IMinimumNumberOfRemovalsToMakeMountainArray, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumMountainRemovals_WithGivenNumbers_ReturnsMinimumRemovalCount(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumMountainRemovals(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 3, 1 }, 0];
        yield return [new[] { 2, 1, 1, 5, 6, 2, 3, 1 }, 3];
        yield return [new[] { 1, 2, 1 }, 0];
        yield return [new[] { 1, 2, 3, 2, 1 }, 0];
        yield return [new[] { 1, 2, 3, 4, 3, 2, 1 }, 0];
        yield return [new[] { 1, 2, 2, 1 }, 1];
        yield return [new[] { 1, 1, 2, 1 }, 1];
        yield return [new[] { 1, 2, 1, 1 }, 1];
        yield return [new[] { 1, 1, 2, 2, 1, 1 }, 3];
        yield return [new[] { 5, 1, 2, 3, 2, 1, 6 }, 2];
        yield return [new[] { 9, 8, 1, 2, 3, 2, 1, 7, 8 }, 4];
        yield return [new[] { 1, 5, 2, 3, 4, 3, 2, 1 }, 1];
        yield return [new[] { 1, 2, 3, 7, 6, 8, 5, 4, 3, 2, 1 }, 1];
        yield return [new[] { 4, 3, 2, 1, 2, 3, 4, 3, 2, 1 }, 3];
        yield return [new[] { 1, 4, 3, 2 }, 0];
        yield return [new[] { 1, 2, 3, 4, 1 }, 0];
        yield return [new[] { 2, 3, 4, 5, 1 }, 0];
        yield return [new[] { 5, 4, 3, 2, 3, 1 }, 3];
        yield return [new[] { 1, 3, 2, 4, 3, 5, 4, 3, 2, 1 }, 2];
        yield return [new[] { 1, 2, 3, 3, 3, 2, 1 }, 2];
        yield return [new[] { 2, 2, 2, 3, 2, 2, 2 }, 4];
        yield return [new[] { 1, 1000000000, 1 }, 0];
        yield return [new[] { 1000000000, 1, 999999999, 2 }, 1];
        yield return [new[] { 1, 999999999, 1000000000, 999999999, 1 }, 0];
        yield return [new[] { 1, 2, 1, 2, 1 }, 2];
        yield return [new[] { 2, 1, 2, 1, 2 }, 2];
        yield return [new[] { 1, 2, 1, 2, 1, 2, 1 }, 4];
        yield return [new[] { 1, 4, 2, 3, 2, 1 }, 1];
        yield return [new[] { 1, 3, 5, 4, 2, 6, 1 }, 1];
        yield return [new[] { 3, 1, 4, 2, 5, 3, 6, 2 }, 3];
        yield return [new[] { 7, 7, 1, 4, 4, 3, 2, 2, 8 }, 5];
        yield return [new[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 }, 0];
        yield return [new[] { 8, 1, 2, 1 }, 1];
        yield return [new[] { 1, 2, 1, 8 }, 1];
        yield return [Concatenate(CreateRange(1, 501), CreateDescendingRange(500, 499)), 0];
        yield return [Concatenate(CreateRange(1, 500), CreateDescendingRange(500, 500)), 1];
        yield return [CreateAlternating(1000), 997];
        yield return [Concatenate(CreateFilled(1, 499), [1000000000], CreateFilled(1, 500)), 997];
        yield return [Concatenate(CreateRange(1, 999), [1]), 0];
        yield return [Concatenate([1], CreateDescendingRange(999, 999)), 0];
    }

    private static int[] CreateRange(int start, int count)
    {
        var result = new int[count];

        for (var i = 0; i < count; i++)
        {
            result[i] = start + i;
        }

        return result;
    }

    private static int[] CreateDescendingRange(int start, int count)
    {
        var result = new int[count];

        for (var i = 0; i < count; i++)
        {
            result[i] = start - i;
        }

        return result;
    }

    private static int[] CreateFilled(int value, int count)
    {
        var result = new int[count];

        for (var i = 0; i < count; i++)
        {
            result[i] = value;
        }

        return result;
    }

    private static int[] CreateAlternating(int count)
    {
        var result = new int[count];

        for (var i = 0; i < count; i++)
        {
            result[i] = i % 2 == 0 ? 1 : 2;
        }

        return result;
    }

    private static int[] Concatenate(params int[][] parts)
    {
        var totalLength = 0;

        for (var i = 0; i < parts.Length; i++)
        {
            var part = parts[i];

            totalLength += part.Length;
        }

        var result = new int[totalLength];
        var offset = 0;

        for (var i = 0; i < parts.Length; i++)
        {
            var part = parts[i];

            Array.Copy(part, 0, result, offset, part.Length);

            offset += part.Length;
        }

        return result;
    }
}