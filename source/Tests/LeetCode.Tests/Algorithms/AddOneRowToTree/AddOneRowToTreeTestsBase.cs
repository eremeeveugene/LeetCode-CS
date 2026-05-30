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

using LeetCode.Algorithms.AddOneRowToTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.AddOneRowToTree;

public abstract class AddOneRowToTreeTestsBase<T> where T : IAddOneRowToTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void AddOneRow_AddsRowToBinaryTreeAtSpecifiedDepthAndValue_VerifiesTreeStructure(int?[] rootArray, int val, int depth, int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.AddOneRow(root, val, depth);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), 0, 0, Array.Empty<int?>()];

        yield return [new int?[] { 4, 2, 6, 3, 1, 5 }, 1, 2, new int?[] { 4, 1, 1, 2, null, null, 6, 3, 1, 5 }];

        yield return [new int?[] { 4, 2, null, 3, 1 }, 1, 3, new int?[] { 4, 2, null, 1, 1, 3, null, null, 1 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 4, null, null, 8, null, null, 9 }, 100, 1, new int?[] { 100, 1, null, 2, 3, 4, null, null, 4, null, null, 8, null, null, 9 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 4, null, null, 8, null, null, 9 }, 100, 2, new int?[] { 1, 100, 100, 2, null, null, 3, 4, null, null, 4, null, null, 8, null, null, 9 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 4, null, null, 8, null, null, 9 }, 100, 3, new int?[] { 1, 2, 3, 100, 100, 100, 100, 4, null, null, null, null, null, null, 4, null, null, 8, null, null, 9 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 4, null, null, 8, null, null, 9 }, 100, 4, new int?[] { 1, 2, 3, 4, null, null, 4, 100, 100, 100, 100, null, null, null, null, 8, null, null, null, null, 9 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 4, null, null, 8, null, null, 9 }, 100, 5, new int?[] { 1, 2, 3, 4, null, null, 4, null, null, 8, null, 100, 100, null, null, null, 9 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 4, null, null, 8, null, null, 9 }, 100, 6, new int?[] { 1, 2, 3, 4, null, null, 4, null, null, 8, null, null, 9, 100, 100 }];

        yield return [new int?[] { 5, 3, null, 4, null, 8, null, 9 }, 100, 1, new int?[] { 100, 5, null, 3, null, 4, null, 8, null, 9 }];

        yield return [new int?[] { 5, 3, null, 4, null, 8, null, 9 }, 100, 2, new int?[] { 5, 100, 100, 3, null, null, null, 4, null, 8, null, 9 }];

        yield return [new int?[] { 5, 3, null, 4, null, 8, null, 9 }, 100, 3, new int?[] { 5, 3, null, 100, 100, 4, null, null, null, 8, null, 9 }];

        yield return [new int?[] { 5, 3, null, 4, null, 8, null, 9 }, 100, 4, new int?[] { 5, 3, null, 4, null, 100, 100, 8, null, null, null, 9 }];

        yield return [new int?[] { 5, 3, null, 4, null, 8, null, 9 }, 100, 5, new int?[] { 5, 3, null, 4, null, 8, null, 100, 100, 9 }];

        yield return [new int?[] { 5, 3, null, 4, null, 8, null, 9 }, 100, 6, new int?[] { 5, 3, null, 4, null, 8, null, 9, null, 100, 100 }];
    }
}