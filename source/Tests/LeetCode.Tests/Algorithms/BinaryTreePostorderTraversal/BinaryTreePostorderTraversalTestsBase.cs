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

using LeetCode.Algorithms.BinaryTreePostorderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreePostorderTraversal;

public abstract class BinaryTreePostorderTraversalTestsBase<T> where T : IBinaryTreePostorderTraversal, new()
{
    [TestMethod]
    [DataRow("[1,null,2,3]", "[3,2,1]")]
    [DataRow("[]", "[]")]
    [DataRow("[1]", "[1]")]
    public void PostorderTraversal_WithTreeNodes_ReturnsCorrectPostorderTraversal(string rootJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonHelper<int?>.DeserializeToList(expectedResultJsonArray);
        var rootArray = JsonHelper<int?>.DeserializeToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        // Act
        var actualResult = solution.PostorderTraversal(root);

        // Assert
        Assert.IsNotNull(actualResult);
        CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
    }
}