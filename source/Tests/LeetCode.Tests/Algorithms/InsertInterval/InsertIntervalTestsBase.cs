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

using LeetCode.Algorithms.InsertInterval;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.InsertInterval;

public abstract class InsertIntervalTestsBase<T> where T : IInsertInterval, new()
{
    [TestMethod]
    [DataRow("[]", "[2,5]", "[[2,5]]")]
    [DataRow("[[1,3],[6,9]]", "[2,5]", "[[1,5],[6,9]]")]
    [DataRow("[[1,2],[3,5],[6,7],[8,10],[12,16]]", "[4,8]", "[[1,2],[3,10],[12,16]]")]
    [DataRow("[[1,5]]", "[6,8]", "[[1,5],[6,8]]")]
    [DataRow("[[1,5]]", "[0,0]", "[[0,0],[1,5]]")]
    [DataRow("[[3,5],[12,15]]", "[6,6]", "[[3,5],[6,6],[12,15]]")]
    public void Insert_GivenIntervalsAndNewInterval_MergesOrAddsIntervalAsExpected(string intervalsJson,
        string newIntervalJson, string expectedResultJson)
    {
        // Arrange
        var intervals = JsonHelper<int[][]>.Parse(intervalsJson);
        var newInterval = JsonHelper.Parse<int[]>(newIntervalJson);
        var expectedResult = JsonHelper<int[][]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.Insert(intervals, newInterval);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}