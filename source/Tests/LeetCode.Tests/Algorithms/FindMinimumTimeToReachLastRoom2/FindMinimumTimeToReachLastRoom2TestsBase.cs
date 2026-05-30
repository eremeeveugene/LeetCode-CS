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

namespace LeetCode.Tests.Algorithms.FindMinimumTimeToReachLastRoom2;

public abstract class FindMinimumTimeToReachLastRoom2TestsBase<T> where T : IFindMinimumTimeToReachLastRoom2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinTimeToReach_GivenMoveTimeMatrix_ReturnsMinimumTotalTime(int[][] moveTime, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinTimeToReach(moveTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1 }, new[] { 1, 2 } }, 4];

        yield return [new[] { new[] { 0, 4 }, new[] { 4, 4 } }, 7];

        yield return [new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 } }, 6];
    }
}