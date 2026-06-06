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

using LeetCode.Algorithms.CreateBinaryTreeFromDescriptions;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.CreateBinaryTreeFromDescriptions;

public abstract class CreateBinaryTreeFromDescriptionsTestsBase<T> where T : ICreateBinaryTreeFromDescriptions, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CreateBinaryTree_WithDescriptions_ReturnsBinaryTreeConstructedFromDescriptions(int[][] descriptions, int?[] expectedResultArray)
    {
        // Arrange
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.CreateBinaryTree(descriptions);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 20, 15, 1 }, new[] { 20, 17, 0 }, new[] { 50, 20, 1 }, new[] { 50, 80, 0 }, new[] { 80, 19, 1 } }, new int?[] { 50, 20, 80, 15, 17, 19 }];

        yield return [new[] { new[] { 1, 2, 1 }, new[] { 2, 3, 0 }, new[] { 3, 4, 1 } }, new int?[] { 1, 2, null, null, 3, 4 }];

        // Empty descriptions yields null tree, exercising the fallback return path.
        yield return [new int[0][], new int?[0]];
    }
}