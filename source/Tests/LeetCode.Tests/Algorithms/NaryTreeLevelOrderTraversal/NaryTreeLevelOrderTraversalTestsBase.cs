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

using LeetCode.Algorithms.NaryTreeLevelOrderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.NaryTreeLevelOrderTraversal;

public abstract class NaryTreeLevelOrderTraversalTestsBase<T> where T : INaryTreeLevelOrderTraversal, new()
{
    [TestMethod]
    [DataRow("[1,null,3,2,4,null,5,6]", "[[1],[3,2,4],[5,6]]")]
    [DataRow("[1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]",
        "[[1],[2,3,4,5],[6,7,8,9,10],[11,12,13],[14]]")]
    public void LevelOrder_WithGivenBinaryTree_ReturnsCorrectLevelOrderTraversal(string rootArrayJson,
        string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonConvertHelper<int>.JsonArrayToJaggedList(expectedResultJsonArray);
        var rootArray = JsonConvertHelper<int?>.JsonArrayToList(rootArrayJson);

        var root = Node.BuildTree(rootArray);

        // Act
        var actualResult = solution.LevelOrder(root);

        // Assert
        AssertExtensions.AssertJaggedArrayEqual(expectedResult, actualResult);
    }
}