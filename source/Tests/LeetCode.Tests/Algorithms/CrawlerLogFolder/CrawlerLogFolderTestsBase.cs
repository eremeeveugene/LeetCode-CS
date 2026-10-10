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

using LeetCode.Algorithms.CrawlerLogFolder;

namespace LeetCode.Tests.Algorithms.CrawlerLogFolder;

public abstract class CrawlerLogFolderTestsBase<T> where T : ICrawlerLogFolder, new()
{
    [TestMethod]
    [DataRow(new[] { "d1/", "../", "../", "../" }, 0)]
    [DataRow(new[] { "d1/", "d2/", "../", "d21/", "./" }, 2)]
    [DataRow(new[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }, 3)]
    [DataRow(new[] { "./" }, 0)]
    [DataRow(new[] { "../" }, 0)]
    [DataRow(new[] { "d1/" }, 1)]
    [DataRow(new[] { "d1/", "../" }, 0)]
    [DataRow(new[] { "../", "d1/" }, 1)]
    [DataRow(new[] { "./", "./", "./" }, 0)]
    [DataRow(new[] { "d1/", "d2/", "d3/" }, 3)]
    [DataRow(new[] { "d1/", "d2/", "../", "../", "../" }, 0)]
    [DataRow(new[] { "d1/", "../", "d2/", "../", "d3/" }, 1)]
    [DataRow(new[] { "a/", "./", "../", "./", "b/" }, 1)]
    [DataRow(new[] { "x1/", "y2/", "z3/", "../", "./", "w/" }, 3)]
    [DataRow(new[] { "../", "../", "a/", "b/", "../" }, 1)]
    [DataRow(new[] { "abc/", "def/", "ghi/", "jkl/", "../", "../" }, 2)]
    [DataRow(new[] { "d/", "../", "../", "../", "e/" }, 1)]
    [DataRow(new[] { "a/", "b/", "c/", "d/", "e/", "f/", "../", "../", "../" }, 3)]
    [DataRow(new[] { "./", "a/", "./", "b/", "./", "../" }, 1)]
    [DataRow(new[] { "d1/", "d2/", "../", "../", "./" }, 0)]
    [DataRow(new[] { "a/", "b/", "../", "c/", "../", "../", "../" }, 0)]
    public void MinOperations_GivenLogsArray_ReturnsMinOperationsCount(string[] logs, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(logs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}