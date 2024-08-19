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

using LeetCode.Algorithms.MergeTwoBinaryTrees;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.MergeTwoBinaryTrees;

public abstract class MergeTwoBinaryTreesTestsBase<T> where T : IMergeTwoBinaryTrees, new()
{
    [TestMethod]
    [DataRow("[]", "[]", "[]")]
    [DataRow("[]", "[1]", "[1]")]
    [DataRow("[1]", "[]", "[1]")]
    [DataRow("[1]", "[1,2]", "[2,2]")]
    [DataRow("[1,3,2,5]", "[2,1,3,null,4,null,7]", "[3,4,5,5,4,null,7]")]
    public void MergeTrees_WithTwoBinaryTrees_ReturnsMergedTree(string root1JsonArray, string root2JsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var root1Array = JsonHelper<int?>.DeserializeToList(root1JsonArray);
        var root1 = TreeNode.BuildTree(root1Array);

        var root2Array = JsonHelper<int?>.DeserializeToList(root2JsonArray);
        var root2 = TreeNode.BuildTree(root2Array);

        var expectedResultArray = JsonHelper<int?>.DeserializeToList(expectedResultJsonArray);
        var expectedResult = TreeNode.BuildTree(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.MergeTrees(root1, root2);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}