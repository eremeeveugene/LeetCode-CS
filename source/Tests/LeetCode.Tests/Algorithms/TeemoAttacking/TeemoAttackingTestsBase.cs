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

using LeetCode.Algorithms.TeemoAttacking;

namespace LeetCode.Tests.Algorithms.TeemoAttacking;

public abstract class TeemoAttackingTestsBase<T> where T : ITeemoAttacking, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4 }, 2, 4)]
    [DataRow(new[] { 1, 2 }, 2, 3)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1 }, 10000000, 10000000)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, 9)]
    [DataRow(new[] { 1, 10 }, 5, 10)]
    [DataRow(new[] { 1, 10 }, 9, 18)]
    [DataRow(new[] { 1, 10 }, 10, 19)]
    [DataRow(new[] { 1, 10 }, 11, 20)]
    [DataRow(new[] { 0, 1 }, 1, 2)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 2, 10)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 3, 11)]
    [DataRow(new[] { 2, 4, 8, 16, 32 }, 4, 18)]
    [DataRow(new[] { 10, 20, 30 }, 100, 120)]
    [DataRow(new[] { 1, 1000000 }, 1000000, 1999999)]
    [DataRow(new[] { 1, 10000000 }, 10000000, 19999999)]
    [DataRow(new[] { 5, 6, 100, 101 }, 3, 8)]
    [DataRow(new[] { 1, 2, 4, 7, 11, 16 }, 3, 15)]
    [DataRow(new[] { 0, 1000, 2000 }, 1000, 3000)]
    [DynamicData(nameof(GetLargeTestData))]
    public void FindPoisonedDuration_WithOverlappingOrConsecutiveAttacks_ReturnsTotalPoisonedTime(int[] timeSeries, int duration, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindPoisonedDuration(timeSeries, duration);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [BuildTimeSeries(10000, 1), 10000000, 10009999];

        yield return [BuildTimeSeries(10000, 1000), 5, 50000];

        yield return [BuildTimeSeries(10000, 1000), 1000, 10000000];
    }

    private static int[] BuildTimeSeries(int length, int step)
    {
        var timeSeries = new int[length];

        for (var i = 0; i < length; i++)
        {
            timeSeries[i] = 1 + (i * step);
        }

        return timeSeries;
    }
}