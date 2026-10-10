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

using LeetCode.Algorithms.SmallestSubtreeWithAllTheDeepestNodes;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SmallestSubtreeWithAllTheDeepestNodes;

public abstract class SmallestSubtreeWithAllTheDeepestNodesTestsBase<T> where T : ISmallestSubtreeWithAllTheDeepestNodes, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SubtreeWithAllDeepest_WithBinaryTree_ReturnsSmallestSubtreeWithAllTheDeepestNodes(int?[] rootArray, int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);
        var expectedResult = TreeNode.ToTreeNodeOrThrow(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.SubtreeWithAllDeepest(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 }, new int?[] { 2, 7, 4 }];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 0, 1, 3, null, 2 }, new int?[] { 2 }];
        yield return [new int?[] { 0, 1 }, new int?[] { 1 }];
        yield return [new int?[] { 0, null, 1 }, new int?[] { 1 }];
        yield return [new int?[] { 1, 2, 3 }, new int?[] { 1, 2, 3 }];
        yield return [new int?[] { 1, 2, 3, 4 }, new int?[] { 4 }];
        yield return [new int?[] { 1, 2, 3, null, 4 }, new int?[] { 4 }];
        yield return [new int?[] { 0, 1, 2, 3, 4, 5, 6 }, new int?[] { 0, 1, 2, 3, 4, 5, 6 }];
        yield return [new int?[] { 0, 1, null, 2, null, 3 }, new int?[] { 3 }];
        yield return [new int?[] { 0, null, 1, null, 2, null, 3 }, new int?[] { 3 }];
        yield return [new int?[] { 5, 1, 2, 3, null, null, 4 }, new int?[] { 5, 1, 2, 3, null, null, 4 }];
        yield return [new int?[] { 366, 169, 399, 247, null, 126, 156, null, null, null, 120, 473, 59, 391, 209, 295, 331, null, 92, null, 304, null, null, 204, null, 250, 170, null, null, 95, null, null, null, 77, null, null, 254 }, new int?[] { 399, 126, 156, null, 120, 473, 59, 391, 209, 295, 331, null, 92, null, 304, null, null, 204, null, 250, 170, null, null, 95, null, null, null, 77, null, null, 254 }];
        yield return [new int?[] { 482, 483, 164, 372, 385, 11, 134, null, 166, 251, 352, null, 351, null, null, null, 466, 401, 36, null, null, 144, 42, 223, null, null, null, 440, 455, null, null, null, null, 407, 303, null, 259, 282, 214, null, null, 151 }, new int?[] { 151 }];
        yield return [new int?[] { 227, 307, 52, 473, 296, 251, 427, null, 17, null, 498, 409, 147, 381, null, null, 50, null, null, 8, null, 321, null, 396, 376, null, 436, null, null, null, 83, 200, null, null, 54, null, null, null, 89 }, new int?[] { 89 }];
        yield return [new int?[] { 147, null, 437, 305, null, 427, 301, 267, 289, 265, 108, 338, 27, 421, 260, null, null, null, null, 15, 10, 362, 300, null, 124, null, null, null, 259, null, null, null, null, 315, null, 45 }, new int?[] { 427, 267, 289, 338, 27, 421, 260, 15, 10, 362, 300, null, 124, null, null, null, 259, null, null, null, null, 315, null, 45 }];
        yield return [new int?[] { 331, 59, 381, 322, null, null, 278, null, 464, null, 156 }, new int?[] { 331, 59, 381, 322, null, null, 278, null, 464, null, 156 }];
        yield return [new int?[] { 444, 177, 234, 186, 40, 213, 174, 212, 53, null, 384, 144, null, null, null, null, 15, 454, 211, null, null, null, 344, null, null, 115, null, null, null, 398, 0, null, 209, null, 479, null, 435 }, new int?[] { 444, 177, 234, 186, 40, 213, 174, 212, 53, null, 384, 144, null, null, null, null, 15, 454, 211, null, null, null, 344, null, null, 115, null, null, null, 398, 0, null, 209, null, 479, null, 435 }];
        yield return [new int?[] { 149, null, 112, 435, 20, 392, null, 220, null, 92, 85, null, null, 353, 111, null, 412, null, null, null, null, 360, 391, 434 }, new int?[] { 434 }];
        yield return [new int?[] { 133, 93, 357, 277, 424, 264, null, 122, null, 452, 239, 34, 6, null, null, null, null, null, null, 42, null, null, null, 335, 480, null, 148 }, new int?[] { 148 }];
    }
}