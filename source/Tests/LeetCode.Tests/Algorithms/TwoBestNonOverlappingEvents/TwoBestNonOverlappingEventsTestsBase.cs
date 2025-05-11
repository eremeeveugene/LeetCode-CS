// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.TwoBestNonOverlappingEvents;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TwoBestNonOverlappingEvents;

public abstract class TwoBestNonOverlappingEventsTestsBase<T> where T : ITwoBestNonOverlappingEvents, new()
{
    [TestMethod]
    [DataRow("[[1,3,2],[4,5,2],[2,4,3]]", 4)]
    [DataRow("[[1,3,2],[4,5,2],[1,5,5]]", 5)]
    [DataRow("[[1,5,3],[1,5,1],[6,6,5]]", 8)]
    public void MaxTwoEvents_WithEventStartEndAndValue_ReturnsMaximumValueFromNonOverlappingEvents(string eventsJson,
        int expectedResult)
    {
        // Arrange
        var events = JsonHelper<int[][]>.Parse(eventsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxTwoEvents(events);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}