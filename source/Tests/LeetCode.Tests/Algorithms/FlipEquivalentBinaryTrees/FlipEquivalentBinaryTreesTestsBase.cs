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

using LeetCode.Algorithms.FlipEquivalentBinaryTrees;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FlipEquivalentBinaryTrees;

public abstract class FlipEquivalentBinaryTreesTestsBase<T> where T : IFlipEquivalentBinaryTrees, new()
{
    [TestMethod]
    [DataRow("[]", "[]", true)]
    [DataRow("[]", "[1]", false)]
    [DataRow("[1,2,3,4,5,6,null,null,null,7,8]", "[1,3,2,null,6,4,5,null,null,null,null,8,7]", true)]
    public void FlipEquiv_WithTwoTreeRoots_ReturnsIfTheyAreEquivalent(string root1JsonArray, string root2JsonArray,
        bool expectedResult)
    {
        // Arrange
        var root1Array = JsonHelper<int?>.DeserializeToArray(root1JsonArray);
        var root1 = TreeNode.ToTreeNode(root1Array);
        var root2Array = JsonHelper<int?>.DeserializeToArray(root2JsonArray);
        var root2 = TreeNode.ToTreeNode(root2Array);

        var solution = new T();

        // Act
        var actualResult = solution.FlipEquiv(root1, root2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}