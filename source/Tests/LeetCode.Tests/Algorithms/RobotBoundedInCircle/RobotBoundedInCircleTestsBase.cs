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

using LeetCode.Algorithms.RobotBoundedInCircle;

namespace LeetCode.Tests.Algorithms.RobotBoundedInCircle;

public abstract class RobotBoundedInCircleTestsBase<T> where T : IRobotBoundedInCircle, new()
{
    [TestMethod]
    [DataRow("GGLLGG", true)]
    [DataRow("GL", true)]
    [DataRow("GG", false)]
    [DataRow("GLGLGGLGL", false)]
    public void IsRobotBounded_WithMovementInstructions_ReturnsIfRobotIsBounded(string instructions,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsRobotBounded(instructions);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}