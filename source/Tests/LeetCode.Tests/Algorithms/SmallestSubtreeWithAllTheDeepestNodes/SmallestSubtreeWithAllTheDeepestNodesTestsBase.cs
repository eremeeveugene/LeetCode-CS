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

using LeetCode.Algorithms.SmallestSubtreeWithAllTheDeepestNodes;
using LeetCode.Core.Exceptions;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SmallestSubtreeWithAllTheDeepestNodes;

public abstract class SmallestSubtreeWithAllTheDeepestNodesTestsBase<T>
    where T : ISmallestSubtreeWithAllTheDeepestNodes, new()
{
    [TestMethod]
    [DataRow("[3,5,1,6,2,0,8,null,null,7,4]", "[2,7,4]")]
    [DataRow("[1]", "[1]")]
    [DataRow("[0,1,3,null,2]", "[2]")]
    public void SubtreeWithAllDeepest_WithBinaryTree_ReturnsSmallestSubtreeWithAllTheDeepestNodes(string rootJson,
        string expectedResultJson)
    {
        // Arrange
        var solution = new T();

        var rootArray = JsonHelper<int?[]>.Parse(rootJson);
        var root = TreeNode.ToTreeNode(rootArray) ?? throw new TreeNodeBuildException();
        var expectedResultArray = JsonHelper<int?[]>.Parse(expectedResultJson);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray) ?? throw new TreeNodeBuildException();

        // Act
        var actualResult = solution.SubtreeWithAllDeepest(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}