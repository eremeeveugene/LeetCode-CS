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

using LeetCode.Algorithms.FindModeInBinarySearchTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindModeInBinarySearchTree;

public abstract class FindModeInBinarySearchTreeTestsBase<T> where T : IFindModeInBinarySearchTree, new()
{
    [TestMethod]
    [DataRow("[]", new int[] { })]
    [DataRow("[0]", new[] { 0 })]
    [DataRow("[1,null,2,2]", new[] { 2 })]
    public void FindMode_WithBinaryTree_ReturnsModeValues(string rootArrayJson, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        var rootArray = JsonHelper<int?>.JsonArrayToList(rootArrayJson);
        var root = TreeNode.BuildTree(rootArray);

        // Act
        var actualResult = solution.FindMode(root);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}