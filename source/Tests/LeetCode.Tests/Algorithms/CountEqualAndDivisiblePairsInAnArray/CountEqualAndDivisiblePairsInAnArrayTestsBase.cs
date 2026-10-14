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

using LeetCode.Algorithms.CountEqualAndDivisiblePairsInAnArray;

namespace LeetCode.Tests.Algorithms.CountEqualAndDivisiblePairsInAnArray;

public abstract class CountEqualAndDivisiblePairsInAnArrayTestsBase<T> where T : ICountEqualAndDivisiblePairsInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1, 2, 2, 2, 1, 3 }, 2, 4)]
    [DataRow(new[] { 1, 2, 3, 4 }, 1, 0)]
    [DataRow(new[] { 1 }, 1, 0)]
    [DataRow(new[] { 1, 1 }, 1, 1)]
    [DataRow(new[] { 1, 1 }, 2, 1)]
    [DataRow(new[] { 2, 2, 2 }, 3, 2)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, 5)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 5, 4)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 3, 4)]
    [DataRow(new[] { 7, 7 }, 100, 1)]
    [DataRow(new[] { 1, 2, 3, 1 }, 1, 1)]
    [DataRow(new[] { 4, 4, 4, 4, 4, 4 }, 4, 9)]
    [DataRow(new[] { 3, 3, 3 }, 1, 3)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 7, 13)]
    [DataRow(new[] { 9, 8, 9, 8, 9, 8, 9 }, 6, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 6, 0)]
    [DataRow(new[] { 10, 10, 20, 20, 10, 10 }, 2, 6)]
    [DataRow(new[] { 100, 100, 100 }, 2, 3)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 10, 13)]
    [DataRow(new[] { 6, 5, 6, 5, 6, 5, 6, 5 }, 3, 8)]
    public void CountPairs_WithEqualElementsAndIndexProductDivisibleByK_ReturnsTheNumberOfPairs(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountPairs(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}