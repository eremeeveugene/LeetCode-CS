// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MaximalScoreAfterApplyingKOperations;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximalScoreAfterApplyingKOperations;

public abstract class MaximalScoreAfterApplyingKOperationsTestsBase<T>
    where T : IMaximalScoreAfterApplyingKOperations, new()
{
    [TestMethod]
    [DataRow("[10,10,10,10,10]", 5, 50)]
    [DataRow("[1,10,3,3,3]", 3, 17)]
    public void MaxKelements_WithArrayAndK_ReturnsCorrectMaxSum(string numsJsonArray, int k, long expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxKelements(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}