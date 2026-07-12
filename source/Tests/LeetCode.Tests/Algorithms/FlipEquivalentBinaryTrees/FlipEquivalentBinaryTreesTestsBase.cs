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

using LeetCode.Algorithms.FlipEquivalentBinaryTrees;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FlipEquivalentBinaryTrees;

public abstract class FlipEquivalentBinaryTreesTestsBase<T> where T : IFlipEquivalentBinaryTrees, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FlipEquiv_WithTwoTreeRoots_ReturnsIfTheyAreEquivalent(int?[] root1Array, int?[] root2Array, bool expectedResult)
    {
        // Arrange
        var root1 = TreeNode.ToTreeNode(root1Array);
        var root2 = TreeNode.ToTreeNode(root2Array);

        var solution = new T();

        // Act
        var actualResult = solution.FlipEquiv(root1, root2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int?>(), true];

        yield return [Array.Empty<int?>(), new int?[] { 1 }, false];

        yield return
        [
            new int?[] { 1, 2, 3, 4, 5, 6, null, null, null, 7, 8 }, new int?[] { 1, 3, 2, null, 6, 4, 5, null, null, null, null, 8, 7 }, true
        ];
    }
}