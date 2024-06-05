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

using LeetCode.Algorithms.EvaluateBooleanBinaryTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.EvaluateBooleanBinaryTree;

public abstract class EvaluateBooleanBinaryTreeTestsBase<T> where T : IEvaluateBooleanBinaryTree, new()
{
    [TestMethod]
    [DataRow("[0]", false)]
    [DataRow("[2,3,3,1,1,0,1]", true)]
    [DataRow("[2,1,3,null,null,0,1]", true)]
    [DataRow("[2,0,2,null,null,0,1]", true)]
    [DataRow("[2,1,3,null,null,1,0]", true)]
    [DataRow("[2,3,1,1,2,null,null,null,null,0,1]", true)]
    [DataRow("[3,3,2,0,1,0,0]", false)]
    [DataRow("[3,3,2,2,3,3,3,0,1,0,0,1,0,0,0]", false)]
    public void EvaluateTree_GivenJsonArrayTreeStructure_ReturnsBooleanEvaluationResult(string rootJsonArray,
        bool expectedResult)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.EvaluateTree(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}