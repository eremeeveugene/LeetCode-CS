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

using LeetCode.Algorithms.MaximumNumberOfEventsThatCanBeAttended;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfEventsThatCanBeAttended;

public abstract class MaximumNumberOfEventsThatCanBeAttendedTestsBase<T>
    where T : IMaximumNumberOfEventsThatCanBeAttended, new()
{
    [TestMethod]
    [DataRow("[[1,2],[2,3],[3,4]]", 3)]
    [DataRow("[[1,2],[2,3],[3,4],[1,2]]", 4)]
    public void MaxEvents_WithMultipleIntervals_ReturnsMaximumAttendableEvents(string eventsJson, int expectedResult)
    {
        // Arrange
        var events = JsonHelper<int[][]>.Parse(eventsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxEvents(events);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}