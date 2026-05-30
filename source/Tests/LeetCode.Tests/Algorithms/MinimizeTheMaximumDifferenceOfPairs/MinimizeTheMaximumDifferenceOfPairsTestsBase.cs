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

using LeetCode.Algorithms.MinimizeTheMaximumDifferenceOfPairs;

namespace LeetCode.Tests.Algorithms.MinimizeTheMaximumDifferenceOfPairs;

public abstract class MinimizeTheMaximumDifferenceOfPairsTestsBase<T>
    where T : IMinimizeTheMaximumDifferenceOfPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 1, 2, 7, 1, 3 }, 2, 1)]
    [DataRow(new[] { 4, 2, 1, 2 }, 1, 0)]
    public void MinimizeMax_WithNumsAndPairCount_ReturnsMinimumPossibleMaximumDifferenceAmongPairs(int[] nums,
        int requiredPairsCount, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimizeMax(nums, requiredPairsCount);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}