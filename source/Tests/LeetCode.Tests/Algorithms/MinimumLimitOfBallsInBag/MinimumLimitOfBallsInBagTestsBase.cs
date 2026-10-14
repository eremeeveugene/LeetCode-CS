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

using LeetCode.Algorithms.MinimumLimitOfBallsInBag;

namespace LeetCode.Tests.Algorithms.MinimumLimitOfBallsInBag;

public abstract class MinimumLimitOfBallsInBagTestsBase<T> where T : IMinimumLimitOfBallsInBag, new()
{
    [TestMethod]
    [DataRow(new[] { 9 }, 2, 3)]
    [DataRow(new[] { 2, 4, 8, 2 }, 4, 2)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1 }, 1000000000, 1)]
    [DataRow(new[] { 10 }, 1, 5)]
    [DataRow(new[] { 10 }, 9, 1)]
    [DataRow(new[] { 10 }, 0, 10)]
    [DataRow(new[] { 7, 7, 7 }, 3, 4)]
    [DataRow(new[] { 3, 5, 7, 9 }, 6, 3)]
    [DataRow(new[] { 100, 1 }, 5, 17)]
    [DataRow(new[] { 1, 1, 1, 1 }, 0, 1)]
    [DataRow(new[] { 2, 4, 8, 16 }, 10, 3)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 20, 1)]
    [DataRow(new[] { 17, 33, 49 }, 7, 11)]
    [DataRow(new[] { 30 }, 29, 1)]
    [DataRow(new[] { 12, 24, 36 }, 2, 18)]
    [DataRow(new[] { 9, 9, 9, 9 }, 4, 5)]
    [DataRow(new[] { 64, 32, 16, 8 }, 12, 8)]
    [DataRow(new[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 }, 1000000000, 5)]
    [DataRow(new[] { 1000000000 }, 1, 500000000)]
    public void MinimumSize_WithNumsArrayAndMaxOperations_ReturnsMinimumPossibleSize(int[] nums, int maxOperations, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumSize(nums, maxOperations);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}