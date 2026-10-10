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

using LeetCode.Algorithms.LowestCommonAncestorOfDeepestLeaves;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.LowestCommonAncestorOfDeepestLeaves;

public abstract class LowestCommonAncestorOfDeepestLeavesTestsBase<T> where T : ILowestCommonAncestorOfDeepestLeaves, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LcaDeepestLeaves_WithBinaryTree_ReturnsLowestCommonAncestorOfDeepestLeaves(int?[] rootArray, int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);
        var expectedResult = TreeNode.ToTreeNodeOrThrow(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.LcaDeepestLeaves(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 }, new int?[] { 2, 7, 4 }];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 0, 1, 3, null, 2 }, new int?[] { 2 }];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 1, 2 }, new int?[] { 2 }];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 2 }];

        yield return [new int?[] { 1, 2, 3 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 1, 2, 3, 4 }, new int?[] { 4 }];

        yield return [new int?[] { 1, 2, 3, null, 4 }, new int?[] { 4 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, new int?[] { 1, 2, 3, 4, 5, 6, 7 }];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 5 }, new int?[] { 1, 2, 3, 4, null, null, 5 }];

        yield return [new int?[] { 0, 1, 3, null, 2 }, new int?[] { 2 }];

        yield return [new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 }, new int?[] { 2, 7, 4 }];

        yield return [new int?[] { 1, 2, null, 3, null, 4, null, 5 }, new int?[] { 5 }];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4 }, new int?[] { 4 }];

        yield return [new int?[] { 5, 3, 8, 1, 4, 7, 9, null, 2 }, new int?[] { 2 }];

        yield return [new int?[] { 10, 20, 30, null, 40, 50 }, new int?[] { 10, 20, 30, null, 40, 50 }];

        yield return [new int?[] { 534, null, 424 }, new int?[] { 424 }];

        yield return [new int?[] { 296, 178, null, 784 }, new int?[] { 784 }];

        yield return [new int?[] { 513, 821, 325, null, null, 655, null, 866 }, new int?[] { 866 }];

        yield return [new int?[] { 962, 831, 879, null, null, 485, 655, 614, null, 145, null, null, 698 }, new int?[] { 698 }];

        yield return [new int?[] { 805, 256, 282, null, null, 197, 923, 618, 765, null, null, null, 568, 848, null, 566, null, null, 545, 132 }, new int?[] { 132 }];

        yield return [new int?[] { 429, null, 95, 789, 707, 859, 319, null, 491, 555, 673, 256, null, 545, 87, null, null, 651, null, 413, null, null, null, null, null, 980, null, 76, 556, null, null, 271, null, null, 247, null, null, 230 }, new int?[] { 230 }];

        yield return [new int?[] { 273, 438, 100, null, null, 530, 683, 15, 727, 716, 927, 483, 28, null, 26, 308, 930, 626, 59, null, 208, 115, null, 946, 870, null, null, null, 839, 101, 798, null, null, 796, 549, 466, null, null, null, null, null, null, 664, 777, 857, null, null, null, 840, null, null, null, null, null, 409, 227, null, null, null, 888, 813, 978, null, null, 30, 125, 61, null, 756, null, null, null, null, null, null, null, null, 552 }, new int?[] { 552 }];

        yield return [new int?[] { 233, 701, 244, 892, 411, 219, 795, 952, 894, 342, 387, 493, 100, 663, null, 101, 291, 666, null, null, 709, 497, 878, 877, null, 416, null, 547, 626, 31, null, 381, 8, null, 318, null, 334, 872, 177, null, 451, null, 217, 270, 160, 975, null, 152, null, 127, 150, null, null, null, null, null, null, 973, 203, 813, 504, null, 483, 661, 630, null, null, 298, 720, 266, null, null, null, null, null, 627, null, 269, 868, 395, 484, 359, 776, 56, 662, null, 544, 55, null, null, null, null, null, null, 337, null, 490, null, null, 997, 576, null, 814, null, 529, 188, 11, 303, 132, 375, null, null, null, null, 615, 828, null, null, 971, 531, null, null, 982, null, null, 73, null, 922, 116, null, null, null, 513, null, 508, null, 549, 34, null, 920, 822, null, 356, null, null, null, null, 726, null, null, null, null, 806, null, null, null, null, null, null, 827, 44, 262, 36, 785, null, null, null, null, 110, null, null, null, null, null, null, null, null, null, null, null, 457, null, null, 89, 281, null, 380, null, null, null, null, 301, null, null, null, null, 224 }, new int?[] { 395, 188, 11, null, 508, null, 549, 262, 36, 785, null, null, null, 89, 281, null, 380, 301, null, null, null, null, 224 }];
    }
}