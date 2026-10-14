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

using LeetCode.Algorithms.NaryTreePreorderTraversal;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.NaryTreePreorderTraversal;

public abstract class NaryTreePreorderTraversalTestsBase<T> where T : INaryTreePreorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Preorder_WithNaryTree_ReturnsPreorderTraversalOfNodes(int?[] rootArray, int[] expectedResult)
    {
        var root = Node.ToNode(rootArray);

        var solution = new T();

        var actualResult = solution.Preorder(root);

        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, null, 3, 2, 4, null, 5, 6 }, new[] { 1, 3, 5, 6, 2, 4 }];

        yield return
        [
            new int?[] { 1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14 },
            new[] { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 }
        ];

        yield return [new int?[] { 1 }, new[] { 1 }];

        yield return [Array.Empty<int?>(), Array.Empty<int>()];

        yield return [new int?[] { 1, null, 2, 3 }, new[] { 1, 2, 3 }];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4 }, new[] { 1, 2, 3, 4 }];

        yield return [new int?[] { 1, null, 2, 3, 4, null, 5, null, 6 }, new[] { 1, 2, 5, 3, 6, 4 }];

        yield return [new int?[] { 5, null, 1, 2, 3 }, new[] { 5, 1, 2, 3 }];

        yield return [new int?[] { 1, null, 2 }, new[] { 1, 2 }];

        yield return [new int?[] { 10, null, 20, 30, 40 }, new[] { 10, 20, 30, 40 }];

        yield return [new int?[] { 1, null, 2, null, 3 }, new[] { 1, 2, 3 }];

        yield return [new int?[] { 7, null, 8, 9, null, 10 }, new[] { 7, 8, 10, 9 }];

        yield return [new int?[] { 1, null, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }];

        yield return [new int?[] { 1 }, new[] { 1 }];

        yield return [new int?[] { 1, null, 2 }, new[] { 1, 2 }];

        yield return [new int?[] { 3, null, 1, null, 2 }, new[] { 3, 1, 2 }];

        yield return [new int?[] { 2, null, 3, 1 }, new[] { 2, 3, 1 }];

        yield return [new int?[] { 2, null, 4, null, 5, null, 1, null, 3 }, new[] { 2, 4, 5, 1, 3 }];

        yield return [new int?[] { 3, null, 5, 2, 4, 6, 1 }, new[] { 3, 5, 2, 4, 6, 1 }];

        yield return [new int?[] { 7, null, 3, 6, 1, null, 2, null, 4, null, null, null, 5 }, new[] { 7, 3, 2, 6, 4, 5, 1 }];

        yield return [new int?[] { 6, null, 5, 7, 8, null, 2, 1, null, 9, 4, null, null, 3 }, new[] { 6, 5, 2, 3, 1, 7, 9, 4, 8 }];

        yield return [new int?[] { 9, null, 3, null, 2, 7, 5, 6, null, null, 1, null, 10, null, 8, null, null, null, 4 }, new[] { 9, 3, 2, 7, 1, 5, 10, 6, 8, 4 }];

        yield return [new int?[] { 3, null, 2, 10, 1, null, 7, 4, null, 12, 5, null, 11, 6, 8, null, null, null, null, null, null, 9 }, new[] { 3, 2, 7, 4, 10, 12, 5, 1, 11, 6, 9, 8 }];
    }
}