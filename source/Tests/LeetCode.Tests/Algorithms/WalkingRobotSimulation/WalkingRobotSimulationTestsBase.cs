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

using LeetCode.Algorithms.WalkingRobotSimulation;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.WalkingRobotSimulation;

public abstract class WalkingRobotSimulationTestsBase<T> where T : IWalkingRobotSimulation, new()
{
    [TestMethod]
    [DataRow(new[] { 4, -1, 3 }, "[]", 25)]
    [DataRow(new[] { 4, -1, 4, -2, 4 }, "[[2,4]]", 65)]
    [DataRow(new[] { 6, -1, -1, 6 }, "[]", 36)]
    [DataRow(new[] { -2, 8, 3, 7, -1 }, "[[-4,-1],[1,-1],[1,4],[5,0],[4,5],[-2,-1],[2,-5],[5,1],[-3,-1],[5,-3]]", 324)]
    [DataRow(new[] { 9, -1, 9, -2, 3 }, "[[4,8], [5,6], [7,7], [8,4]]", 225)]
    [DataRow(new[] { 1 }, "[[2,2], [3,3]]", 1)]
    [DataRow(new[] { 9, -1, 9, 9, -2, 9, 9, -1, 9, 9, -2, 9, 9, 9, -1, 9, 9, -2, 9, 9, -1, -1, 9, 9 },
        "[[10,10], [5,5], [8,8], [15,15], [20,20]]", 8100)]
    public void RobotSim_WithCommandsAndObstacles_ReturnsCorrectFinalDistance(int[] commands, string obstaclesJsonArray,
        int expectedResult)
    {
        // Arrange
        var obstacles = JsonHelper<int>.DeserializeToJaggedArray(obstaclesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RobotSim(commands, obstacles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}