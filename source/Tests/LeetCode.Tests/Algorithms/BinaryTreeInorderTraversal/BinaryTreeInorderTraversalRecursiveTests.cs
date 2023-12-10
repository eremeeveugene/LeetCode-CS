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
using LeetCode.Core.Models;
using Newtonsoft.Json;

namespace LeetCode.Tests.Algorithms.BinaryTreeInorderTraversal;

[TestClass]
public class BinaryTreeInorderTraversalRecursiveTests
{
    private const string EmptyArray = "[]";

    [TestMethod]
    [DataRow("[1,null,2,3]", "[1,3,2]")]
    [DataRow("[1]",          "[1]")]
    [DataRow(EmptyArray,     EmptyArray)]
    public void BinaryTreeInorderTraversalRecursive_GetResult_ReturnsCorrectSequenceFromBinaryTree(
        string inputArrayJson,
        string expectedArrayJson)
    {
        // Arrange
        var expectedResult = Convert(expectedArrayJson);
        var inputArray     = Convert(inputArrayJson);
        var inputNode      = TreeNode.BuildTree(inputArray);

        // Act
        var actualResult = BinaryTreeInorderTraversalRecursive.GetResult(inputNode);

        // Assert
        Assert.IsNotNull(actualResult);
        CollectionAssert.AreEqual(expectedResult.ToList(), actualResult.ToList());
    }

    private IList<int?> Convert(string inputArrayJson)
    {
        if (inputArrayJson == EmptyArray)
            return new List<int?>
            {
                0
            };

        return JsonConvert.DeserializeObject<IList<int?>>(inputArrayJson) ?? throw new InvalidOperationException();
    }
}