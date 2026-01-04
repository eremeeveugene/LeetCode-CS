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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NumberOfSubsequencesThatSatisfyTheGivenSumCondition;

public abstract class NumberOfSubsequencesThatSatisfyTheGivenSumConditionTestsBase<T>
    where T : INumberOfSubsequencesThatSatisfyTheGivenSumCondition, new()
{
    [TestMethod]
    [DataRow("[3,5,6,7]", 9, 4)]
    [DataRow("[3,3,6,8]", 10, 6)]
    [DataRow("[2,3,3,4,6,7]", 12, 61)]
    public void NumSubseq_WithIntegerArrayAndTarget_ReturnsCountOfSubsequencesWithMinPlusMaxLessOrEqualTarget(
        string numsJson, int target, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumSubseq(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}