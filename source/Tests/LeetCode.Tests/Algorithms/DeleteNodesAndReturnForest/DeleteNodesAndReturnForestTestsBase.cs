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

using LeetCode.Algorithms.DeleteNodesAndReturnForest;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteNodesAndReturnForest;

public abstract class DeleteNodesAndReturnForestTestsBase<T> where T : IDeleteNodesAndReturnForest, new()
{
    [TestMethod]
    [DataRow("[]", new[] { 1 }, "[]")]
    [DataRow("[1]", new[] { 1 }, "[]")]
    [DataRow("[1,2,4,null,3]", new[] { 3 }, "[[1,2,4]]")]
    [DataRow("[1,2,3,4,5]", new[] { 1 }, "[[2,4,5],[3]]")]
    [DataRow("[1,2,3,4,5,6,7]", new[] { 3, 5 }, "[[6],[7],[1,2,null,4]]")]
    [DataRow("[1,2,3,4,5,6,7]", new[] { 1, 2, 3, 4, 5, 6, 7 }, "[]")]
    [DataRow("[1,2,3,4,5,6,7,8,9,10,11,12,13,14,15]", new[] { 3, 5, 7, 8, 9, 14 },
        "[[6,12,13],[15],[10],[11],[1,2,null,4]]")]
    [DataRow("[1,2,3,4,5,6,7,8,null,null,9,10,11,null,12]", new[] { 2, 6, 8, 9, 11 },
        "[[4],[5],[10],[1,null,3,null,7,null,12]]")]
    public void DelNodes_WithGivenNodesToDelete_ModifiesTreeCorrectly(string rootJsonArray, int[] to_delete,
        string expectedResultJsonArray)
    {
        // Arrange
        var rootArray = JsonHelper<int?>.JsonArrayToList(rootJsonArray);
        var root = TreeNode.BuildTree(rootArray);

        var expectedResultArray = JsonHelper<List<int?>>.JsonArrayToList(expectedResultJsonArray);
        var expectedResult = expectedResultArray.Select(TreeNode.BuildTree!).ToList();

        var solution = new T();

        // Act
        var actualResult = solution.DelNodes(root, to_delete);

        // Assert
        TreeNodeAssert.AreEquivalent(expectedResult, actualResult);
    }
}