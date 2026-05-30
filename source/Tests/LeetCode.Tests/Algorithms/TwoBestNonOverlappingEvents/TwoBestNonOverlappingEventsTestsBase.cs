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

using LeetCode.Algorithms.TwoBestNonOverlappingEvents;

namespace LeetCode.Tests.Algorithms.TwoBestNonOverlappingEvents;

public abstract class TwoBestNonOverlappingEventsTestsBase<T> where T : ITwoBestNonOverlappingEvents, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxTwoEvents_WithEventStartEndAndValue_ReturnsMaximumValueFromNonOverlappingEvents(int[][] events,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxTwoEvents(events);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 3, 2 }, new[] { 4, 5, 2 }, new[] { 2, 4, 3 } }, 4];

        yield return [new[] { new[] { 1, 3, 2 }, new[] { 4, 5, 2 }, new[] { 1, 5, 5 } }, 5];

        yield return [new[] { new[] { 1, 5, 3 }, new[] { 1, 5, 1 }, new[] { 6, 6, 5 } }, 8];
    }
}