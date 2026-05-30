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

using LeetCode.Algorithms.LinkedListInBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.LinkedListInBinaryTree;

public abstract class LinkedListInBinaryTreeTestsBase<T> where T : ILinkedListInBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsSubPath_WithLinkedListAndBinaryTree_ReturnsIfLinkedListIsSubPath(int[] headArray, int?[] rootArray, bool expectedResult)
    {
        // Arrange
        var head = ListNode.ToListNodeOrThrow(headArray);
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.IsSubPath(head, root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1 }, new int?[] { 1 }, true];

        yield return [new[] { 4, 2, 8 }, new int?[] { 1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3 }, true];

        yield return [new[] { 1, 4, 2, 6 }, new int?[] { 1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3 }, true];

        yield return [new[] { 1, 4, 2, 6, 8 }, new int?[] { 1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3 }, false];

        yield return [new[] { 1, 10 }, new int?[] { 1, null, 1, 10, 1, 9 }, true];

        yield return [new[] { 2, 2, 1 }, new int?[] { 2, null, 2, null, 2, null, 1 }, true];
    }
}