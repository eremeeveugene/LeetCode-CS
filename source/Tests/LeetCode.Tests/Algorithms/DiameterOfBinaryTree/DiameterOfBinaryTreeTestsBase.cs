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

using LeetCode.Algorithms.DiameterOfBinaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.DiameterOfBinaryTree;

public abstract class DiameterOfBinaryTreeTestsBase<T> where T : IDiameterOfBinaryTree, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,5]", 3)]
    [DataRow("[1,2]", 1)]
    public void DiameterOfBinaryTree_GivenJsonArrayRepresentation_ReturnsExpectedDiameter(string jsonArrayRoot,
        int expectedResult)
    {
        // Arrange
        IList<int?> arrayRoot = JsonConvertHelper<int?>.JsonArrayToList(jsonArrayRoot);
        var root = TreeNode.BuildTree(arrayRoot);

        var solution = new T();

        // Act
        var actualResult = solution.DiameterOfBinaryTree(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}