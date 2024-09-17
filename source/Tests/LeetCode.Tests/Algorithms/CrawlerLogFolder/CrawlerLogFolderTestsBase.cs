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

using LeetCode.Algorithms.CrawlerLogFolder;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CrawlerLogFolder;

public abstract class CrawlerLogFolderTestsBase<T> where T : ICrawlerLogFolder, new()
{
    [TestMethod]
    [DataRow("[\"d1/\", \"../\", \"../\", \"../\"]", 0)]
    [DataRow("[\"d1/\", \"d2/\", \"../\", \"d21/\", \"./\"]", 2)]
    [DataRow("[\"d1/\", \"d2/\", \"./\", \"d3/\", \"../\", \"d31/\"]", 3)]
    public void MinOperations_GivenLogsArray_ReturnsMinOperationsCount(string logsJsonArray, int expectedResult)
    {
        // Arrange
        var logs = JsonHelper<string>.DeserializeToArray(logsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(logs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}