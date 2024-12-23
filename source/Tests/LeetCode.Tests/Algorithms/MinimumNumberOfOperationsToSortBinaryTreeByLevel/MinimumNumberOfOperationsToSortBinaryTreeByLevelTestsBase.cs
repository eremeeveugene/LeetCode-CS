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

using LeetCode.Algorithms.MinimumNumberOfOperationsToSortBinaryTreeByLevel;
using LeetCode.Core.Exceptions;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfOperationsToSortBinaryTreeByLevel;

public abstract class MinimumNumberOfOperationsToSortBinaryTreeByLevelTestsBase<T>
    where T : IMinimumNumberOfOperationsToSortBinaryTreeByLevel, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,5,6]", 0)]
    [DataRow("[1,3,2,7,6,5,4]", 3)]
    [DataRow("[1,4,3,7,6,8,5,null,null,null,null,9,null,10]", 3)]
    public void MinimumOperations_WithBinaryTreeInput_ReturnsMinOperationsToSortLevelOrders(string rootJsonArray,
        int expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.DeserializeToArray(rootJsonArray);
        var root = TreeNode.ToTreeNode(rootArray) ?? throw new TreeNodeBuildException();

        var solution = new T();

        // Act
        var actualResult = solution.MinimumOperations(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}