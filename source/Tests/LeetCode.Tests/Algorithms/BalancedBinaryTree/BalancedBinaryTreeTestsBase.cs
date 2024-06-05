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

using LeetCode.Algorithms.BalancedBinaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BalancedBinaryTree;

public abstract class BalancedBinaryTreeTestsBase<T> where T : IBalancedBinaryTree, new()
{
    [TestMethod]
    [DataRow("[]", true)]
    [DataRow("[1]", true)]
    [DataRow("[3,9,20,null,null,15,7]", true)]
    [DataRow("[1,2,2,3,3,null,null,4,4]", false)]
    [DataRow("[1,2,2,3,null,null,3,4,null,null,4]", false)]
    [DataRow("[1,2,2,null,null,3,3,4,4]", false)]
    [DataRow("[1,2,2,3,3,3,3]", true)]
    public void IsBalanced_TreeWithJsonInput_ReturnsExpectedBalancedStatus(string rootJsonArray, bool expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.IsBalanced(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}