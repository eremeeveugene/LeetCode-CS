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

        yield return [new int?[] { 1 }, new int?[] { 2 }, new int?[] { 3 }];

        yield return [new int?[] { 5 }, new int?[] { 10 }, new int?[] { 15 }];

        yield return [new int?[] { 1, 2 }, new int?[] { 3 }, new int?[] { 4, 2 }];

        yield return [new int?[] { 1 }, new int?[] { 2, 3 }, new int?[] { 3, 3 }];

        yield return [new int?[] { 1, 2, 3 }, new int?[] { 4, 5, 6 }, new int?[] { 5, 7, 9 }];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 1, 2 }, new int?[] { 2, 2, 2 }];

        yield return [new int?[] { 2, 1, 3 }, new int?[] { 3, 2, 1 }, new int?[] { 5, 3, 4 }];

        yield return [new int?[] { 1, 2 }, new int?[] { 1, null, 3 }, new int?[] { 2, 2, 3 }];

        yield return [new int?[] { 0 }, new int?[] { 0 }, new int?[] { 0 }];

        yield return [new int?[] { -1 }, new int?[] { 1 }, new int?[] { 0 }];

        yield return [new int?[] { 1, 2, 3, 4 }, new int?[] { 1, 2, 3 }, new int?[] { 2, 4, 6, 4 }];

        yield return [new int?[] { 1, 2 }, new int?[] { 1, 2, 3 }, new int?[] { 2, 4, 3 }];

        yield return [new int?[] { 5 }, new int?[] { 5, 5, 5 }, new int?[] { 10, 5, 5 }];

        yield return [new int?[] { 10, 20, 30 }, new int?[] { 1 }, new int?[] { 11, 20, 30 }];

        yield return
        [
            new int?[] { 100 }, new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int?[] { 101, 2, 3, 4, 5, 6, 7 }
        ];

        yield return [new int?[] { 1, 2, 3 }, new int?[] { 4, 5 }, new int?[] { 5, 7, 3 }];

        yield return [new int?[] { 3 }, new int?[] { 5, 1, 2 }, new int?[] { 8, 1, 2 }];

        yield return [new int?[] { 7, 3 }, new int?[] { 7, null, 3 }, new int?[] { 14, 3, 3 }];

        yield return [new int?[] { 2, 3, null, 4 }, new int?[] { 2, 3, 4 }, new int?[] { 4, 6, 4, 4 }];

        yield return [Array.Empty<int?>(), new int?[] { 1, 2, 3 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 1, 2, 3 }, Array.Empty<int?>(), new int?[] { 1, 2, 3 }];
    }
}