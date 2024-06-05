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

using LeetCode.Algorithms.CountCompleteTreeNodes;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.CountCompleteTreeNodes;

public abstract class CountCompleteTreeNodesTestsBase<T> where T : ICountCompleteTreeNodes, new()
{
    [TestMethod]
    [DataRow("[]", 0)]
    [DataRow("[1]", 1)]
    [DataRow("[1,2,3,4]", 4)]
    [DataRow("[1,2,3,4,5,6]", 6)]
    public void CountNodes_GivenJsonArrayOfTreeNodes_ReturnsCorrectNodeCount(string rootJsonArray, int expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.CountNodes(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}