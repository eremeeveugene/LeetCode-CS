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

public abstract class NumberOfSubsequencesThatSatisfyTheGivenSumConditionTestsBase<T> where T : INumberOfSubsequencesThatSatisfyTheGivenSumCondition, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 5, 6, 7 }, 9, 4)]
    [DataRow(new[] { 3, 3, 6, 8 }, 10, 6)]
    [DataRow(new[] { 2, 3, 3, 4, 6, 7 }, 12, 61)]
    public void NumSubseq_WithIntegerArrayAndTarget_ReturnsCountOfSubsequencesWithMinPlusMaxLessOrEqualTarget(int[] nums, int target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSubseq(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}