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

using LeetCode.Algorithms.RobotReturnToOrigin;

namespace LeetCode.Tests.Algorithms.RobotReturnToOrigin;

public abstract class RobotReturnToOriginTestsBase<T> where T : IRobotReturnToOrigin, new()
{
    [TestMethod]
    [DataRow("UD", true)]
    [DataRow("LL", false)]
    public void JudgeCircle_WithMoveSequence_ReturnsIfReturnsToOrigin(string moves, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.JudgeCircle(moves);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}