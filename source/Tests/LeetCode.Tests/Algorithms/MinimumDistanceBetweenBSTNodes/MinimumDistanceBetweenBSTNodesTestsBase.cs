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

using LeetCode.Algorithms.MinimumDistanceBetweenBSTNodes;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MinimumDistanceBetweenBSTNodes;

public abstract class MinimumDistanceBetweenBSTNodesTestsBase<T> where T : IMinimumDistanceBetweenBSTNodes, new()
{
    [TestMethod]
    [DataRow("[4,2,6,1,3]", 1)]
    [DataRow("[1,0,48,null,null,12,49]", 1)]
    [DataRow("[90,69,null,49,89,null,52]", 1)]
    public void MinDiffInBST_WithVariousBSTs_ReturnsMinimumDifference(string rootJsonArray, int expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray) ?? throw new InvalidOperationException();

        var solution = new T();

        // Act
        var actualResult = solution.MinDiffInBST(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}