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

using LeetCode.Algorithms.ReverseOddLevelsOfBinaryTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ReverseOddLevelsOfBinaryTree;

public abstract class ReverseOddLevelsOfBinaryTreeTestsBase<T> where T : IReverseOddLevelsOfBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ReverseOddLevels_GivenTree_ReturnsTreeWithOddLevelsReversed(int?[] rootArray, int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ReverseOddLevels(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int?>()];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 7, 13, 11 }, new int?[] { 7, 11, 13 }];

        yield return [new int?[] { 2, 3, 5, 8, 13, 21, 34 }, new int?[] { 2, 5, 3, 8, 13, 21, 34 }];

        yield return [new int?[] { 0, 1, 2, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2 }, new int?[] { 0, 2, 1, 0, 0, 0, 0, 2, 2, 2, 2, 1, 1, 1, 1 }];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 1, null, 2 }];

        yield return
        [
            new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new int?[] { 1, 3, 2, 4, 5, 6, 7, 15, 14, 13, 12, 11, 10, 9, 8 }
        ];

        yield return [new int?[] { 1, 2, null, 3, null, 4, null, 5 }, new int?[] { 1, 2, null, 3, null, 4, null, 5 }];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5 }, new int?[] { 1, null, 2, null, 3, null, 4, null, 5 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 5, 6, null, null, 7 }, new int?[] { 1, 3, 2, 4, null, null, 5, 7, null, null, 6 }];
        yield return [new int?[] { 1, 2, 3 }, new int?[] { 1, 3, 2 }];
        yield return [new int?[] { 0, 100000, 0 }, new int?[] { 0, 0, 100000 }];
        yield return [new int?[] { 5, 4, 3, 2, 1, 0, 9 }, new int?[] { 5, 3, 4, 2, 1, 0, 9 }];
        yield return [new int?[] { 1, 1, 1, 1, 1, 1, 1 }, new int?[] { 1, 1, 1, 1, 1, 1, 1 }];
        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }, new int?[] { 1, 3, 2, 4, 5, 6, 7, 15, 14, 13, 12, 11, 10, 9, 8, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }];
        yield return [new int?[] { 100000, 99999, 99998, 15495, 26856, 79704, 94122 }, new int?[] { 100000, 99998, 99999, 15495, 26856, 79704, 94122 }];
        yield return [new int?[] { 15827, 29610, 73626, 45943, 15327, 38357, 27892, 88098, 76201, 47565, 87736, 93892, 27103, 73308, 19741 }, new int?[] { 15827, 73626, 29610, 45943, 15327, 38357, 27892, 19741, 73308, 27103, 93892, 87736, 47565, 76201, 88098 }];
        yield return [new int?[] { 4, 2, 5, 2, 4, 3, 9, 5, 8, 5, 5, 7, 7, 5, 5, 1, 0, 3, 7, 1, 0, 9, 0, 8, 5, 9, 4, 5, 6, 2, 3 }, new int?[] { 4, 5, 2, 2, 4, 3, 9, 5, 5, 7, 7, 5, 5, 8, 5, 1, 0, 3, 7, 1, 0, 9, 0, 8, 5, 9, 4, 5, 6, 2, 3 }];
        yield return [new int?[] { 55197, 35356, 34643, 24124, 51135, 26901, 26804, 66379, 28649, 9007, 73339, 62742, 81461, 75308, 31149, 42820, 55764, 74658, 75336, 9222, 16818, 3017, 22962, 65270, 19282, 62109, 79836, 61479, 42433, 29693, 33749, 76308, 40484, 87103, 76917, 82335, 41591, 41460, 49475, 27770, 31454, 94530, 55612, 92638, 28758, 99802, 31067, 45099, 22881, 35527, 18759, 89991, 76589, 73827, 11096, 42868, 24898, 86843, 13447, 46120, 11960, 38483, 65367 }, new int?[] { 55197, 34643, 35356, 24124, 51135, 26901, 26804, 31149, 75308, 81461, 62742, 73339, 9007, 28649, 66379, 42820, 55764, 74658, 75336, 9222, 16818, 3017, 22962, 65270, 19282, 62109, 79836, 61479, 42433, 29693, 33749, 65367, 38483, 11960, 46120, 13447, 86843, 24898, 42868, 11096, 73827, 76589, 89991, 18759, 35527, 22881, 45099, 31067, 99802, 28758, 92638, 55612, 94530, 31454, 27770, 49475, 41460, 41591, 82335, 76917, 87103, 40484, 76308 }];
        yield return [new int?[] { 75, 39, 50, 47, 11, 67, 71, 53, 4, 35, 61, 56, 51, 19, 51, 85, 34, 10, 25, 21, 45, 84, 80, 73, 57, 61, 56, 62, 69, 13, 44, 13, 96, 1, 12, 18, 64, 54, 74, 48, 3, 52, 49, 31, 42, 16, 58, 20, 56, 52, 35, 53, 66, 21, 80, 64, 61, 61, 37, 46, 21, 30, 87, 41, 50, 55, 16, 77, 24, 5, 79, 90, 23, 4, 28, 29, 28, 9, 90, 71, 53, 17, 29, 31, 84, 19, 6, 52, 26, 70, 20, 79, 61, 17, 23, 80, 87, 97, 77, 31, 67, 71, 44, 85, 40, 73, 22, 63, 0, 100, 25, 95, 16, 40, 51, 42, 64, 44, 18, 91, 11, 29, 57, 88, 45, 54, 56 }, new int?[] { 75, 50, 39, 47, 11, 67, 71, 51, 19, 51, 56, 61, 35, 4, 53, 85, 34, 10, 25, 21, 45, 84, 80, 73, 57, 61, 56, 62, 69, 13, 44, 87, 30, 21, 46, 37, 61, 61, 64, 80, 21, 66, 53, 35, 52, 56, 20, 58, 16, 42, 31, 49, 52, 3, 48, 74, 54, 64, 18, 12, 1, 96, 13, 41, 50, 55, 16, 77, 24, 5, 79, 90, 23, 4, 28, 29, 28, 9, 90, 71, 53, 17, 29, 31, 84, 19, 6, 52, 26, 70, 20, 79, 61, 17, 23, 80, 87, 97, 77, 31, 67, 71, 44, 85, 40, 73, 22, 63, 0, 100, 25, 95, 16, 40, 51, 42, 64, 44, 18, 91, 11, 29, 57, 88, 45, 54, 56 }];
    }
}