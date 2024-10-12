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

using LeetCode.Algorithms.DivideIntervalsIntoMinimumNumberOfGroups;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DivideIntervalsIntoMinimumNumberOfGroups;

public abstract class DivideIntervalsIntoMinimumNumberOfGroupsTestsBase<T>
    where T : IDivideIntervalsIntoMinimumNumberOfGroups, new()
{
    [TestMethod]
    [DataRow("[[5,10],[6,8],[1,5],[2,3],[1,10]]", 3)]
    [DataRow("[[1,3],[5,6],[8,10],[11,13]]", 1)]
    public void MinGroups_GivenIntervals_ReturnsMinimumNumberOfGroups(string intervalsJsonArray, long expectedResult)
    {
        // Arrange
        var intervals = JsonHelper<int>.DeserializeToJaggedArray(intervalsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinGroups(intervals);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}