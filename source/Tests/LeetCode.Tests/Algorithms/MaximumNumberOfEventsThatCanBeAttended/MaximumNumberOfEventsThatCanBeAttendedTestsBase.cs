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

namespace LeetCode.Tests.Algorithms.MaximumNumberOfEventsThatCanBeAttended;

public abstract class MaximumNumberOfEventsThatCanBeAttendedTestsBase<T> where T : IMaximumNumberOfEventsThatCanBeAttended, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxEvents_WithMultipleIntervals_ReturnsMaximumAttendableEvents(int[][] events, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxEvents(events);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 1, 2 } }, 4];
    }
}