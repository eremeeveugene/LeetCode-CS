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
        var actualResult = solution.BinaryTreePaths(root);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, 2, 3, null, 5 }, new[] { "1->2->5", "1->3" }];

        yield return [new int?[] { 1 }, new[] { "1" }];

        yield return [new int?[] { 1, 2 }, new[] { "1->2" }];

        yield return [new int?[] { 1, null, 2 }, new[] { "1->2" }];

        yield return [new int?[] { 1, 2, 3 }, new[] { "1->2", "1->3" }];

        yield return [new int?[] { 1, 2, null, 3 }, new[] { "1->2->3" }];

        yield return [new int?[] { 1, null, 2, null, 3 }, new[] { "1->2->3" }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { "1->2->4", "1->2->5", "1->3->6", "1->3->7" }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 5 }, new[] { "1->2->4", "1->3->5" }];

        yield return [new int?[] { -1, -2, -3 }, new[] { "-1->-2", "-1->-3" }];

        yield return [new int?[] { 0, 1, null, 2, null, 3 }, new[] { "0->1->2->3" }];

        yield return [new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 }, new[] { "5->4->11->7", "5->4->11->2", "5->8->13", "5->8->4->5", "5->8->4->1" }];

        yield return [new int?[] { 10, 5, 15, null, null, 6, 20 }, new[] { "10->5", "10->15->6", "10->15->20" }];

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, new[] { "3->9", "3->20->15", "3->20->7" }];

        yield return [new int?[] { -100, 100, -100 }, new[] { "-100->100", "-100->-100" }];

        yield return [new int?[] { 1, 2, 3, null, 4, 5 }, new[] { "1->2->4", "1->3->5" }];

        yield return [new int?[] { 1, null, 2, 3, 4 }, new[] { "1->2->3", "1->2->4" }];

        yield return [new int?[] { 2, 1, 3, null, null, null, 4 }, new[] { "2->1", "2->3->4" }];

        yield return [new int?[] { 1, 2, 3, 4, 5, null, 6, 7, 8 }, new[] { "1->2->4->7", "1->2->4->8", "1->2->5", "1->3->6" }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { "1->2->4->8", "1->2->4->9", "1->2->5", "1->3->6", "1->3->7" }];
    }
}