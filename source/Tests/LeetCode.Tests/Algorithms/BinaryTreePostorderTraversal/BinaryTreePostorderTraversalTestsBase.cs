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

using LeetCode.Algorithms.BinaryTreePostorderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreePostorderTraversal;

public abstract class BinaryTreePostorderTraversalTestsBase<T> where T : IBinaryTreePostorderTraversal, new()
{
    [TestMethod]
    [DataRow("[1,null,2,3]", "[3,2,1]")]
    [DataRow("[]", "[]")]
    [DataRow("[1]", "[1]")]
    public void PostorderTraversal_WithTreeNodes_ReturnsCorrectPostorderTraversal(string rootArrayJson,
        string expectedResultArrayJson)
    {
        // Arrange
        var solution = new T();

        IList<int?> expectedResult = JsonConvertHelper<int?>.JsonArrayToList(expectedResultArrayJson);
        IList<int?> rootArray = JsonConvertHelper<int?>.JsonArrayToList(rootArrayJson);
        var root = TreeNode.BuildTree(rootArray);

        // Act
        var actualResult = solution.PostorderTraversal(root);

        // Assert
        Assert.IsNotNull(actualResult);
        CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
    }
}