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

using LeetCode.Algorithms.FindLargestValueInEachTreeRow;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindLargestValueInEachTreeRow;

public abstract class FindLargestValueInEachTreeRowTestsBase<T> where T : IFindLargestValueInEachTreeRow, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LargestValues_WithTreeRoot_ReturnsListOfRowMaxima(int?[] rootArray, int[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.LargestValues(root);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int>()];

        yield return [new int?[] { 1, 2, 3 }, new[] { 1, 3 }];

        yield return [new int?[] { 1, 3, 2, 5, 3, null, 9 }, new[] { 1, 3, 9 }];

        yield return [new int?[] { -29 }, new[] { -29 }];

        yield return [new int?[] { 3, null, 38 }, new[] { 3, 38 }];

        yield return [new int?[] { 31, -14, null, 11 }, new[] { 31, -14, 11 }];

        yield return [new int?[] { 15, -27, 14, 17 }, new[] { 15, 14, 17 }];

        yield return [new int?[] { -3, 24, 4, -42, null, null, null, -32 }, new[] { -3, 24, -42, -32 }];

        yield return [new int?[] { 44, 6, 48, null, -46, null, 2, null, null, null, 28 }, new[] { 44, 48, 2, 28 }];

        yield return [new int?[] { -3, -31, -48, 44, null, null, -48, -39, -35 }, new[] { -3, -31, 44, -35 }];

        yield return [new int?[] { -27, 35, 10, -20, -46, null, 49, -41, null, null, null, -25 }, new[] { -27, 35, 49, -25 }];

        yield return [new int?[] { -25, -4, -7, null, null, -32, null, -13, 18, null, null, 2, 7, null, 14 }, new[] { -25, -4, -32, 18, 7, 14 }];

        yield return [new int?[] { 41, 41, 20, null, 13, null, 16, -50, null, null, null, 26, 12, null, null, -42, 45 }, new[] { 41, 41, 16, -50, 26, 45 }];

        yield return [new int?[] { -8, -11, -6, -37, -19, 47, 26, null, -42, null, null, null, null, -28, -29, null, null, 49 }, new[] { -8, -6, 47, -28, 49 }];

        yield return [new int?[] { -49, -2, -6, null, null, -19, 12, 6, null, 21, 14, null, null, null, null, 35, null, -19, -30, null, -42 }, new[] { -49, -2, 12, 21, 35, -19, -42 }];

        yield return [new int?[] { -29, -42, 0, -32, 32, null, -7, -18, null, -33, null, null, -31, null, null, null, null, 45, null, 43, -44, null, 11 }, new[] { -29, 0, 32, -18, 45, 43, 11 }];

        yield return [new int?[] { 18, 25, -9, 41, -15, null, null, null, null, 48, -33, 37, 42, -2, -49, -47, null, -34, -17, null, null, null, 25 }, new[] { 18, 25, 41, 48, 42, 25 }];

        yield return [new int?[] { 32, 7, 50, -14, -41, -12, -32, null, -34, -22, -35, 0, null, 18, null, -9, -29, null, null, 33, null, null, 13, null, null, null, null, null, null, null, null, 29 }, new[] { 32, 50, -12, 18, 33, 29 }];

        yield return [new int?[] { 41, -21, null, -19, -18, -38, -1, 39, -10, null, null, 14, null, 45, 27, null, -11, null, null, 23, -31, -13, -45, null, null, null, null, null, null, null, 20, 12, 42, null, null, 19 }, new[] { 41, -21, -18, 39, 45, 23, 42, 19 }];

        yield return [new int?[] { 14, 37, 29, 16, null, -48, 40, null, null, 32, 6, null, null, null, null, 10 }, new[] { 14, 37, 40, 32, 10 }];
    }
}