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

using LeetCode.Algorithms.SumOfGoodNumbers;

namespace LeetCode.Tests.Algorithms.SumOfGoodNumbers;

public abstract class SumOfGoodNumbersTestsBase<T> where T : ISumOfGoodNumbers, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 2, 1, 5, 4 }, 2, 12)]
    [DataRow(new[] { 2, 1 }, 1, 2)]
    [DataRow(new[] { 1, 2 }, 1, 2)]
    [DataRow(new[] { 5, 5 }, 1, 0)]
    [DataRow(new[] { 10000, 1 }, 1, 10000)]
    [DataRow(new[] { 1, 10000 }, 1, 10000)]
    [DataRow(new[] { 1, 2, 3 }, 1, 3)]
    [DataRow(new[] { 3, 2, 1 }, 1, 3)]
    [DataRow(new[] { 1, 3, 2 }, 1, 3)]
    [DataRow(new[] { 2, 3, 2, 3 }, 1, 6)]
    [DataRow(new[] { 4, 4, 4, 4 }, 2, 0)]
    [DataRow(new[] { 1, 5, 2, 6, 3, 7 }, 2, 10)]
    [DataRow(new[] { 9, 1, 9, 1, 9, 1 }, 2, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3, 15)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, 3, 15)]
    [DataRow(new[] { 7, 7, 7, 7, 7, 7, 7, 7 }, 4, 0)]
    [DataRow(new[] { 1, 9, 2, 8, 3, 7, 4, 6 }, 3, 30)]
    [DataRow(new[] { 10, 20, 30, 20, 10 }, 2, 30)]
    [DataRow(new[] { 5, 1, 1, 5 }, 1, 10)]
    [DataRow(new[] { 2, 1, 3 }, 2, 4)]
    [DataRow(new[] { 4, 9, 4, 9, 4 }, 1, 18)]
    public void SumOfGoodNumbers_WithArrayAndThresholdK_ReturnsSumOfGoodNumbers(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOfGoodNumbers(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}