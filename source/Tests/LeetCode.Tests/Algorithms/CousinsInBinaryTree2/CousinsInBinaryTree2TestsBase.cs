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

using LeetCode.Algorithms.CousinsInBinaryTree2;
using LeetCode.Core.Exceptions;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.CousinsInBinaryTree2;

public abstract class CousinsInBinaryTree2TestsBase<T> where T : ICousinsInBinaryTree2, new()
{
    [TestMethod]
    [DataRow("[5,4,9,1,10,null,7]", "[0,0,0,7,7,null,11]")]
    [DataRow("[3,1,2]", "[0,0,0]")]
    public void ReplaceValueInTree_GivenRootNode_ReturnsTreeWithReplacedValues(string rootJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var expectedResultArray = JsonHelper<int?>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);
        var rootArray = JsonHelper<int?>.DeserializeToArray(rootJsonArray);
        var root = TreeNode.ToTreeNode(rootArray) ?? throw new TreeNodeBuildException();

        var solution = new T();

        // Act
        var actualResult = solution.ReplaceValueInTree(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}