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

using LeetCode.Algorithms.RootEqualsSumOfChildren;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.RootEqualsSumOfChildren;

public abstract class RootEqualsSumOfChildrenTestsBase<T> where T : IRootEqualsSumOfChildren, new()
{
    [TestMethod]
    [DataRow("[10,4,6]", true)]
    [DataRow("[5,3,1]", false)]
    public void CheckTree_WithThreeNodeTree_ReturnsIfRootValueEqualsSumOfChildren(string rootJsonArray,
        bool expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray) ?? throw new InvalidOperationException();

        var solution = new T();

        // Act
        var actualResult = solution.CheckTree(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}