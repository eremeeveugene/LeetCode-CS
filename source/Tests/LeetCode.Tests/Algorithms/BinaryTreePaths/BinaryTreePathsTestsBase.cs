﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.BinaryTreePaths;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreePaths;

public abstract class BinaryTreePathsTestsBase<T> where T : IBinaryTreePaths, new()
{
    [TestMethod]
    [DataRow("[1,2,3,null,5]", "[\"1->2->5\", \"1->3\"]")]
    [DataRow("[1]", "[\"1\"]")]
    public void BinaryTreePaths_GivenTreeInJson_ReturnsAllRootToLeafPaths(string jsonRootArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var expectedResult = JsonHelper<string>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        var rootArray = JsonHelper<int?>.DeserializeToArray(jsonRootArray);
        var root = TreeNode.ToTreeNode(rootArray);

        // Act
        var actualResult = solution.BinaryTreePaths(root);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}