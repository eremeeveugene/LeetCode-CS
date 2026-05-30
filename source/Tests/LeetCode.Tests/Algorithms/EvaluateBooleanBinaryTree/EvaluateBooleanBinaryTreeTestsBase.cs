// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.EvaluateBooleanBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.EvaluateBooleanBinaryTree;

public abstract class EvaluateBooleanBinaryTreeTestsBase<T> where T : IEvaluateBooleanBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void EvaluateTree_GivenJsonTreeStructure_ReturnsBooleanEvaluationResult(int?[] rootArray, bool expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.EvaluateTree(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 0 }, false];

        yield return [new int?[] { 2, 3, 3, 1, 1, 0, 1 }, true];

        yield return [new int?[] { 2, 1, 3, null, null, 0, 1 }, true];

        yield return [new int?[] { 2, 0, 2, null, null, 0, 1 }, true];

        yield return [new int?[] { 2, 1, 3, null, null, 1, 0 }, true];

        yield return [new int?[] { 2, 3, 1, 1, 2, null, null, null, null, 0, 1 }, true];

        yield return [new int?[] { 3, 3, 2, 0, 1, 0, 0 }, false];

        yield return [new int?[] { 3, 3, 2, 2, 3, 3, 3, 0, 1, 0, 0, 1, 0, 0, 0 }, false];
    }
}