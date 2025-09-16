// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.HeightOfBinaryTreeAfterSubtreeRemovalQueries;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.HeightOfBinaryTreeAfterSubtreeRemovalQueries;

public abstract class HeightOfBinaryTreeAfterSubtreeRemovalQueriesTestsBase<T>
    where T : IHeightOfBinaryTreeAfterSubtreeRemovalQueries, new()
{
    [TestMethod]
    [DataRow("[1,3,4,2,null,6,5,null,null,null,null,null,7]", "[4]", "[2]")]
    [DataRow("[5,8,9,2,1,3,7,4,6]", "[3,2,4,8]", "[3,2,3,2]")]
    [DataRow("[1,null,5,3,null,2,4]", "[3,5,4,2,4]", "[1,0,3,3,3]")]
    public void TreeQueries_WithSubtreeRemovedAtGivenNode_ReturnsHeightOfTreeAfterRemoval(string rootJson,
        string queriesJson, string expectedResultJson)
    {
        // Arrange
        var rootArray = JsonHelper<int?[]>.Parse(rootJson);
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);
        var queries = JsonHelper<int[]>.Parse(queriesJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.TreeQueries(root, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}