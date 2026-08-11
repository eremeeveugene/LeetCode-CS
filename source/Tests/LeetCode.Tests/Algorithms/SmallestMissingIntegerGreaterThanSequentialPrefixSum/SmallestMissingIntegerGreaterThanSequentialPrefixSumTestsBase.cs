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

using LeetCode.Algorithms.SmallestMissingIntegerGreaterThanSequentialPrefixSum;

namespace LeetCode.Tests.Algorithms.SmallestMissingIntegerGreaterThanSequentialPrefixSum;

public abstract class SmallestMissingIntegerGreaterThanSequentialPrefixSumTestsBase<T>
    where T : ISmallestMissingIntegerGreaterThanSequentialPrefixSum, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 2, 5 }, 6)]
    [DataRow(new[] { 3, 4, 5, 1, 12, 14, 13 }, 15)]
    [DataRow(new[] { 1 }, 2)]
    [DataRow(new[] { 2, 3, 4 }, 9)]
    [DataRow(new[] { 5, 1, 2, 3 }, 6)]
    [DataRow(new[] { 1, 1, 1 }, 2)]
    [DataRow(new[] { 50 }, 51)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 15)]
    [DataRow(new[] { 10, 11, 9, 12 }, 21)]
    [DataRow(new[] { 1, 2, 2, 3 }, 4)]
    [DataRow(new[] { 7, 8, 9, 10, 1, 2, 3 }, 34)]
    [DataRow(new[] { 4, 5, 6, 7, 8, 9, 10 }, 49)]
    [DataRow(new[] { 2, 1 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 55)]
    [DataRow(new[] { 3, 1, 2 }, 4)]
    [DataRow(new[] { 1, 3, 5 }, 2)]
    [DataRow(new[] { 6, 7, 8, 6, 7, 8 }, 21)]
    [DataRow(new[] { 1, 2, 4, 5, 6 }, 3)]
    [DataRow(new[] { 9, 10, 11, 12, 13, 1, 2, 3, 4, 5, 6, 7, 8 }, 55)]
    [DataRow(new[] { 2, 3, 4, 5, 1 }, 14)]
    public void MissingInteger_WithNums_ReturnsSmallestMissingInteger(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MissingInteger(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}