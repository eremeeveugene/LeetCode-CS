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

using LeetCode.Algorithms.DeleteLeavesWithGivenValue;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteLeavesWithGivenValue;

public abstract class DeleteLeavesWithGivenValueTestsBase<T> where T : IDeleteLeavesWithGivenValue, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RemoveLeafNodes_GivenTarget_RemovesAllLeafNodesWithTargetValue(int?[] rootArray, int target, int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveLeafNodes(root, target);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1 }, 1, Array.Empty<int?>()];

        yield return [new int?[] { 1, 2, 3, 2, null, 2, 4 }, 2, new int?[] { 1, null, 3, null, 4 }];

        yield return [new int?[] { 1, 3, 3, 3, 2 }, 3, new int?[] { 1, 3, null, null, 2 }];

        yield return [new int?[] { 1, 2, null, 2, null, 2 }, 2, new int?[] { 1 }];

        yield return
        [
            new int?[] { 1, 2, 2, 3, null, null, 3, 4, null, null, 4, 5, null, null, 5, 5, null, null, 5, 5, null, null, 5, 5, null, null, 5 },
            5,
            new int?[] { 1, 2, 2, 3, null, null, 3, 4, null, null, 4 }
        ];

        yield return [new int?[] { 3, 2, 2, 1, 1, 3, 3, null, null, null, null, null, null, 3 }, 2, new int?[] { 3, 2, 2, 1, 1, 3, 3, null, null, null, null, null, null, 3 }];

        yield return [new int?[] { 2, 2, 3, 1, 3, 3, null, null, 3, null, null, 3, null, null, 3, null, 1 }, 1, new int?[] { 2, 2, 3, 1, 3, 3, null, null, 3, null, null, 3, null, null, 3 }];

        yield return [new int?[] { 1, 3, 3, 2, null, 1, null, 2, 1, null, 2, null, null, null, null, 3, null, null, 1 }, 3, new int?[] { 1, 3, 3, 2, null, 1, null, 2, 1, null, 2, null, null, null, null, 3, null, null, 1 }];

        yield return [new int?[] { 1 }, 3, new int?[] { 1 }];

        yield return [new int?[] { 2, null, 1 }, 2, new int?[] { 2, null, 1 }];

        yield return [new int?[] { 1, 3 }, 1, new int?[] { 1, 3 }];

        yield return [new int?[] { 1, 2, 2, null, null, null, 3 }, 2, new int?[] { 1, null, 2, null, 3 }];

        yield return [new int?[] { 2, 2, 1, null, 1, null, 2, 2, null, 2, null, null, null, 1, 3, 1, null, null, null, 1 }, 1, new int?[] { 2, 2, 1, null, 1, null, 2, 2, null, 2, null, null, null, null, 3 }];

        yield return [new int?[] { 1, 2, 3, 1, 1, null, 2, null, 2, null, null, null, 1, null, null, 2, 2, 3, null, 2 }, 1, new int?[] { 1, 2, 3, 1, null, null, 2, null, 2, null, 1, null, null, 2, 2, 3, null, 2 }];

        yield return [new int?[] { 1, 3, 2, null, 2, null, null, null, 2 }, 1, new int?[] { 1, 3, 2, null, 2, null, null, null, 2 }];

        yield return [new int?[] { 1, 3, 1, 3, 2, null, 2, null, 2, 1, 3, null, 2, null, null, null, null, null, null, null, 3 }, 1, new int?[] { 1, 3, 1, 3, 2, null, 2, null, 2, null, 3, null, 2, null, null, null, null, null, 3 }];

        yield return [new int?[] { 1, 3, null, 3, 2, 1, 1, 2, null, null, null, 2, null, null, null, 1 }, 1, new int?[] { 1, 3, null, 3, 2, null, 1, 2, null, 2 }];

        yield return [new int?[] { 3, 2, 3, 2, null, 1, null, 3, 1 }, 1, new int?[] { 3, 2, 3, 2, null, null, null, 3 }];

        yield return [new int?[] { 1, 1, 2, 1, 2, 2, 2, 2, null, 1, null, 1, 1, null, null, null, null, 3 }, 3, new int?[] { 1, 1, 2, 1, 2, 2, 2, 2, null, 1, null, 1, 1 }];

        yield return [new int?[] { 2, 1, 3, 1, null, null, 1, 3, 2, 2, null, 1, null, 1, null, 3, 2 }, 1, new int?[] { 2, 1, 3, 1, null, null, 1, 3, 2, 2, null, null, null, null, null, 3, 2 }];

        yield return [new int?[] { 1, 2, 2, 3, 3, 1, 1, null, null, null, null, null, null, 3 }, 2, new int?[] { 1, 2, 2, 3, 3, 1, 1, null, null, null, null, null, null, 3 }];

        yield return [new int?[] { 2, 2, 2, 2, 2 }, 2, Array.Empty<int?>()];

        yield return [new int?[] { 1, 2, 3 }, 4, new int?[] { 1, 2, 3 }];
    }
}