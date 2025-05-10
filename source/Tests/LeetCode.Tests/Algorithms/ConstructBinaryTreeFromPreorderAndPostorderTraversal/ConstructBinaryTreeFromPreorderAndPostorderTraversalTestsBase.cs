// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ConstructBinaryTreeFromPreorderAndPostorderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ConstructBinaryTreeFromPreorderAndPostorderTraversal;

public abstract class ConstructBinaryTreeFromPreorderAndPostorderTraversalTestsBase<T>
    where T : IConstructBinaryTreeFromPreorderAndPostorderTraversal, new()
{
    [TestMethod]
    [DataRow("[1]", "[1]", "[1]")]
    [DataRow("[1,2,4,5,3,6,7]", "[4,5,2,6,7,3,1]", "[1,2,3,4,5,6,7]")]
    public void ConstructFromPrePost_WithPreorderAndPostorder_ReturnsBinaryTree(string preorderJson,
        string postorderJson, string expectedResultJson)
    {
        // Arrange
        var preorder = JsonHelper<int>.DeserializeToArray(preorderJson);
        var postorder = JsonHelper<int>.DeserializeToArray(postorderJson);
        var expectedResultArray = JsonHelper<int?>.DeserializeToArray(expectedResultJson);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ConstructFromPrePost(preorder, postorder);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}