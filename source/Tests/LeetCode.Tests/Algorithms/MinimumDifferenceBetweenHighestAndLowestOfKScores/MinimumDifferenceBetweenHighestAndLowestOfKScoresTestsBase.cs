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

using LeetCode.Algorithms.MinimumDifferenceBetweenHighestAndLowestOfKScores;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumDifferenceBetweenHighestAndLowestOfKScores;

public abstract class MinimumDifferenceBetweenHighestAndLowestOfKScoresTestsBase<T>
    where T : IMinimumDifferenceBetweenHighestAndLowestOfKScores, new()
{
    [TestMethod]
    [DataRow("[90]", 1, 0)]
    [DataRow("[9,4,1,7]", 2, 2)]
    [DataRow("[9,4,1,7]", 3, 5)]
    [DataRow("[9,4,1,7]", 4, 8)]
    public void MinimumDifference_WithKSelectedScores_ReturnsMinimumScoreRange(string numsJson, int k,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumDifference(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}