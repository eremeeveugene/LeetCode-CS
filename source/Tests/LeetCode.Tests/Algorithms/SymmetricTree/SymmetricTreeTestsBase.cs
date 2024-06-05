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

using LeetCode.Algorithms.SymmetricTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SymmetricTree;

public abstract class SymmetricTreeTestsBase<T> where T : ISymmetricTree, new()
{
    [TestMethod]
    [DataRow("[]", true)]
    [DataRow("[1,2,2,3,4,4,3]", true)]
    [DataRow("[1,2,2,null,3,null,3]", false)]
    public void IsSymmetric_GivenBinaryTreeAsJsonArray_ReturnsExpectedSymmetryOutcome(string jsonArrayRoot,
        bool expectedResult)
    {
        // Arrange
        var arrayRoot = JsonHelper<int?>.JsonArrayToList(jsonArrayRoot);
        var root = TreeNode.BuildTree(arrayRoot);

        var solution = new T();

        // Act
        var actualResult = solution.IsSymmetric(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}