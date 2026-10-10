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
    [DataRow(new[] { "/a" }, new[] { "/a" })]
    [DataRow(new[] { "/a", "/b" }, new[] { "/a", "/b" })]
    [DataRow(new[] { "/a/b", "/a" }, new[] { "/a" })]
    [DataRow(new[] { "/a", "/ab" }, new[] { "/a", "/ab" })]
    [DataRow(new[] { "/a/b/c", "/a/b", "/a" }, new[] { "/a" })]
    [DataRow(new[] { "/a", "/a/b/c/d/e/f" }, new[] { "/a" })]
    [DataRow(new[] { "/a/b", "/a/c", "/a/d" }, new[] { "/a/b", "/a/c", "/a/d" })]
    [DataRow(new[] { "/ab", "/a", "/abc", "/ab/c" }, new[] { "/ab", "/a", "/abc" })]
    [DataRow(new[] { "/z/y/x", "/z/y", "/z/yx", "/z/y/xw" }, new[] { "/z/y", "/z/yx" })]
    [DataRow(new[] { "/a/b/c", "/a/b/c/d", "/a/b/c/d/e" }, new[] { "/a/b/c" })]
    [DataRow(new[] { "/x", "/y", "/z", "/x/y", "/y/z", "/z/x" }, new[] { "/x", "/y", "/z" })]
    [DataRow(new[] { "/leet/code", "/leet", "/leetcode", "/leet/code/a" }, new[] { "/leet", "/leetcode" })]
    [DataRow(new[] { "/a/a", "/a/a/a", "/a/aa", "/a/aa/a", "/aa" }, new[] { "/a/a", "/a/aa", "/aa" })]
    [DataRow(new[] { "/p/q", "/p/q/r", "/p/qr", "/p/q/rs", "/p/s" }, new[] { "/p/q", "/p/qr", "/p/s" })]
    [DataRow(new[] { "/a/b/c/d", "/a/b/e", "/a/b", "/f/g", "/f/g/h", "/f" }, new[] { "/a/b", "/f" })]
    [DataRow(new[] { "/m", "/n/o", "/n/o/p", "/n/q", "/n" }, new[] { "/m", "/n" })]
    public void RemoveSubfolders_WithFolderList_ReturnsFoldersExcludingSubfolders(string[] folder, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var result = solution.RemoveSubfolders(folder);
        var actualResult = new string[result.Count];
        result.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}