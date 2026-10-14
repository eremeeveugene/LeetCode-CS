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

using LeetCode.Algorithms.MinimumDistanceBetweenBSTNodes;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MinimumDistanceBetweenBSTNodes;

public abstract class MinimumDistanceBetweenBSTNodesTestsBase<T> where T : IMinimumDistanceBetweenBSTNodes, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinDiffInBST_WithVariousBSTs_ReturnsMinimumDifference(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinDiffInBST(root);

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

        yield return [new int?[] { 5, null, 5 }, 0];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6, null, 7 }, 1];

        yield return [new int?[] { 7, 6, null, 5, null, 4, null, 3, null, 2, null, 1 }, 1];

        yield return [new int?[] { 50, 25, 75, 12, 37, 62, 87 }, 12];

        yield return [new int?[] { 10, 5, 30, null, null, 20, 40 }, 5];

        yield return [new int?[] { 0, null, 50000, null, 100000 }, 50000];

        yield return [new int?[] { 1, null, 10, null, 100, null, 1000, null, 10000, null, 100000 }, 9];

        yield return [new int?[] { 9917, 4899, 34080, null, null, null, 92220, 54284, null, 41560, 76383, null, null, 74206, 78321, 72902 }, 1304];

        yield return [new int?[] { 32133, 27050, 67002, null, 29376, 41420, 67317, null, null, 32561, null, null, 86307, null, null, 78278 }, 315];

        yield return [new int?[] { 86412, 78922, 93259, 74397, 85906, null, null, 9680, null, null, null, null, 32882, 28335, 45534 }, 506];

        yield return [new int?[] { 38867, 7543, 47036, 5358, 21821, null, 90132, null, null, 21724, 22153, 54224, null, null, null, null, null, null, 86326, 65312, null, null, 82108, 74606, 84744, null, 75973 }, 97];

        yield return [new int?[] { 58750, 5251, 99292, null, 21737, 82732, null, null, 27975, null, null, 22974, 50407, null, null, 42408 }, 1237];

        yield return
        [
            new int?[] { 76456, 40516, 96920, 19054, 46569, 76863, 97691, 15270, 38160, 46403, 71994, null, 93507, null, null, 12072, 17584, 30293, 38291, 41573, null, 60777, 75436, 80348, 94065, 111, 14872, 15588, null, 22359, 30858, 38209, null, 41079, 45018, 55191, 65158, null, null, 77753, 88064, 93728, 94302, null, 9255, 13481, null, null, 15840, null, 29622, null, 31810, null, null, null, null, 42839, 45275, 50320, 57415, 65092, 71943, null, 79997, 81943, 91404, null, null, null, 95093, 833, 11331, null, null, null, 16009, 28690, 29936, 31778, 34645, null, null, null, null, 48466, 55081, null, 57933, 62729, null, 69048, null, 79571, null, null, 85207, 89737, null, null, 96779, 115, 6761, null, null, null, 17437, 27603, null, null, null, null, null, 32543, 34762, null, null, 54112, null, null, 59797, 62613, 62768, 67709, 70208, null, 79996, 84681, 86614, null, null, null, 96832, null, null, 3280, 9147, null, null, 25648, null, 32412, null, null, 35677, 52236, null, null, null, 60871, null, null, 64893, 66235, 68659, 69744, null, 79890, null, 84140, null, 85737, null, null, null, null, 3724, 8146, null, null, null, 31825, null, null, 36662 },
    1
        ];

        yield return
        [
            new int?[] { 0, null, 3, null, 6, null, 9, null, 12, null, 15, null, 18, null, 21, null, 24, null, 27, null, 30, null, 33, null, 36, null, 39, null, 42, null, 45, null, 48, null, 51, null, 54, null, 57, null, 60, null, 63, null, 66, null, 69, null, 72, null, 75, null, 78, null, 81, null, 84, null, 87, null, 90, null, 93, null, 96, null, 99, null, 102, null, 105, null, 108, null, 111, null, 114, null, 117, null, 120, null, 123, null, 126, null, 129, null, 132, null, 135, null, 138, null, 141, null, 144, null, 147, null, 150, null, 153, null, 156, null, 159, null, 162, null, 165, null, 168, null, 171, null, 174, null, 177, null, 180, null, 183, null, 186, null, 189, null, 192, null, 195, null, 198, null, 201, null, 204, null, 207, null, 210, null, 213, null, 216, null, 219, null, 222, null, 225, null, 228, null, 231, null, 234, null, 237, null, 240, null, 243, null, 246, null, 249, null, 252, null, 255, null, 258, null, 261, null, 264, null, 267, null, 270, null, 273, null, 276, null, 279, null, 282, null, 285, null, 288, null, 291, null, 294, null, 297 },
    3
        ];

        yield return [new int?[] { 8, 3, 10, 1, 6, null, 14, null, null, 4, 7, 13 }, 1];

        yield return [new int?[] { 100, 40, 160, 10, 70, 130, 190 }, 30];
    }
}