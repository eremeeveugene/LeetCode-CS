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

using LeetCode.Algorithms.NaryTreePostorderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.NaryTreePostorderTraversal;

public abstract class NaryTreePostorderTraversalTestsBase<T> where T : INaryTreePostorderTraversal, new()
{
    [TestMethod]
    [DataRow("[1,null,3,2,4,null,5,6]", "[5,6,3,2,4,1]")]
    [DataRow("[1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]",
        "[2,6,14,11,7,3,12,8,4,13,9,10,5,1]")]
    public void Postorder_GivenBinaryTree_ReturnsCorrectTraversal(string rootArrayJson, string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonConvertHelper<int>.JsonArrayToList(expectedResultJsonArray);
        var rootArray = JsonConvertHelper<int?>.JsonArrayToList(rootArrayJson);

        var root = Node.BuildTree(rootArray);

        // Act
        var actualResult = solution.Postorder(root);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}