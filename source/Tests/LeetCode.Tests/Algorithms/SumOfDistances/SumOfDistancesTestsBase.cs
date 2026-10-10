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

using LeetCode.Algorithms.SumOfDistances;

namespace LeetCode.Tests.Algorithms.SumOfDistances;

public abstract class SumOfDistancesTestsBase<T> where T : ISumOfDistances, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 1, 1, 2 }, new long[] { 5, 0, 3, 4, 0 })]
    [DataRow(new[] { 0, 5, 3 }, new long[] { 0, 0, 0 })]
    [DataRow(new[] { 7 }, new long[] { 0 })]
    [DataRow(new[] { 4, 4 }, new long[] { 1, 1 })]
    [DataRow(new[] { 4, 5 }, new long[] { 0, 0 })]
    [DataRow(new[] { 2, 2, 2, 2 }, new long[] { 6, 4, 4, 6 })]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, new long[] { 6, 6, 4, 4, 6, 6 })]
    [DataRow(new[] { 1, 1, 1, 2, 2 }, new long[] { 3, 2, 3, 1, 1 })]
    [DataRow(new[] { -1, -2, -1 }, new long[] { 2, 0, 2 })]
    [DataRow(new[] { 5, 1, 5, 2, 5 }, new long[] { 6, 0, 4, 0, 6 })]
    [DataRow(new[] { 9, 1, 2, 3, 9 }, new long[] { 4, 0, 0, 0, 4 })]
    [DataRow(new[] { 0 }, new long[] { 0 })]
    [DataRow(new[] { 1000000000 }, new long[] { 0 })]
    [DataRow(new[] { 3, 3, 3 }, new long[] { 3, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new long[] { 0, 0, 0, 0, 0 })]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5, 5 }, new long[] { 21, 16, 13, 12, 13, 16, 21 })]
    [DataRow(new[] { 1, 2, 2, 1, 1, 2 }, new long[] { 7, 5, 4, 4, 5, 7 })]
    [DataRow(new[] { 0, 0, 0, 1, 1, 1, 0 }, new long[] { 9, 7, 7, 3, 2, 3, 15 })]
    [DataRow(new[] { 1000000000, 1, 1000000000, 1 }, new long[] { 2, 2, 2, 2 })]
    [DataRow(new[] { -5, -5, 5, 5, -5 }, new long[] { 5, 4, 1, 1, 7 })]
    [DataRow(new[] { 8, 9, 8, 9, 8, 9, 8, 9, 8 }, new long[] { 20, 12, 14, 8, 12, 8, 14, 12, 20 })]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 1, 1 }, new long[] { 14, 12, 1, 1, 1, 1, 12, 14 })]
    public void Distance_WithGivenNums_ReturnsSumOfIndexDistancesForEqualElements(int[] nums, long[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Distance(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}