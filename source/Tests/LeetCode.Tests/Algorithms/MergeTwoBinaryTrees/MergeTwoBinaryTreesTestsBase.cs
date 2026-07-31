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

using LeetCode.Algorithms.MergeTwoBinaryTrees;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.MergeTwoBinaryTrees;

public abstract class MergeTwoBinaryTreesTestsBase<T> where T : IMergeTwoBinaryTrees, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MergeTrees_WithTwoBinaryTrees_ReturnsMergedTree(int?[] root1Array, int?[] root2Array, int?[] expectedResultArray)
    {
        // Arrange
        var root1 = TreeNode.ToTreeNode(root1Array);
        var root2 = TreeNode.ToTreeNode(root2Array);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.MergeTrees(root1, root2);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int?>(), Array.Empty<int?>()];

        yield return [Array.Empty<int?>(), new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 1 }, Array.Empty<int?>(), new int?[] { 1 }];

        yield return [new int?[] { 1 }, new int?[] { 1, 2 }, new int?[] { 2, 2 }];

        yield return [new int?[] { 1, 3, 2, 5 }, new int?[] { 2, 1, 3, null, 4, null, 7 }, new int?[] { 3, 4, 5, 5, 4, null, 7 }];

        yield return [new int?[] { 1, 2, 3 }, new int?[] { 1, 4 }, new int?[] { 2, 6, 3 }];
    }
}