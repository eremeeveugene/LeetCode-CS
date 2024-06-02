// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.NumberOfGoodPairs;

namespace LeetCode.Tests.Algorithms.NumberOfGoodPairs;

public abstract class NumberOfGoodPairsTestsBase<T> where T : INumberOfGoodPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 1, 1, 3 }, 4)]
    [DataRow(new[] { 1, 1, 1, 1 }, 6)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(
        new[]
        {
            6, 5, 1, 5, 7, 7, 9, 1, 5, 7, 1, 6, 10, 9, 7, 4, 1, 8, 7, 1, 1, 8, 6, 4, 7, 4, 10, 5, 3, 9, 10, 1, 9, 5,
            5, 4, 1, 7, 4, 2, 9, 2, 6, 6, 4, 2, 10, 3, 5, 3, 6, 4, 7, 4, 6, 4, 4, 6, 3, 4, 10, 1, 10, 6, 10, 4, 9,
            6, 6, 4, 8, 6, 9, 5, 4
        }, 303)]
    public void NumIdenticalPairs_WithVariousArrays_ReturnsExpectedCount(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumIdenticalPairs(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}