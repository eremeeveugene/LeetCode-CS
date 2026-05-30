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

using LeetCode.Algorithms.DivideIntervalsIntoMinimumNumberOfGroups;

namespace LeetCode.Tests.Algorithms.DivideIntervalsIntoMinimumNumberOfGroups;

public abstract class DivideIntervalsIntoMinimumNumberOfGroupsTestsBase<T> where T : IDivideIntervalsIntoMinimumNumberOfGroups, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinGroups_GivenIntervals_ReturnsMinimumNumberOfGroups(int[][] intervals, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinGroups(intervals);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 5, 10 }, new[] { 6, 8 }, new[] { 1, 5 }, new[] { 2, 3 }, new[] { 1, 10 } }, 3L];

        yield return [new[] { new[] { 1, 3 }, new[] { 5, 6 }, new[] { 8, 10 }, new[] { 11, 13 } }, 1L];
    }
}