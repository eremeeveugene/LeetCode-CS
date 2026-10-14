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

using LeetCode.Algorithms.MaximumFrequencyOfAnElementAfterPerformingOperations2;

namespace LeetCode.Tests.Algorithms.MaximumFrequencyOfAnElementAfterPerformingOperations2;

public abstract class MaximumFrequencyOfAnElementAfterPerformingOperations2TestsBase<T>
    where T : IMaximumFrequencyOfAnElementAfterPerformingOperations2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 5 }, 1, 2, 2)]
    [DataRow(new[] { 5, 11, 20, 20 }, 5, 1, 2)]
    [DataRow(new[] { 1 }, 0, 0, 1)]
    [DataRow(new[] { 1 }, 0, 1, 1)]
    [DataRow(new[] { 100000 }, 100000, 1, 1)]
    [DataRow(new[] { 7, 7, 7, 7 }, 0, 0, 4)]
    [DataRow(new[] { 7, 7, 7, 7 }, 100000, 4, 4)]
    [DataRow(new[] { 1, 3 }, 1, 2, 2)]
    [DataRow(new[] { 1, 3 }, 1, 1, 1)]
    [DataRow(new[] { 1, 4 }, 1, 2, 1)]
    [DataRow(new[] { 1, 3 }, 2, 1, 2)]
    [DataRow(new[] { 1, 2, 3 }, 1, 1, 2)]
    [DataRow(new[] { 1, 2, 3 }, 1, 2, 3)]
    [DataRow(new[] { 1, 2, 3 }, 1, 0, 1)]
    [DataRow(new[] { 1, 1, 3, 3 }, 1, 4, 4)]
    [DataRow(new[] { 1, 1, 3, 3 }, 1, 2, 2)]
    [DataRow(new[] { 1, 1, 3, 3 }, 2, 1, 3)]
    [DataRow(new[] { 2, 2, 2, 4, 4 }, 2, 1, 4)]
    [DataRow(new[] { 2, 2, 2, 4, 4 }, 0, 5, 3)]
    [DataRow(new[] { 10, 2, 6, 6, 8 }, 2, 2, 3)]
    [DataRow(new[] { 10, 2, 6, 6, 8 }, 4, 2, 4)]
    [DataRow(new[] { 9, 7, 5, 3, 1 }, 2, 5, 3)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 2, 5, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 100000, 0, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 100000, 2, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 100000, 5, 5)]
    [DataRow(new[] { 1, 100000 }, 0, 2, 1)]
    [DataRow(new[] { 1, 100000 }, 49999, 2, 1)]
    [DataRow(new[] { 1, 100000 }, 50000, 2, 2)]
    [DataRow(new[] { 1, 100000 }, 50000, 1, 1)]
    [DataRow(new[] { 1, 100000 }, 99999, 1, 2)]
    [DataRow(new[] { 99998, 99999, 100000 }, 1, 2, 3)]
    [DataRow(new[] { 100000, 99999, 99998 }, 1, 2, 3)]
    [DataRow(new[] { 1, 1, 1, 10, 10 }, 0, 0, 3)]
    [DataRow(new[] { 1, 1, 1, 10, 10 }, 9, 2, 5)]
    [DataRow(new[] { 1, 1, 1, 10, 10 }, 4, 5, 3)]
    [DataRow(new[] { 1, 1, 1, 10, 10 }, 5, 5, 5)]
    [DataRow(new[] { 2, 6, 10 }, 4, 2, 3)]
    [DataRow(new[] { 2, 6, 10 }, 3, 3, 2)]
    [DataRow(new[] { 4, 4, 5, 6, 6 }, 1, 2, 3)]
    [DataRow(new[] { 1, 10, 20, 20, 20 }, 1, 1, 3)]
    [DataRow(new[] { 1, 1, 5, 5, 9, 9 }, 4, 6, 6)]
    [DataRow(new[] { 1, 1, 5, 5, 9, 9 }, 2, 6, 4)]
    [DataRow(new[] { 2, 4, 4, 6, 8, 8 }, 2, 3, 4)]
    [DataRow(new[] { 1, 1000000000 }, 0, 2, 1)]
    [DataRow(new[] { 1, 1000000000 }, 499999999, 2, 1)]
    [DataRow(new[] { 1, 1000000000 }, 500000000, 2, 2)]
    [DataRow(new[] { 1, 1000000000 }, 500000000, 1, 1)]
    [DataRow(new[] { 1, 1000000000 }, 999999999, 1, 2)]
    [DataRow(new[] { 1, 1000000000 }, 1000000000, 0, 1)]
    [DataRow(new[] { 1, 1000000000 }, 1000000000, 2, 2)]
    [DataRow(new[] { 1000000000 }, 1000000000, 0, 1)]
    [DataRow(new[] { 1000000000 }, 1000000000, 1, 1)]
    [DataRow(new[] { 999999998, 999999999, 1000000000 }, 1, 2, 3)]
    [DataRow(new[] { 1, 1, 1000000000, 1000000000 }, 500000000, 4, 4)]
    [DataRow(new[] { 1, 1, 1000000000, 1000000000 }, 500000000, 3, 3)]
    [DataRow(new[] { 1, 1, 1000000000, 1000000000 }, 500000000, 1, 2)]
    [DataRow(new[] { 1, 1, 1000000000, 1000000000 }, 999999999, 1, 3)]
    [DataRow(new[] { 1, 500000000, 1000000000 }, 500000000, 2, 3)]
    [DataRow(new[] { 1, 500000000, 1000000000 }, 499999999, 3, 2)]
    [DataRow(new[] { 1, 1, 500000000, 1000000000, 1000000000 }, 1000000000, 1, 3)]
    [DataRow(new[] { 1000000000, 1, 1, 1 }, 1000000000, 1, 4)]
    [DataRow(new[] { 1, 4, 4 }, 1000000000, 0, 2)]
    [DataRow(new[] { 1000000000, 500000000, 500000000 }, 1000000000, 0, 2)]
    [DataRow(new[] { 500000000, 500000000 }, 1000000000, 0, 2)]
    [DynamicData(nameof(GetLargeTestData))]
    public void MaxFrequency_WithGivenNumbersAndOperations_ReturnsMaximumAchievableFrequency(int[] nums, int k, int numOperations, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxFrequency(nums, k, numOperations);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [CreateFilledArray(1, 100000), 0, 0, 100000];
        yield return [CreateFilledArray(1000000000, 100000), 1000000000, 100000, 100000];
        yield return [CreateArithmeticArray(10000, 10000, 100000), 0, 100000, 1];
        yield return [CreateArithmeticArray(10000, 10000, 100000), 10000, 100000, 3];
        yield return [CreateArithmeticArray(10000, 10000, 100000), 5000, 2, 2];
        yield return [CreateArithmeticArray(10000, 10000, 100000), 1000000000, 50000, 50001];
        yield return [CreateArithmeticArray(1000000000, -10000, 100000), 1000000000, 100000, 100000];
        yield return [Concatenate(CreateFilledArray(1, 50000), CreateFilledArray(1000000000, 50000)), 500000000, 100000, 100000];
        yield return [Concatenate(CreateFilledArray(1, 50000), CreateFilledArray(1000000000, 50000)), 999999999, 25000, 75000];
    }

    private static int[] CreateFilledArray(int value, int length)
    {
        var result = new int[length];

        Array.Fill(result, value);

        return result;
    }

    private static int[] CreateArithmeticArray(int first, int step, int length)
    {
        var result = new int[length];

        for (var i = 0; i < length; i++)
        {
            result[i] = first + (i * step);
        }

        return result;
    }

    private static int[] Concatenate(int[] left, int[] right)
    {
        var result = new int[left.Length + right.Length];

        Array.Copy(left, result, left.Length);
        Array.Copy(right, 0, result, left.Length, right.Length);

        return result;
    }
}