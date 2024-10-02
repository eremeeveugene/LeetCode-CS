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

using LeetCode.Algorithms.DetermineIfTwoEventsHaveConflict;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DetermineIfTwoEventsHaveConflict;

public abstract class DetermineIfTwoEventsHaveConflictTestsBase<T> where T : IDetermineIfTwoEventsHaveConflict, new()
{
    [TestMethod]
    [DataRow("[\"01:15\",\"02:00\"]", "[\"02:00\",\"03:00\"]", true)]
    [DataRow("[\"01:00\",\"02:00\"]", "[\"01:20\",\"03:00\"]", true)]
    [DataRow("[\"10:00\",\"11:00\"]", "[\"14:00\",\"15:00\"]", false)]
    public void HaveConflict_GivenTwoEventTimeRanges_ReturnsIfConflictExists(string event1JsonArray,
        string event2JsonArray, bool expectedResult)
    {
        // Arrange
        var event1 = JsonHelper<string>.DeserializeToArray(event1JsonArray);
        var event2 = JsonHelper<string>.DeserializeToArray(event2JsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.HaveConflict(event1, event2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}