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

using LeetCode.Algorithms.InvertBinaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.InvertBinaryTree;

public abstract class InvertBinaryTreeTestsBase<T> where T : IInvertBinaryTree, new()
{
    [TestMethod]
    [DataRow("[]", "[]")]
    [DataRow("[1]", "[1]")]
    [DataRow("[1,2]", "[1,null,2]")]
    [DataRow("[1,null,2]", "[1,2]")]
    [DataRow("[4,2,7,1,3,6,9]", "[4,7,2,9,6,3,1]")]
    [DataRow("[4,2,7,1,3,null,9]", "[4,7,2,9,null,3,1]")]
    [DataRow("[4,2,7,1,3,6]", "[4,7,2,null,6,3,1]")]
    public void InvertTree_GivenBinaryTree_ReturnsInvertedTree(string rootJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        var expectedResultArray = JsonHelper<int?>.JsonArrayToList(expectedResultJsonArray);
        var expectedResult = TreeNode.BuildTree(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.InvertTree(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}