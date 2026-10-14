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
    [DataRow(10, 89)]
    [DataRow(11, 144)]
    [DataRow(12, 233)]
    [DataRow(13, 377)]
    [DataRow(14, 610)]
    [DataRow(15, 987)]
    [DataRow(16, 1597)]
    [DataRow(17, 2584)]
    [DataRow(18, 4181)]
    [DataRow(19, 6765)]
    [DataRow(20, 10946)]
    [DataRow(25, 121393)]
    [DataRow(30, 1346269)]
    [DataRow(35, 14930352)]
    [DataRow(40, 165580141)]
    [DataRow(45, 1836311903)]
    public void ClimbStairs_WithNumberOfSteps_ReturnsTotalDistinctWaysToReachTop(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ClimbStairs(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}