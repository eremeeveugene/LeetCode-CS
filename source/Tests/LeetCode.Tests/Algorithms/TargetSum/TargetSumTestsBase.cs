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

using LeetCode.Algorithms.TargetSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TargetSum;

public abstract class TargetSumTestsBase<T> where T : ITargetSum, new()
{
    [TestMethod]
    [DataRow("[1]", 1, 1)]
    [DataRow("[1,0]", 1, 2)]
    [DataRow("[1,1,1,1,1]", 3, 5)]
    [DataRow("[2,1,3,2,1,3,3]", 9, 7)]
    [DataRow("[100,100]", -300, 0)]
    [DataRow("[12,25,42,49,41,15,22,34,28,31]", 35, 8)]
    [DataRow("[3,2,3,5,7,11,13,17,19,23,29,2,7,9,13,27,31,37,47,53]", 107, 0)]
    [DataRow("[3,2,3,5,7,11,13,17,19,23,29,2,107,109,113,127,131,137,47,53]", 4, 2780)]
    public void FindTargetSumWays_WithJsonAndTarget_ReturnsNumberOfWaysToAchieveTarget(string numsJson,
        int target, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindTargetSumWays(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}