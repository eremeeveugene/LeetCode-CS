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

using LeetCode.Algorithms.CountNumberOfBadPairs;

namespace LeetCode.Tests.Algorithms.CountNumberOfBadPairs;

public abstract class CountNumberOfBadPairsTestsBase<T> where T : ICountNumberOfBadPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 1, 3, 3 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 10)]
    [DataRow(new[] { 1000000000, 1, 1000000000 }, 3)]
    [DataRow(new[] { 2, 3, 4 }, 0)]
    [DataRow(new[] { 1, 1, 1, 1 }, 6)]
    [DataRow(new[] { 3, 1, 2 }, 2)]
    [DataRow(new[] { 1, 3, 5, 7 }, 6)]
    [DataRow(new[] { 7, 8, 9, 10, 11, 12 }, 0)]
    [DataRow(new[] { 10, 9, 8, 7, 6 }, 10)]
    [DataRow(new[] { 1, 2, 4, 5, 7, 8 }, 12)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 13)]
    [DataRow(new[] { 100, 1, 101, 2, 102, 3 }, 15)]
    [DataRow(new[] { 5, 5, 6, 6, 7, 7, 8 }, 18)]
    [DataRow(new[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 }, 10)]
    [DataRow(new[] { 4, 5, 6, 1, 2, 3 }, 9)]
    [DataRow(new[] { 1, 2, 3, 3, 2, 1 }, 12)]
    public void CountBadPairs_GivenArray_ReturnsCountOfBadPairs(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountBadPairs(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}