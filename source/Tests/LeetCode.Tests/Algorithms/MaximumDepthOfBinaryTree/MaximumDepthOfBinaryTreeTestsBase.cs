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

using LeetCode.Algorithms.MaximumDepthOfBinaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MaximumDepthOfBinaryTree;

public abstract class MaximumDepthOfBinaryTreeTestsBase<T> where T : IMaximumDepthOfBinaryTree, new()
{
    [TestMethod]
    [DataRow("[]", 0)]
    [DataRow("[3,9,20,null,null,15,7]", 3)]
    [DataRow("[1,null,2]", 2)]
    public void MaxDepth_GivenTreeWithDifferentConfigurations_ReturnsExpectedDepth(string rootJsonArray,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        var rootArray = JsonHelper<int?>.DeserializeToArray(rootJsonArray);
        var root = TreeNode.ToTreeNode(rootArray);

        // Act
        var actualResult = solution.MaxDepth(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}