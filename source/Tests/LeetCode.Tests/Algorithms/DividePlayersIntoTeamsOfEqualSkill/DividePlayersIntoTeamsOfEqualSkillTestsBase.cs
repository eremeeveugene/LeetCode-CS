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

using LeetCode.Algorithms.DividePlayersIntoTeamsOfEqualSkill;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DividePlayersIntoTeamsOfEqualSkill;

public abstract class DividePlayersIntoTeamsOfEqualSkillTestsBase<T>
    where T : IDividePlayersIntoTeamsOfEqualSkill, new()
{
    [TestMethod]
    [DataRow("[3,2,5,1,3,4]", 22)]
    [DataRow("[3,4]", 12)]
    [DataRow("[1,1,2,3]", -1)]
    public void DividePlayers_WithSkillArray_ReturnsTotalSkillSum(string skillJsonArray, long expectedResult)
    {
        // Arrange
        var skill = JsonHelper<int>.DeserializeToArray(skillJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.DividePlayers(skill);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}