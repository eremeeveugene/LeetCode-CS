// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumLimitOfBallsInBag;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumLimitOfBallsInBag;

public abstract class MinimumLimitOfBallsInBagTestsBase<T> where T : IMinimumLimitOfBallsInBag, new()
{
    [TestMethod]
    [DataRow("[9]", 2, 3)]
    [DataRow("[2,4,8,2]", 4, 2)]
    public void MinimumSize_WithNumsArrayAndMaxOperations_ReturnsMinimumPossibleSize(string numsJson,
        int maxOperations, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumSize(nums, maxOperations);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}