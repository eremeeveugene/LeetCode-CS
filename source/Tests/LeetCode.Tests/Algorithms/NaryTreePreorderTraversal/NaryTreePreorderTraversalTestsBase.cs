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

using LeetCode.Algorithms.NaryTreePreorderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.NaryTreePreorderTraversal;

public abstract class NaryTreePreorderTraversalTestsBase<T> where T : INaryTreePreorderTraversal, new()
{
    [TestMethod]
    [DataRow("[1,null,3,2,4,null,5,6]", "[1,3,5,6,2,4]")]
    [DataRow("[1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]",
        "[1,2,3,6,7,11,14,4,8,12,5,9,13,10]")]
    public void PreorderTraversal_WithVariousTreeStructures_ReturnsCorrectPreorderList(string rootJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonHelper<int>.DeserializeToList(expectedResultJsonArray);
        var rootArray = JsonHelper<int?>.DeserializeToList(rootJsonArray);

        var root = Node.BuildTree(rootArray);

        // Act
        var actualResult = solution.Preorder(root);

        // Assert
        CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
    }
}