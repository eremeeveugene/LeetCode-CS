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

using LeetCode.Algorithms.KthLargestSumInBinaryTree;
using LeetCode.Core.Exceptions;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.KthLargestSumInBinaryTree;

public abstract class KthLargestSumInBinaryTreeTestsBase<T> where T : IKthLargestSumInBinaryTree, new()
{
    [TestMethod]
    [DataRow("[5,8,9,2,1,3,7,4,6]", 2, 13)]
    [DataRow("[1,2,null,3]", 1, 3)]
    public void KthLargestLevelSum_GivenTreeNodeArrayAndK_ReturnsCorrectLevelSum(string rootJsonArray, int k,
        long expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.DeserializeToArray(rootJsonArray);
        var root = TreeNode.ToTreeNode(rootArray) ?? throw new TreeNodeBuildException();

        var solution = new T();

        // Act
        var actualResult = solution.KthLargestLevelSum(root, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}