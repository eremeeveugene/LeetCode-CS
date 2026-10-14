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

using LeetCode.Algorithms.MaximumProductPairWithTargetSum;

namespace LeetCode.Tests.Algorithms.MaximumProductPairWithTargetSum;

public abstract class MaximumProductPairWithTargetSumTestsBase<T> where T : IMaximumProductPairWithTargetSum, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 5, new[] { 2, 1 })]
    [DataRow(new[] { -3, -1, 4, 2 }, 1, new[] { 3, 1 })]
    [DataRow(new[] { 3, 3, 5 }, 6, new[] { -1, -1 })]
    [DataRow(new[] { 1, 2 }, 3, new[] { 1, 0 })]
    [DataRow(new[] { 2, 1 }, 3, new[] { 0, 1 })]
    [DataRow(new[] { 5, 5 }, 10, new[] { -1, -1 })]
    [DataRow(new[] { 1, 2 }, 10, new[] { -1, -1 })]
    [DataRow(new[] { 0, 0, 0 }, 0, new[] { -1, -1 })]
    [DataRow(new[] { -5, 5 }, 0, new[] { 1, 0 })]
    [DataRow(new[] { -5, 5, -1, 1 }, 0, new[] { 3, 2 })]
    [DataRow(new[] { 100, -100 }, 0, new[] { 0, 1 })]
    [DataRow(new[] { 100, -100, 50, -50 }, 0, new[] { 2, 3 })]
    [DataRow(new[] { 10, 20, 30, 40, 50 }, 60, new[] { 3, 1 })]
    [DataRow(new[] { -1, -2, -3, -4 }, -5, new[] { 1, 2 })]
    [DataRow(new[] { 7, 0, -7, 3 }, 7, new[] { 0, 1 })]
    [DataRow(new[] { 6, 1, 5, 2, 4, 3 }, 7, new[] { 4, 5 })]
    [DataRow(new[] { 9, -2 }, 7, new[] { 0, 1 })]
    [DataRow(new[] { -100, 100, 0 }, -100, new[] { 2, 0 })]
    [DataRow(new[] { 1, 3, 8 }, 9, new[] { 2, 0 })]
    [DataRow(new[] { 4, -6, 10, -2 }, 8, new[] { 2, 3 })]
    [DataRow(new[] { 3, 2, 1 }, 4, new[] { 0, 2 })]
    [DataRow(new[] { 2, 8, -3, 13 }, 10, new[] { 1, 0 })]
    [DataRow(new[] { -10, -20, -30 }, -50, new[] { 1, 2 })]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5, 6 }, 6, new[] { 4, 2 })]
    [DataRow(new[] { 100, 100 }, -100, new[] { -1, -1 })]
    public void MaxProductPair_WithInputNumsAndTarget_ReturnsIndicesOfMaximumProductPair(int[] nums, int target, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxProductPair(nums, target);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}