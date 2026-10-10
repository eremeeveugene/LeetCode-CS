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

using LeetCode.Algorithms.NumberOfSubsequencesThatSatisfyTheGivenSumCondition;

namespace LeetCode.Tests.Algorithms.NumberOfSubsequencesThatSatisfyTheGivenSumCondition;

public abstract class NumberOfSubsequencesThatSatisfyTheGivenSumConditionTestsBase<T>
    where T : INumberOfSubsequencesThatSatisfyTheGivenSumCondition, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 5, 6, 7 }, 9, 4)]
    [DataRow(new[] { 3, 3, 6, 8 }, 10, 6)]
    [DataRow(new[] { 2, 3, 3, 4, 6, 7 }, 12, 61)]
    [DataRow(new[] { 1 }, 2, 1)]
    [DataRow(new[] { 1 }, 1, 0)]
    [DataRow(new[] { 5 }, 10, 1)]
    [DataRow(new[] { 1, 1 }, 2, 3)]
    [DataRow(new[] { 2, 3, 4 }, 1, 0)]
    [DataRow(new[] { 10, 10, 10 }, 20, 7)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 6, 21)]
    [DataRow(new[] { 1000000, 1000000 }, 2000000, 3)]
    [DataRow(new[] { 1000000, 999999, 1 }, 1000000, 2)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 10, 31)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, 15)]
    [DataRow(new[] { 14, 4, 12, 4, 10, 8, 17, 11, 6 }, 9, 3)]
    [DataRow(new[] { 4, 5, 17, 1, 12, 17 }, 21, 50)]
    [DataRow(new[] { 4, 3, 8, 3, 10, 9 }, 15, 56)]
    [DataRow(new[] { 2, 13, 5, 20, 20, 5 }, 6, 1)]
    [DataRow(new[] { 48, 21, 46, 6, 30, 33, 7, 12, 2, 32, 49, 13, 30, 37, 44, 41, 50, 8, 20, 11, 25, 2, 48, 32, 39, 25, 4, 8, 11, 4, 34, 10, 30, 38, 13, 3, 20, 17, 37, 26 }, 100, 511620082)]
    [DataRow(new[] { 669457, 60173, 515435, 809736, 145601, 383045, 606955, 953493, 678490, 229984, 274808, 264063, 115780, 937908, 279726, 263647, 579542, 614260, 526475, 213537, 767265, 489619, 717172, 983078, 775622, 660305, 207250, 736222, 956861, 461483, 633179, 509962, 558634, 577662, 990621 }, 1000000, 532429323)]
    public void NumSubseq_WithIntegerArrayAndTarget_ReturnsCountOfSubsequencesWithMinPlusMaxLessOrEqualTarget(
        int[] nums,
        int target,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSubseq(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}