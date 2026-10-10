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

using LeetCode.Algorithms.SpiralMatrix4;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SpiralMatrix4;

public abstract class SpiralMatrix4TestsBase<T> where T : ISpiralMatrix4, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SpiralMatrix_WithDimensionsAndLinkedList_FillsMatrixInClockwiseSpiralOrderOrMinusOne(
        int m,
        int n,
        int[] headArray,
        int[][] expectedResult)
    {
        // Arrange
        var head = ListNode.ToListNodeOrThrow(headArray);

        var solution = new T();

        // Act
        var actualResult = solution.SpiralMatrix(m, n, head);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            3,
            5,
            new[] { 3, 0, 2, 6, 8, 1, 7, 9, 4, 2, 5, 5, 0 },
            new[] { new[] { 3, 0, 2, 6, 8 }, new[] { 5, 0, -1, -1, 1 }, new[] { 5, 2, 4, 9, 7 } }
        ];

        yield return [1, 4, new[] { 0, 1, 2 }, new[] { new[] { 0, 1, 2, -1 } }];

        yield return
        [
            4,
            4,
            new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
            new[] { new[] { 1, 2, 3, 4 }, new[] { 12, 13, 14, 5 }, new[] { 11, 16, 15, 6 }, new[] { 10, 9, 8, 7 } }
        ];
        yield return [1, 1, new[] { 0 }, new[] { new[] { 0 } }];
        yield return [1, 1, new[] { 1000 }, new[] { new[] { 1000 } }];
        yield return [1, 2, new[] { 963, 509 }, new[] { new[] { 963, 509 } }];
        yield return [2, 1, new[] { 487, 584 }, new[] { new[] { 487 }, new[] { 584 } }];
        yield return [1, 5, new[] { 614, 733, 27 }, new[] { new[] { 614, 733, 27, -1, -1 } }];
        yield return [5, 1, new[] { 978, 464, 671, 771, 535 }, new[] { new[] { 978 }, new[] { 464 }, new[] { 671 }, new[] { 771 }, new[] { 535 } }];
        yield return [2, 2, new[] { 559, 665, 928 }, new[] { new[] { 559, 665 }, new[] { -1, 928 } }];
        yield return [3, 3, new[] { 947, 958, 697, 580, 216, 537, 598, 480, 759 }, new[] { new[] { 947, 958, 697 }, new[] { 480, 759, 580 }, new[] { 598, 537, 216 } }];
        yield return [3, 3, new[] { 942, 804, 658, 470 }, new[] { new[] { 942, 804, 658 }, new[] { -1, -1, 470 }, new[] { -1, -1, -1 } }];
        yield return [2, 5, new[] { 78, 601, 823, 969, 953, 627, 632, 292, 83, 2 }, new[] { new[] { 78, 601, 823, 969, 953 }, new[] { 2, 83, 292, 632, 627 } }];
        yield return [5, 2, new[] { 324, 172, 649, 189, 799, 914, 456 }, new[] { new[] { 324, 172 }, new[] { -1, 649 }, new[] { -1, 189 }, new[] { -1, 799 }, new[] { 456, 914 } }];
        yield return [4, 3, new[] { 194, 730, 967, 338, 865, 791, 487, 341, 86, 227, 649, 312 }, new[] { new[] { 194, 730, 967 }, new[] { 227, 649, 338 }, new[] { 86, 312, 865 }, new[] { 341, 487, 791 } }];
        yield return [3, 4, new[] { 268, 2, 338, 868, 503 }, new[] { new[] { 268, 2, 338, 868 }, new[] { -1, -1, -1, 503 }, new[] { -1, -1, -1, -1 } }];
        yield return [6, 6, new[] { 259, 210, 41, 478, 515, 648, 204, 481, 770, 208, 408, 867, 967, 56, 811, 574, 765, 376, 147, 401 }, new[] { new[] { 259, 210, 41, 478, 515, 648 }, new[] { 401, -1, -1, -1, -1, 204 }, new[] { 147, -1, -1, -1, -1, 481 }, new[] { 376, -1, -1, -1, -1, 770 }, new[] { 765, -1, -1, -1, -1, 208 }, new[] { 574, 811, 56, 967, 867, 408 } }];
        yield return [1, 10, new[] { 529, 600, 549, 127, 606, 939, 115, 444, 415, 425 }, new[] { new[] { 529, 600, 549, 127, 606, 939, 115, 444, 415, 425 } }];
        yield return [10, 1, new[] { 130 }, new[] { new[] { 130 }, new[] { -1 }, new[] { -1 }, new[] { -1 }, new[] { -1 }, new[] { -1 }, new[] { -1 }, new[] { -1 }, new[] { -1 }, new[] { -1 } }];
        yield return [7, 5, new[] { 547, 772, 211, 664, 420, 176, 780, 750, 257, 979, 533, 106, 789, 181, 56, 288, 554, 287, 234, 471, 62, 249, 135, 977, 791, 35, 702, 588, 270, 409, 687, 546, 300, 648, 498 }, new[] { new[] { 547, 772, 211, 664, 420 }, new[] { 471, 62, 249, 135, 176 }, new[] { 234, 546, 300, 977, 780 }, new[] { 287, 687, 648, 791, 750 }, new[] { 554, 409, 498, 35, 257 }, new[] { 288, 270, 588, 702, 979 }, new[] { 56, 181, 789, 106, 533 } }];
    }
}