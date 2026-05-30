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

using LeetCode.Algorithms.BinaryTreePaths;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreePaths;

public abstract class BinaryTreePathsTestsBase<T> where T : IBinaryTreePaths, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void BinaryTreePaths_GivenTreeInJson_ReturnsAllRootToLeafPaths(int?[] rootArray, string[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.BinaryTreePaths(root).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, 2, 3, null, 5 }, new[] { "1->2->5", "1->3" }];

        yield return [new int?[] { 1 }, new[] { "1" }];
    }
}