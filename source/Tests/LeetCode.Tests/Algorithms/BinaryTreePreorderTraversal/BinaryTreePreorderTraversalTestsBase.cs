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

using LeetCode.Algorithms.BinaryTreePreorderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreePreorderTraversal;

public abstract class BinaryTreePreorderTraversalTestsBase<T> where T : IBinaryTreePreorderTraversal, new()
{
    [TestMethod]
    [DataRow("[]", "[]")]
    [DataRow("[1]", "[1]")]
    [DataRow("[1,null,2,3]", "[1,2,3]")]
    [DataRow("[1,2,3,4,5,6,7,8,9]", "[1,2,4,8,9,5,3,6,7]")]
    public void PreorderTraversal_WithVariousTreeStructures_ReturnsExpectedTraversal(string rootArrayJson,
        string expectedResultArrayJson)
    {
        // Arrange
        var solution = new T();

        IList<int?> expectedResult = JsonConvertHelper<int?>.JsonArrayToList(expectedResultArrayJson);
        IList<int?> rootArray = JsonConvertHelper<int?>.JsonArrayToList(rootArrayJson);
        var inputNode = TreeNode.BuildTree(rootArray);

        // Act
        var actualResult = solution.PreorderTraversal(inputNode);

        // Assert
        Assert.IsNotNull(actualResult);
        CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
    }
}