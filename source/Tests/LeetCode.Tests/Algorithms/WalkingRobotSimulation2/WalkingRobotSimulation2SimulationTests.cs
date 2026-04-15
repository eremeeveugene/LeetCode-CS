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

using LeetCode.Algorithms.WalkingRobotSimulation2;

namespace LeetCode.Tests.Algorithms.WalkingRobotSimulation2;

[TestClass]
public sealed class WalkingRobotSimulation2SimulationTests : WalkingRobotSimulation2TestsBase
{
    protected override IWalkingRobotSimulation2 CreateSolution(int width, int height)
    {
        return new WalkingRobotSimulation2Simulation(width, height);
    }
}