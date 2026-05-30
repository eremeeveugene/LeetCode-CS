// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CousinsInBinaryTree2;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.CousinsInBinaryTree2;

public abstract class CousinsInBinaryTree2TestsBase<T> where T : ICousinsInBinaryTree2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ReplaceValueInTree_GivenRootNode_ReturnsTreeWithReplacedValues(int?[] rootArray, int?[] expectedResultArray)
    {
        // Arrange
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.ReplaceValueInTree(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 5, 4, 9, 1, 10, null, 7 }, new int?[] { 0, 0, 0, 7, 7, null, 11 }];

        yield return [new int?[] { 3, 1, 2 }, new int?[] { 0, 0, 0 }];
    }
}