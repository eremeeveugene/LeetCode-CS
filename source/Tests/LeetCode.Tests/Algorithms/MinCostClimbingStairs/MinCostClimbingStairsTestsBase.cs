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

using LeetCode.Algorithms.MinCostClimbingStairs;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinCostClimbingStairs;

public abstract class MinCostClimbingStairsTestsBase<T> where T : IMinCostClimbingStairs, new()
{
    [TestMethod]
    [DataRow("[]", 0)]
    [DataRow("[10,15,20]", 15)]
    [DataRow("[1,100,1,1,1,100,1,1,100,1]", 6)]
    [DataRow("[0,0,1,2]", 1)]
    [DataRow("[0,0,2,3]", 2)]
    [DataRow("[0,1,2,2]", 2)]
    public void MinCostClimbingStairs_GivenCostArray_ReturnsMinimumCostToClimb(string costJsonArray, int expectedResult)
    {
        // Arrange
        var cost = JsonHelper<int>.DeserializeToArray(costJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinCostClimbingStairs(cost);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}