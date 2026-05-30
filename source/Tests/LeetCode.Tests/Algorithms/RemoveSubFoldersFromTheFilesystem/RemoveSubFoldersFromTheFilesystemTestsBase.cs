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

using LeetCode.Algorithms.RemoveSubFoldersFromTheFilesystem;

namespace LeetCode.Tests.Algorithms.RemoveSubFoldersFromTheFilesystem;

public abstract class RemoveSubFoldersFromTheFilesystemTestsBase<T> where T : IRemoveSubFoldersFromTheFilesystem, new()
{
    [TestMethod]
    [DataRow(new[] { "/a", "/a/b", "/c/d", "/c/d/e", "/c/f" }, new[] { "/a", "/c/d", "/c/f" })]
    [DataRow(new[] { "/a", "/a/b", "/a/b/c", "/c/d", "/c/d/e", "/c/f" }, new[] { "/a", "/c/d", "/c/f" })]
    [DataRow(new[] { "/a", "/a/b/c", "/a/b/d" }, new[] { "/a" })]
    [DataRow(new[] { "/a/b/c", "/a/b/ca", "/a/b/d" }, new[] { "/a/b/c", "/a/b/ca", "/a/b/d" })]
    public void RemoveSubfolders_WithFolderList_ReturnsFoldersExcludingSubfolders(string[] folder,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveSubfolders(folder).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}