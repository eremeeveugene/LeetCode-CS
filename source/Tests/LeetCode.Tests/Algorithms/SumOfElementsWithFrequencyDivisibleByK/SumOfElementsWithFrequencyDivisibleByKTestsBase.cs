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

using LeetCode.Algorithms.SumOfElementsWithFrequencyDivisibleByK;

namespace LeetCode.Tests.Algorithms.SumOfElementsWithFrequencyDivisibleByK;

public abstract class SumOfElementsWithFrequencyDivisibleByKTestsBAse<T> where T : ISumOfElementsWithFrequencyDivisibleByK, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3, 3, 4 }, 2, 16)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 0)]
    [DataRow(new[] { 4, 4, 4, 1, 2, 3 }, 3, 12)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1 }, 2, 0)]
    [DataRow(new[] { 100 }, 1, 100)]
    [DataRow(new[] { 100, 100 }, 2, 200)]
    [DataRow(new[] { 100, 100, 100 }, 2, 0)]
    [DataRow(new[] { 5, 5, 5, 5 }, 4, 20)]
    [DataRow(new[] { 5, 5, 5, 5 }, 3, 0)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 2, 12)]
    [DataRow(new[] { 1, 1, 2, 2, 2, 3 }, 1, 11)]
    [DataRow(new[] { 7, 7, 7, 8, 8, 8, 9 }, 3, 45)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 100, 0)]
    [DataRow(new[] { 10, 10, 20, 20, 20, 20, 30 }, 2, 100)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2 }, 6, 12)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2 }, 4, 0)]
    [DataRow(new[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 }, 100, 5000)]
    [DataRow(new[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 }, 99, 0)]
    [DataRow(new[] { 99, 100, 99, 100, 99, 100, 99, 100 }, 4, 796)]
    [DataRow(new[] { 1, 1, 1, 2, 2, 3 }, 3, 3)]
    public void SumDivisibleByK_WithNumsAndDivisorK_ReturnsSumOfElementsWithFrequencyDivisibleByK(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumDivisibleByK(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}