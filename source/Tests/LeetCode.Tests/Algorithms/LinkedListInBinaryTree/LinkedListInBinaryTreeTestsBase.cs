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

using LeetCode.Algorithms.LinkedListInBinaryTree;
using LeetCode.Core.Exceptions;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.LinkedListInBinaryTree;

public abstract class LinkedListInBinaryTreeTestsBase<T> where T : ILinkedListInBinaryTree, new()
{
    [TestMethod]
    [DataRow("[1]", "[1]", true)]
    [DataRow("[4,2,8]", "[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]", true)]
    [DataRow("[1,4,2,6]", "[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]", true)]
    [DataRow("[1,4,2,6,8]", "[1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]", false)]
    [DataRow("[1,10]", "[1,null,1,10,1,9]", true)]
    [DataRow("[2,2,1]", "[2,null,2,null,2,null,1]", true)]
    public void IsSubPath_WithLinkedListAndBinaryTree_ReturnsIfLinkedListIsSubPath(string headJsonArray,
        string rootJsonArray, bool expectedResult)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray) ?? throw new ListNodeBuildException();
        var rootArray = JsonHelper<int?>.DeserializeToArray(rootJsonArray);
        var root = TreeNode.ToTreeNode(rootArray) ?? throw new TreeNodeBuildException();

        var solution = new T();

        // Act
        var actualResult = solution.IsSubPath(head, root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}