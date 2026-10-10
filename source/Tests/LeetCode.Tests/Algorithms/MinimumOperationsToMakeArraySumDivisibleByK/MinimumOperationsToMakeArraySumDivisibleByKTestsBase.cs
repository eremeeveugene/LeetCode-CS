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

using LeetCode.Algorithms.MinimumOperationsToMakeArraySumDivisibleByK;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeArraySumDivisibleByK;

public abstract class MinimumOperationsToMakeArraySumDivisibleByKTestsBase<T> where T : IMinimumOperationsToMakeArraySumDivisibleByK, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 9, 7 }, 5, 4)]
    [DataRow(new[] { 4, 1, 3 }, 4, 0)]
    [DataRow(new[] { 3, 2 }, 6, 5)]
    [DataRow(new[] { 1 }, 1, 0)]
    [DataRow(new[] { 1 }, 2, 1)]
    [DataRow(new[] { 5 }, 5, 0)]
    [DataRow(new[] { 100 }, 100, 0)]
    [DataRow(new[] { 100 }, 99, 1)]
    [DataRow(new[] { 1, 1, 1 }, 3, 0)]
    [DataRow(new[] { 1, 1, 1 }, 2, 1)]
    [DataRow(new[] { 1000, 1000, 1000 }, 100, 0)]
    [DataRow(new[] { 7, 8, 9 }, 10, 4)]
    [DataRow(new[] { 2, 4, 6, 8 }, 7, 6)]
    [DataRow(new[] { 99, 98, 97 }, 100, 94)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 7, 6)]
    [DataRow(new[] { 628, 383, 274, 142, 191, 888, 693, 7 }, 44, 38)]
    [DataRow(new[] { 475, 920, 620, 83, 343, 568, 959, 632, 717 }, 6, 1)]
    [DataRow(new[] { 389, 174, 721, 969, 463, 975, 743, 433, 161, 173, 244, 53 }, 15, 8)]
    [DataRow(new[] { 519, 893, 947 }, 76, 3)]
    [DataRow(new[] { 793, 705 }, 50, 48)]
    [DataRow(new[] { 909, 105, 942, 299, 210, 691, 230, 744, 813, 432, 911, 90 }, 99, 40)]
    [DataRow(new[] { 934, 215, 407, 288, 350 }, 6, 4)]
    [DataRow(new[] { 726, 908, 6, 901 }, 53, 50)]
    public void MinOperations_WithNumArrayAndTargetValueK_ReturnsMinimumOperationCount(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}