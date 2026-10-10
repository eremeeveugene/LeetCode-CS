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

using LeetCode.Algorithms.MinimizeMaximumPairSumInArray;

namespace LeetCode.Tests.Algorithms.MinimizeMaximumPairSumInArray;

public abstract class MinimizeMaximumPairSumInArrayTestsBase<T> where T : IMinimizeMaximumPairSumInArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 5, 2, 3 }, 7)]
    [DataRow(new[] { 3, 5, 4, 2, 4, 6 }, 8)]
    [DataRow(new[] { 1, 1 }, 2)]
    [DataRow(new[] { 100000, 100000 }, 200000)]
    [DataRow(new[] { 1, 100000 }, 100001)]
    [DataRow(new[] { 1, 2, 3, 4 }, 5)]
    [DataRow(new[] { 4, 3, 2, 1 }, 5)]
    [DataRow(new[] { 5, 5, 5, 5 }, 10)]
    [DataRow(new[] { 1, 1, 1, 100000 }, 100001)]
    [DataRow(new[] { 2, 9, 4, 7 }, 11)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 4 }, 5)]
    [DataRow(new[] { 6, 6, 1, 1 }, 7)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60 }, 70)]
    [DataRow(new[] { 1, 100000, 1, 100000 }, 100001)]
    [DataRow(new[] { 7, 3, 5, 1, 9, 2 }, 10)]
    [DataRow(new[] { 8, 8, 8, 2, 2, 2 }, 10)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 9)]
    [DataRow(new[] { 100, 1, 50, 51 }, 101)]
    [DataRow(new[] { 3, 3, 3, 3, 3, 3, 3, 3 }, 6)]
    [DataRow(new[] { 100000, 99999, 1, 2, 50000, 50001, 3, 4 }, 100001)]
    public void MinPairSum_WithNumsArray_ReturnsMinimizedMaximumPairSum(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinPairSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}