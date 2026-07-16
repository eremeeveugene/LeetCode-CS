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

using LeetCode.Algorithms.SumOfGcdOfFormedPairs;

namespace LeetCode.Tests.Algorithms.SumOfGcdOfFormedPairs;

public abstract class SumOfGcdOfFormedPairsTestsBase<T> where T : ISumOfGcdOfFormedPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 6, 4 }, 2L)]
    [DataRow(new[] { 3, 6, 2, 8 }, 5L)]
    [DataRow(new[] { 1 }, 0L)]
    [DataRow(new[] { 17 }, 0L)]
    [DataRow(new[] { 1, 1 }, 1L)]
    [DataRow(new[] { 5, 10 }, 5L)]
    [DataRow(new[] { 2, 3 }, 1L)]
    [DataRow(new[] { 1000000000, 1000000000 }, 1000000000L)]
    [DataRow(new[] { 1000000000, 999999999 }, 1L)]
    [DataRow(new[] { 2, 4, 8, 16 }, 6L)]
    [DataRow(new[] { 7, 3, 5 }, 1L)]
    [DataRow(new[] { 10, 5, 15, 20 }, 10L)]
    [DataRow(new[] { 6, 6, 6, 6 }, 12L)]
    [DataRow(new[] { 9, 3, 6, 12 }, 6L)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3L)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 2L)]
    [DataRow(new[] { 100, 50, 25 }, 25L)]
    [DataRow(new[] { 8, 12, 20 }, 4L)]
    [DataRow(new[] { 4, 4, 4 }, 4L)]
    [DataRow(new[] { 2, 6, 4, 8, 10, 12 }, 6L)]
    [DataRow(new[] { 3, 9, 27 }, 3L)]
    [DataRow(new[] { 14, 7, 21, 28 }, 14L)]
    public void GcdSum_WithIntegerArray_ReturnsSumOfGcdValuesOfFormedPairs(int[] nums, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GcdSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}