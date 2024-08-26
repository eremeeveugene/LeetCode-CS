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

using LeetCode.Algorithms.CountPairsWhoseSumIsLessThanTarget;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountPairsWhoseSumIsLessThanTarget;

public abstract class CountPairsWhoseSumIsLessThanTargetTestsBase<T>
    where T : ICountPairsWhoseSumIsLessThanTarget, new()
{
    [TestMethod]
    [DataRow("[-1, 1, 2, 3, 1]", 2, 3)]
    [DataRow("[-6, 2, 5, -2, -7, -1, 3]", -2, 10)]
    public void CountPairs_WithNumsAndTarget_ReturnsExpectedPairCount(string numsJsonArray, int target,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToList(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CountPairs(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}