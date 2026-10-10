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

using LeetCode.Algorithms.CountNumberOfMaximumBitwiseORSubsets;

namespace LeetCode.Tests.Algorithms.CountNumberOfMaximumBitwiseORSubsets;

public abstract class CountNumberOfMaximumBitwiseORSubsetsTestsBase<T> where T : ICountNumberOfMaximumBitwiseORSubsets, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1 }, 2)]
    [DataRow(new[] { 2, 2, 2 }, 7)]
    [DataRow(new[] { 3, 2, 1, 5 }, 6)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 100000 }, 1)]
    [DataRow(new[] { 1, 1 }, 3)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 1, 2, 4 }, 1)]
    [DataRow(new[] { 1, 2, 4, 8 }, 1)]
    [DataRow(new[] { 5, 5, 5, 5 }, 15)]
    [DataRow(new[] { 1, 3, 7 }, 4)]
    [DataRow(new[] { 7, 3, 1 }, 4)]
    [DataRow(new[] { 6, 2, 4, 1 }, 5)]
    [DataRow(new[] { 8, 8, 8, 1 }, 7)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1 }, 63)]
    [DataRow(new[] { 9, 6, 3, 12 }, 7)]
    [DataRow(new[] { 16, 8, 4, 2, 1 }, 1)]
    [DataRow(new[] { 3, 5, 6 }, 4)]
    [DataRow(new[] { 100000, 1, 2, 3 }, 5)]
    [DataRow(new[] { 2, 3, 2, 3, 2, 3, 2 }, 112)]
    public void CountMaxOrSubsets_GivenArrayOfIntegers_ReturnsNumberOfMaxOrSubsets(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountMaxOrSubsets(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}