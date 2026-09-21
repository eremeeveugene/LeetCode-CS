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

using LeetCode.Algorithms.BalanceABinarySearchTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.BalanceABinarySearchTree;

public abstract class BalanceABinarySearchTreeTestsBase<T> where T : IBalanceABinarySearchTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void BalanceBST_WithGivenBinarySearchTree_ReturnsBalancedTree(int?[] rootArray, int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);
        var expectedResult = TreeNode.ToTreeNodeOrThrow(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.BalanceBST(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, null }, new int?[] { 2, 1, 3, null, null, null, 4 }];

        yield return [new int?[] { 2, 1, 3 }, new int?[] { 2, 1, 3 }];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 100000 }, new int?[] { 100000 }];

        yield return [new int?[] { 2, 1 }, new int?[] { 1, null, 2 }];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 1, null, 2 }];

        yield return [new int?[] { 3, 2, null, 1 }, new int?[] { 2, 1, 3 }];

        yield return [new int?[] { 1, null, 2, null, 3 }, new int?[] { 2, 1, 3 }];

        yield return [new int?[] { 3, 1, null, null, 2 }, new int?[] { 2, 1, 3 }];

        yield return [new int?[] { 1, null, 3, 2 }, new int?[] { 2, 1, 3 }];

        yield return [new int?[] { 4, 3, null, 2, null, 1 }, new int?[] { 2, 1, 3, null, null, null, 4 }];

        yield return [new int?[] { 4, 1, null, null, 3, 2 }, new int?[] { 2, 1, 3, null, null, null, 4 }];

        yield return [new int?[] { 1, null, 4, 2, null, null, 3 }, new int?[] { 2, 1, 3, null, null, null, 4 }];

        yield return [new int?[] { 3, 2, 4, 1 }, new int?[] { 2, 1, 3, null, null, null, 4 }];

        yield return [new int?[] { 2, 1, 4, null, null, 3 }, new int?[] { 2, 1, 3, null, null, null, 4 }];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5 }, new int?[] { 3, 1, 4, null, 2, null, 5 }];

        yield return [new int?[] { 5, 4, null, 3, null, 2, null, 1 }, new int?[] { 3, 1, 4, null, 2, null, 5 }];

        yield return [new int?[] { 3, 1, 5, null, 2, 4 }, new int?[] { 3, 1, 4, null, 2, null, 5 }];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6 }, new int?[] { 3, 1, 5, null, 2, 4, 6 }];

        yield return [new int?[] { 6, 5, null, 4, null, 3, null, 2, null, 1 }, new int?[] { 3, 1, 5, null, 2, 4, 6 }];

        yield return [new int?[] { 4, 2, 6, 1, 3, 5 }, new int?[] { 3, 1, 5, null, 2, 4, 6 }];

        yield return [new int?[] { 4, 2, 6, 1, 3, 5, 7 }, new int?[] { 4, 2, 6, 1, 3, 5, 7 }];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6, null, 7 }, new int?[] { 4, 2, 6, 1, 3, 5, 7 }];

        yield return [new int?[] { 7, 6, null, 5, null, 4, null, 3, null, 2, null, 1 }, new int?[] { 4, 2, 6, 1, 3, 5, 7 }];

        yield return [new int?[] { 5, 3, 7, 2, 4, 6, 8, 1 }, new int?[] { 4, 2, 6, 1, 3, 5, 7, null, null, null, null, null, null, null, 8 }];

        yield return
        [
            new int?[] { 5, 3, 8, 2, 4, 7, 9, 1, null, null, null, 6 },
            new int?[] { 5, 2, 7, 1, 3, 6, 8, null, null, null, 4, null, null, null, 9 }
        ];

        yield return
        [
            new int?[] { 50, 20, 80, 10, 30, 70, 90, null, null, null, 40, 60 },
            new int?[] { 50, 20, 70, 10, 30, 60, 80, null, null, null, 40, null, null, null, 90 }
        ];

        yield return [new int?[] { 100000, 1, null, null, 99999 }, new int?[] { 99999, 1, 100000 }];

        yield return [new int?[] { 1, null, 100000, 50000 }, new int?[] { 50000, 1, 100000 }];

        yield return [new int?[] { 50000, 1, 100000 }, new int?[] { 50000, 1, 100000 }];

        yield return
        [
            new int?[] { 10, 5, 20, null, 8, 15, null, 6, 9, null, 18 },
            new int?[] { 9, 6, 15, 5, 8, 10, 18, null, null, null, null, null, null, null, 20 }
        ];

        yield return
        [
            new int?[] { 40, 10, 90, null, 30, 70, null, 20, null, 50, 80, null, null, null, 60 },
            new int?[] { 50, 20, 70, 10, 30, 60, 80, null, null, null, 40, null, null, null, 90 }
        ];
    }
}