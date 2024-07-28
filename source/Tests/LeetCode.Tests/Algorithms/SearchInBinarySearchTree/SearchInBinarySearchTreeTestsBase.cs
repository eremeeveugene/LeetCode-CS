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

using LeetCode.Algorithms.SearchInBinarySearchTree;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SearchInBinarySearchTree;

public abstract class SearchInBinarySearchTreeTestsBase<T> where T : ISearchInBinarySearchTree, new()
{
    [TestMethod]
    [DataRow("[4,2,7,1,3]", 2, "[2,1,3]")]
    [DataRow("[4,2,7,1,3]", 5, "[]")]
    public void SearchBST_WithGivenRootAndValue_ReturnsSubtree(string rootJsonArray, int val,
        string expectedResultJsonArray)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        var expectedResultArray = JsonHelper<int?>.JsonArrayToList(expectedResultJsonArray);
        var expectedResult = TreeNode.BuildTree(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.SearchBST(root, val);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}