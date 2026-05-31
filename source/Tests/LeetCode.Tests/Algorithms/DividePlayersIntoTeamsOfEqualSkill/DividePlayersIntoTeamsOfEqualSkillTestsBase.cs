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

using LeetCode.Algorithms.DividePlayersIntoTeamsOfEqualSkill;

namespace LeetCode.Tests.Algorithms.DividePlayersIntoTeamsOfEqualSkill;

public abstract class DividePlayersIntoTeamsOfEqualSkillTestsBase<T> where T : IDividePlayersIntoTeamsOfEqualSkill, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 5, 1, 3, 4 }, 22L)]
    [DataRow(new[] { 3, 4 }, 12L)]
    [DataRow(new[] { 1, 1, 2, 3 }, -1L)]
    [DataRow(new[] { 1, 1 }, 1L)]
    [DataRow(new[] { 2, 2 }, 4L)]
    [DataRow(new[] { 1, 3 }, 3L)]
    [DataRow(new[] { 1, 2 }, 2L)]
    [DataRow(new[] { 2, 1, 3, 2 }, 7L)]
    [DataRow(new[] { 1, 2, 3, 4 }, 10L)]
    [DataRow(new[] { 4, 3, 2, 1 }, 10L)]
    [DataRow(new[] { 5, 5, 5, 5 }, 50L)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2L)]
    [DataRow(new[] { 2, 3 }, 6L)]
    [DataRow(new[] { 1, 2, 3, 2, 1, 3 }, 10L)]
    [DataRow(new[] { 10, 1 }, 10L)]
    [DataRow(new[] { 5, 1, 4, 2 }, 13L)]
    [DataRow(new[] { 1000, 1000 }, 1000000L)]
    [DataRow(new[] { 1, 1000, 2, 999 }, 2998L)]
    public void DividePlayers_WithSkillArray_ReturnsTotalSkillSum(int[] skill, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DividePlayers(skill);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}