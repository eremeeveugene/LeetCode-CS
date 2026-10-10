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

using LeetCode.Algorithms.MaximalScoreAfterApplyingKOperations;

namespace LeetCode.Tests.Algorithms.MaximalScoreAfterApplyingKOperations;

public abstract class MaximalScoreAfterApplyingKOperationsTestsBase<T> where T : IMaximalScoreAfterApplyingKOperations, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 10, 10, 10, 10 }, 5, 50L)]
    [DataRow(new[] { 1, 10, 3, 3, 3 }, 3, 17L)]
    [DataRow(new[] { 1 }, 1, 1L)]
    [DataRow(new[] { 1 }, 5, 5L)]
    [DataRow(new[] { 10 }, 1, 10L)]
    [DataRow(new[] { 10 }, 3, 16L)]
    [DataRow(new[] { 1, 1 }, 4, 4L)]
    [DataRow(new[] { 5, 5, 5 }, 6, 21L)]
    [DataRow(new[] { 1000000000 }, 1, 1000000000L)]
    [DataRow(new[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 }, 5, 5000000000L)]
    [DataRow(new[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 }, 10, 6666666670L)]
    [DataRow(new[] { 1000000000, 1 }, 7, 1499314134L)]
    [DataRow(new[] { 2, 3, 5, 7, 11 }, 8, 37L)]
    [DataRow(new[] { 9, 9, 9 }, 9, 39L)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 20, 78L)]
    [DataRow(new[] { 100, 1 }, 10, 157L)]
    [DataRow(new[] { 937, 130, 506, 230, 612, 50 }, 11, 3351L)]
    [DataRow(new[] { 554, 6, 735, 212, 275, 948, 195, 815, 345 }, 14, 5318L)]
    [DataRow(new[] { 519, 415, 946, 330, 195, 96 }, 24, 3722L)]
    [DataRow(new[] { 205, 614, 866, 718, 825, 919, 857, 146, 695, 771 }, 23, 9181L)]
    [DataRow(new[] { 395, 145, 225, 54, 333, 110 }, 2, 728L)]
    [DataRow(new[] { 465, 590, 891, 651, 498, 341, 165, 659, 507, 922 }, 14, 6763L)]
    [DataRow(new[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 }, 3000, 75000002600L)]
    public void MaxKelements_WithArrayAndKOperations_ReturnsMaximumScore(int[] nums, int k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxKelements(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}