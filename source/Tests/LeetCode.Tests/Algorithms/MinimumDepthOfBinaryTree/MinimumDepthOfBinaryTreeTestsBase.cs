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

using LeetCode.Algorithms.MinimumDepthOfBinaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MinimumDepthOfBinaryTree;

public abstract class MinimumDepthOfBinaryTreeTestsBase<T> where T : IMinimumDepthOfBinaryTree, new()
{
    [TestMethod]
    [DataRow("[]", 0)]
    [DataRow("[3,9,20,null,null,15,7]", 2)]
    [DataRow("[2,null,3,null,4,null,5,null,6]", 5)]
    public void MinDepth_GivenBinaryTreeAsJsonArray_ReturnsMinimumDepth(string rootJsonArray, int expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.DeserializeToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinDepth(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}