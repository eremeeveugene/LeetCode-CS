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

using LeetCode.Algorithms.FindMinimumTimeToReachLastRoom2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindMinimumTimeToReachLastRoom2;

public abstract class FindMinimumTimeToReachLastRoom2TestsBase<T> where T : IFindMinimumTimeToReachLastRoom2, new()
{
    [TestMethod]
    [DataRow("[[0,1],[1,2]]", 4)]
    [DataRow("[[0,4],[4,4]]", 7)]
    [DataRow("[[0,0,0,0],[0,0,0,0]]", 6)]
    public void MinTimeToReach_GivenMoveTimeMatrix_ReturnsMinimumTotalTime(string moveTimeJson, int expectedResult)
    {
        // Arrange
        var moveTime = JsonHelper.Parse<int[][]>(moveTimeJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinTimeToReach(moveTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}