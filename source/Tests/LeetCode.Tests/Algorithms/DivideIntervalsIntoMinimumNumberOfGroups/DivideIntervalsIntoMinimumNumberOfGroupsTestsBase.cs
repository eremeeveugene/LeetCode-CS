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

        yield return [new[] { new[] { 1, 1 } }, 1L];

        yield return [new[] { new[] { 1, 2 } }, 1L];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 2L];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 } }, 2L];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 1L];

        yield return [new[] { new[] { 1, 5 }, new[] { 2, 3 }, new[] { 3, 4 } }, 3L];

        yield return [new[] { new[] { 1, 10 }, new[] { 2, 9 }, new[] { 3, 8 }, new[] { 4, 7 }, new[] { 5, 6 } }, 5L];

        yield return [new[] { new[] { 1, 1000000 } }, 1L];

        yield return [new[] { new[] { 1, 1000000 }, new[] { 1000000, 1000000 } }, 2L];

        yield return [new[] { new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 5 }, new[] { 4, 6 } }, 3L];

        yield return [new[] { new[] { 5, 5 }, new[] { 5, 5 }, new[] { 5, 5 } }, 3L];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, 2L];

        yield return [new[] { new[] { 10, 20 }, new[] { 1, 5 }, new[] { 6, 9 }, new[] { 21, 30 } }, 1L];

        yield return [new[] { new[] { 1, 4 }, new[] { 2, 5 }, new[] { 6, 8 }, new[] { 7, 9 } }, 2L];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 3, 4 }, new[] { 3, 4 } }, 3L];

        yield return [new[] { new[] { 100, 200 }, new[] { 150, 250 }, new[] { 199, 300 } }, 3L];

        yield return [new[] { new[] { 2, 3 }, new[] { 1, 10 }, new[] { 4, 5 }, new[] { 6, 7 }, new[] { 8, 9 } }, 2L];

        yield return [new[] { new[] { 1, 3 }, new[] { 4, 6 }, new[] { 2, 5 } }, 2L];
    }
}