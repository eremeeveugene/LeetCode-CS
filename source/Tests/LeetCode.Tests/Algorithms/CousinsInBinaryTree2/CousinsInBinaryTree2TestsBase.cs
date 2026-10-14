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

        yield return [new int?[] { 1 }, new int?[] { 0 }];

        yield return [new int?[] { 1, 2 }, new int?[] { 0, 0 }];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 0, null, 0 }];

        yield return [new int?[] { 1, 2, 3 }, new int?[] { 0, 0, 0 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int?[] { 0, 0, 0, 13, 13, 9, 9 }];

        yield return [new int?[] { 10, 5, 7, 1, 2, 3, 4 }, new int?[] { 0, 0, 0, 7, 7, 3, 3 }];

        yield return [new int?[] { 1, 2, null, 3 }, new int?[] { 0, 0, null, 0 }];

        yield return [new int?[] { 1, null, 2, null, 3 }, new int?[] { 0, null, 0, null, 0 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6 }, new int?[] { 0, 0, 0, 6, 6, 9 }];

        yield return [new int?[] { 4, 1, 2, 3, null, null, 5, 6 }, new int?[] { 0, 0, 0, 5, null, null, 3, 0 }];

        yield return [new int?[] { 8, 3, 4, 1, 2, 5, 6, 7, 8, 9, 10 }, new int?[] { 0, 0, 0, 11, 11, 3, 3, 19, 19, 15, 15 }];

        yield return [new int?[] { 1, 2, 3, null, 4, 5 }, new int?[] { 0, 0, 0, null, 5, 4 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 5 }, new int?[] { 0, 0, 0, 5, null, null, 4 }];

        yield return [new int?[] { 10000, 10000, 10000, 10000, 10000, 10000, 10000 }, new int?[] { 0, 0, 0, 20000, 20000, 20000, 20000 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, null, 6, 7, null, 8 }, new int?[] { 0, 0, 0, 6, 6, null, 9, 8, null, 7 }];

        yield return [new int?[] { 2, 1, 3, null, 4, null, 7 }, new int?[] { 0, 0, 0, null, 7, null, 4 }];

        yield return [new int?[] { 6, 2, 8, 1, 4, 7, 9 }, new int?[] { 0, 0, 0, 16, 16, 5, 5 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new int?[] { 0, 0, 0, 13, 13, 9, 9, 75, 75, 71, 71, 67, 67, 63, 63 }];
    }
}