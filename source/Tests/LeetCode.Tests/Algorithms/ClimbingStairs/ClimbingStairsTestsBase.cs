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

using LeetCode.Algorithms.ClimbingStairs;

namespace LeetCode.Tests.Algorithms.ClimbingStairs;

public abstract class ClimbingStairsTestsBase<T> where T : IClimbingStairs, new()
{
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 2)]
    [DataRow(3, 3)]
    [DataRow(4, 5)]
    [DataRow(5, 8)]
    [DataRow(6, 13)]
    [DataRow(7, 21)]
    [DataRow(8, 34)]
    [DataRow(9, 55)]
    public void ClimbStairs_WithGivenN_ReturnsExpectedWaysToClimb(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ClimbStairs(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}