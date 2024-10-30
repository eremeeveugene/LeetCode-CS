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

using LeetCode.Algorithms.RemoveSubFoldersFromTheFilesystem;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RemoveSubFoldersFromTheFilesystem;

public abstract class RemoveSubFoldersFromTheFilesystemTestsBase<T> where T : IRemoveSubFoldersFromTheFilesystem, new()
{
    [TestMethod]
    [DataRow("[\"/a\",\"/a/b\",\"/c/d\",\"/c/d/e\",\"/c/f\"]", "[\"/a\",\"/c/d\",\"/c/f\"]")]
    [DataRow("[\"/a\",\"/a/b\", \"/a/b/c\",\"/c/d\",\"/c/d/e\",\"/c/f\"]", "[\"/a\",\"/c/d\",\"/c/f\"]")]
    [DataRow("[\"/a\",\"/a/b/c\",\"/a/b/d\"]", "[\"/a\"]")]
    [DataRow("[\"/a/b/c\",\"/a/b/ca\",\"/a/b/d\"]", "[\"/a/b/c\",\"/a/b/ca\",\"/a/b/d\"]")]
    public void RemoveSubfolders_WithFolderList_ReturnsFoldersExcludingSubfolders(string folderJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var folder = JsonHelper<string>.DeserializeToArray(folderJsonArray);
        var expectedResult = JsonHelper<string>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveSubfolders(folder);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}