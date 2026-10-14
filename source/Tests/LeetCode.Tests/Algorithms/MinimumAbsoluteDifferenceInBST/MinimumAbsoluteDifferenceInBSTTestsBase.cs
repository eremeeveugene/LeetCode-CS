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

using LeetCode.Algorithms.MinimumAbsoluteDifferenceInBST;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MinimumAbsoluteDifferenceInBST;

public abstract class MinimumAbsoluteDifferenceInBSTTestsBase<T> where T : IMinimumAbsoluteDifferenceInBST, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void GetMinimumDifference_GivenBST_ReturnsMinimumAbsoluteDifference(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.GetMinimumDifference(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 4, 2, 6, 1, 3 }, 1];

        yield return [new int?[] { 1, 0, 48, null, null, 12, 49 }, 1];

        yield return [new int?[] { 90, 69, null, 49, 89, null, 52 }, 1];
        yield return [new int?[] { 0, null, 100000 }, 100000];
        yield return [new int?[] { 100000, 0 }, 100000];
        yield return [new int?[] { 5, 3 }, 2];
        yield return [new int?[] { 5, 3, 8 }, 2];
        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5 }, 1];
        yield return [new int?[] { 5, 4, null, 3, null, 2, null, 1 }, 1];
        yield return [new int?[] { 10, 5, 15, 2, 7, 12, 20 }, 2];
        yield return [new int?[] { 50, 25, 75, 10, 30, 60, 90 }, 5];
        yield return [new int?[] { 0, null, 50000, null, 100000 }, 50000];
        yield return [new int?[] { 8, 3, 10, 1, 6, null, 14, null, null, 4, 7, 13 }, 1];
        yield return [new int?[] { 2, 1, 100000 }, 1];
        yield return [new int?[] { 100, 1, null, null, 99, 2, null, null, 98 }, 1];
        yield return [new int?[] { 20, 10, 30, 5, 15, 25, 35, 1 }, 4];
        yield return [new int?[] { 7, 0, 100000, null, 3, null, null, null, 6 }, 1];
        yield return [new int?[] { 66836, 57853, 87438, 49420, 60144, 67478, 92292, 36999, 49553, 58435, null, null, 69599, 88060, null, 635, 40163, null, null, null, null, 68118, 84472, null, 88508, null, 23081, null, 41898, null, null, 73670, 86629, null, null, 17554, 31116, null, null, null, null, null, null, 13404, null, null, 33596, null, null, null, 34033 }, 133];
        yield return [new int?[] { 64653, 60931, 91370, 54810, null, 67760, 97999, 21649, null, null, 86120, null, null, 21572, 47711, null, null, 11627, null, 32500, 51805, null, null, 22028, 34983, 48699 }, 77];
        yield return [new int?[] { 62930, 58633, 98814, 7780, 59790, 67541, 99933, 6903, 40244, 59232, 62743, 63123, 76065, 99583, null, 295, null, 24482, 48044, null, null, null, null, null, 64429, 70497, 87960, null, null, null, 4531, 13245, 29093, 45150, 57761, 63454, 66092, 69004, null, 87904, 89368, 1122, null, 9346, 16967, 28295, 37041, 44053, 47719, null, null, null, null, null, null, null, null, 83876, null, null, 96968, null, null, 8006, null, null, 19318, null, null, 33313, 37190, null, 44457, 45202, null, 77094, 84780, 90799, null, null, 8786, 17547, null, 32308, null, null, null, null, null, null, null, null, 77909, null, 85812, null, 93694, null, null, null, null, 29541, null, null, null, null, null, null, 96643 }, 52];
    }
}