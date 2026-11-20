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

using LeetCode.Algorithms.AverageOfLevelsInBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.AverageOfLevelsInBinaryTree;

public abstract class AverageOfLevelsInBinaryTreeTestsBase<T> where T : IAverageOfLevelsInBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void AverageOfLevels_WithBinaryTree_ReturnsAverageValueOfEachLevel(int?[] rootArray, double[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.AverageOfLevels(root);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, new[] { 3.0, 14.5, 11.0 }];

        yield return [new int?[] { 3, 9, 20, 15, 7 }, new[] { 3.0, 14.5, 11.0 }];

        yield return [new int?[] { 1 }, new[] { 1.0 }];

        yield return [new int?[] { 0 }, new[] { 0.0 }];

        yield return [new int?[] { -1 }, new[] { -1.0 }];

        yield return [new int?[] { 1, 2, 3 }, new[] { 1.0, 2.5 }];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4 }, new[] { 1.0, 2.0, 3.0, 4.0 }];

        yield return [new int?[] { 1, 2, null, 3, null, 4 }, new[] { 1.0, 2.0, 3.0, 4.0 }];

        yield return [new int?[] { 2147483647, 2147483647, 2147483647 }, new[] { 2147483647.0, 2147483647.0 }];

        yield return [new int?[] { -2147483648, -2147483648, -2147483648 }, new[] { -2147483648.0, -2147483648.0 }];

        yield return [new int?[] { 2147483647, -2147483648, 2147483647 }, new[] { 2147483647.0, -0.5 }];

        yield return [new int?[] { 5, 14, null, 1 }, new[] { 5.0, 14.0, 1.0 }];

        yield return [new int?[] { 2, 1, 3, null, 4, null, 5 }, new[] { 2.0, 2.0, 4.5 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new[] { 1.0, 2.5, 5.5, 11.5 }];

        yield return [new int?[] { -5, -3, -8, null, -1, -2, null, 7 }, new[] { -5.0, -5.5, -1.5, 7.0 }];

        yield return [new int?[] { 10, -10, 10, -10, 10, -10, 10 }, new[] { 10.0, 0.0, 0.0 }];

        yield return [new int?[] { 1, 1, null, 1, null, 1, null, 1 }, new[] { 1.0, 1.0, 1.0, 1.0, 1.0 }];

        yield return
        [
            new int?[]
            {
                4,
                -7,
                -3,
                null,
                null,
                -9,
                -3,
                9,
                -7,
                -4,
                null,
                6,
                null,
                -6,
                -6,
                null,
                null,
                0,
                6,
                5,
                null,
                9,
                null,
                null,
                -1,
                -4,
                null,
                null,
                null,
                -2
            },
            new[] { 4.0, -5.0, -6.0, -0.6666666666666666, -2.0, 5.0, -2.3333333333333335 }
        ];

        yield return
        [
            new int?[] { -6, -8, 5, 5, -4, null, null, 3, -10, -2, -3, -7, -10, null, -10, 2, 3, 6 },
            new[] { -6.0, -1.5, 0.5, -3.0, -2.6666666666666665 }
        ];

        yield return
        [
            new int?[]
            {
                -86,
                null,
                -57,
                71,
                -36,
                55,
                null,
                10,
                85,
                30,
                39,
                28,
                -91,
                -7,
                -19,
                8,
                34,
                null,
                null,
                null,
                null,
                null,
                -8,
                72,
                14,
                88,
                95,
                51,
                14,
                null,
                83,
                67,
                25
            },
            new[] { -86.0, -57.0, 17.5, 50.0, -3.3333333333333335, 43.285714285714285, 48.0 }
        ];

        yield return
        [
            new int?[]
            {
                -513,
                -733,
                236,
                189,
                null,
                null,
                -469,
                -608,
                -37,
                125,
                308,
                -526,
                777,
                -202,
                375,
                -674,
                210,
                null,
                686,
                -32,
                884,
                462,
                -126,
                640,
                974,
                799,
                -927,
                null,
                null,
                -107,
                751,
                38,
                175,
                198,
                -525,
                396,
                -942,
                240,
                -666,
                -332,
                852,
                -787,
                -568,
                174,
                -746
            },
            new[] { -513.0, -248.5, -140.0, -53.0, 92.28571428571429, 294.25, -225.5 }
        ];

        yield return
        [
            new int?[]
            {
                -1133664809,
                null,
                -1481882790,
                null,
                1795103241,
                1138864728,
                null,
                -1691429874,
                null,
                1317061808,
                -1316683993,
                1632305552,
                null,
                737452156,
                -1383880669,
                -857938010,
                1642040057,
                35959074,
                424825853,
                -1454616925,
                -1961775832,
                null,
                -674983023,
                -1307501887,
                569791751,
                -619202202,
                251380080,
                -1164496896,
                -1127784642,
                -1384956467,
                -1963611001,
                1953083128,
                1975116277,
                null,
                2001483798,
                1365489508,
                -239907257
            },
            new[]
            {
                -1133664809.0,
                -1481882790.0,
                1795103241.0,
                1138864728.0,
                -1691429874.0,
                188907.5,
                328625679.6666667,
                -361917630.5,
                -317560443.8181818,
                1042355349.6666666
            }
        ];

        yield return
        [
            new int?[]
            {
                9,
                5,
                8,
                null,
                3,
                2,
                null,
                3,
                1,
                0,
                6,
                6,
                null,
                2,
                7,
                null,
                null,
                3,
                2,
                4,
                3,
                3,
                null,
                3,
                6,
                5,
                2,
                5,
                9,
                9,
                5,
                null,
                4,
                5,
                null,
                2,
                null,
                0,
                5,
                0,
                6,
                9,
                7,
                null,
                null,
                3,
                null,
                null,
                7,
                5,
                4,
                1,
                5,
                0,
                1,
                null,
                5,
                5,
                8,
                null,
                4,
                null,
                null,
                null,
                7,
                null,
                null,
                8,
                0,
                null,
                4
            },
            new[] { 9.0, 6.5, 2.5, 2.5, 4.0, 4.444444444444445, 4.583333333333333, 4.266666666666667 }
        ];
    }
}