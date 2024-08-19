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

using LeetCode.Algorithms.BinaryTreeInorderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreeInorderTraversal;

public abstract class BinaryTreeInorderTraversalTestsBase<T> where T : IBinaryTreeInorderTraversal, new()
{
    [TestMethod]
    [DataRow("[1,null,2,3]", "[1,3,2]")]
    [DataRow("[1]", "[1]")]
    [DataRow("[]", "[0]")]
    public void InorderTraversal_WithBinaryTreeFromJson_ReturnsInorderTraversalList(string inputJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonHelper<int?>.DeserializeToList(expectedResultJsonArray);
        var inputArray = JsonHelper<int?>.DeserializeToList(inputJsonArray);
        var inputNode = TreeNode.BuildTree(inputArray);

        // Act
        var actualResult = solution.InorderTraversal(inputNode);

        // Assert
        Assert.IsNotNull(actualResult);
        CollectionAssert.AreEqual(expectedResult.ToList(), actualResult.ToList());
    }
}