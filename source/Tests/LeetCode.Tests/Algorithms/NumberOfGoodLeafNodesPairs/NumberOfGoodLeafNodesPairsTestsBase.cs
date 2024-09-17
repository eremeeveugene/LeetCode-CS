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

using LeetCode.Algorithms.NumberOfGoodLeafNodesPairs;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.NumberOfGoodLeafNodesPairs;

public abstract class NumberOfGoodLeafNodesPairsTestsBase<T> where T : INumberOfGoodLeafNodesPairs, new()
{
    [TestMethod]
    [DataRow("[1,2,3,null,4]", 3, 1)]
    [DataRow("[1,2,3,4,5,6,7]", 3, 2)]
    [DataRow("[7,1,4,6,null,5,3,null,null,null,null,null,2]", 3, 1)]
    public void CountPairs_WithTreeAndDistance_ReturnsCorrectNumberOfGoodLeafNodePairs(string rootJsonArray,
        int distance, int expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.DeserializeToArray(rootJsonArray);
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.CountPairs(root, distance);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}