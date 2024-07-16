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

using LeetCode.Algorithms.CreateBinaryTreeFromDescriptions;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.CreateBinaryTreeFromDescriptions;

public abstract class CreateBinaryTreeFromDescriptionsTestsBase<T> where T : ICreateBinaryTreeFromDescriptions, new()
{
    [TestMethod]
    [DataRow("[[20,15,1],[20,17,0],[50,20,1],[50,80,0],[80,19,1]]", "[50,20,80,15,17,19]")]
    [DataRow("[[1,2,1],[2,3,0],[3,4,1]]", "[1,2,null,null,3,4]")]
    public void CreateBinaryTree_WithValidDescriptions_ReturnsCorrectTreeStructure(string descriptionsJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var expectedResultArray = JsonHelper<int?>.JsonArrayToList(expectedResultJsonArray);
        var expectedResult = TreeNode.BuildTree(expectedResultArray);
        var descriptions = JsonHelper<int>.JsonArrayToJaggedArray(descriptionsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CreateBinaryTree(descriptions);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}