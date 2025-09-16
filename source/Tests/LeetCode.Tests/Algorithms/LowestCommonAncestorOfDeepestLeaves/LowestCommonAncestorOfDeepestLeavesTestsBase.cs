// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.LowestCommonAncestorOfDeepestLeaves;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.LowestCommonAncestorOfDeepestLeaves;

public abstract class LowestCommonAncestorOfDeepestLeavesTestsBase<T>
    where T : ILowestCommonAncestorOfDeepestLeaves, new()
{
    [TestMethod]
    [DataRow("[3,5,1,6,2,0,8,null,null,7,4]", "[2,7,4]")]
    [DataRow("[1]", "[1]")]
    [DataRow("[0,1,3,null,2]", "[2]")]
    public void LcaDeepestLeaves_WithBinaryTree_ReturnsLowestCommonAncestorOfDeepestLeaves(string rootJson,
        string expectedResultJson)
    {
        // Arrange
        var solution = new T();

        var rootArray = JsonHelper<int?[]>.Parse(rootJson);
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);
        var expectedResultArray = JsonHelper<int?[]>.Parse(expectedResultJson);
        var expectedResult = TreeNode.ToTreeNodeOrThrow(expectedResultArray);

        // Act
        var actualResult = solution.LcaDeepestLeaves(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }
}