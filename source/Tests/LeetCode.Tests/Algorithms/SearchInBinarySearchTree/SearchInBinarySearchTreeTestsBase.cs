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

using LeetCode.Algorithms.SearchInBinarySearchTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SearchInBinarySearchTree;

public abstract class SearchInBinarySearchTreeTestsBase<T> where T : ISearchInBinarySearchTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SearchBST_WithGivenRootAndValue_ReturnsSubtree(int?[] rootArray, int val,
        int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.SearchBST(root, val);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 4, 2, 7, 1, 3 }, 2, new int?[] { 2, 1, 3 }];

        yield return [new int?[] { 4, 2, 7, 1, 3 }, 5, Array.Empty<int?>()];
    }
}