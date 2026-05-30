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

using LeetCode.Algorithms.TeemoAttacking;

namespace LeetCode.Tests.Algorithms.TeemoAttacking;

public abstract class TeemoAttackingTestsBase<T> where T : ITeemoAttacking, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4 }, 2, 4)]
    [DataRow(new[] { 1, 2 }, 2, 3)]
    public void FindPoisonedDuration_WithOverlappingOrConsecutiveAttacks_ReturnsTotalPoisonedTime(int[] timeSeries,
        int duration, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindPoisonedDuration(timeSeries, duration);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}