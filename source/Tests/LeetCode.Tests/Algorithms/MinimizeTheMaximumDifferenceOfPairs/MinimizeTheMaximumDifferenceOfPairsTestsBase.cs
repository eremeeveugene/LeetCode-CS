// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimizeTheMaximumDifferenceOfPairs;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimizeTheMaximumDifferenceOfPairs;

public abstract class MinimizeTheMaximumDifferenceOfPairsTestsBase<T>
    where T : IMinimizeTheMaximumDifferenceOfPairs, new()
{
    [TestMethod]
    [DataRow("[10,1,2,7,1,3]", 2, 1)]
    [DataRow("[4,2,1,2]", 1, 0)]
    public void MinimizeMax_WithNumsAndPairCount_ReturnsMinimumPossibleMaximumDifferenceAmongPairs(string numsJson,
        int requiredPairsCount, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimizeMax(nums, requiredPairsCount);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}