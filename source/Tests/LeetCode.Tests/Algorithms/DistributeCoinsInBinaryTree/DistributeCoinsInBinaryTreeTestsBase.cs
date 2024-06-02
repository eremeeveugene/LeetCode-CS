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

using LeetCode.Algorithms.DistributeCoinsInBinaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.DistributeCoinsInBinaryTree;

public abstract class DistributeCoinsInBinaryTreeTestsBase<T> where T : IDistributeCoinsInBinaryTree, new()
{
    [TestMethod]
    [DataRow("[]", 0)]
    [DataRow("[1]", 0)]
    [DataRow(
        "[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1]",
        0)]
    [DataRow("[3,0,0]", 2)]
    [DataRow("[0,3,0]", 3)]
    [DataRow(
        "[2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,2,0,0]",
        100)]
    [DataRow(
        "[0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,100]",
        930)]
    public void DistributeCoins_GivenTreeNodeJsonArray_ReturnsExpectedCoinDistribution(string rootJsonArray,
        int expectedResult)
    {
        // Arrange
        IList<int?> rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.DistributeCoins(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}