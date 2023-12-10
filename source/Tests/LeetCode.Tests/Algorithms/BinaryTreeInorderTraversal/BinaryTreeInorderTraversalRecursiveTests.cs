// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.BinaryTreeInorderTraversal;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreeInorderTraversal;

[TestClass]
public class BinaryTreeInorderTraversalRecursiveTests
{
    [TestMethod]
    [DataRow("[1,null,2,3]", "[1,3,2]")]
    [DataRow("[1]", "[1]")]
    [DataRow(JsonHelper.EmptyArray, "[0]")]
    public void BinaryTreeInorderTraversalRecursive_GetResult_ReturnsCorrectSequenceFromBinaryTree(
        string inputArrayJson,
        string expectedArrayJson)
    {
        // Arrange
        IList<int?> expectedResult = JsonConvertHelper<int?>.JsonArrayToList(expectedArrayJson);
        IList<int?> inputArray = JsonConvertHelper<int?>.JsonArrayToList(inputArrayJson);
        TreeNode inputNode = TreeNode.BuildTree(inputArray);

        // Act
        IList<int> actualResult = BinaryTreeInorderTraversalRecursive.GetResult(inputNode);

        // Assert
        Assert.IsNotNull(actualResult);
        CollectionAssert.AreEqual(expectedResult.ToList(), actualResult.ToList());
    }
}