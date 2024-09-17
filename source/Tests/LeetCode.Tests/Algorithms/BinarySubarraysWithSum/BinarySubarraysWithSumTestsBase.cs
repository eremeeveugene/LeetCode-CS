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

using LeetCode.Algorithms.BinarySubarraysWithSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BinarySubarraysWithSum;

public abstract class BinarySubarraysWithSumTestsBase<T> where T : IBinarySubarraysWithSum, new()
{
    [TestMethod]
    [DataRow("[1, 0, 1, 0, 1]", 2, 4)]
    [DataRow("[0, 0, 0, 0, 0]", 0, 15)]
    public void NumSubarraysWithSum_GivenBinaryArrayAndGoal_ReturnsExpectedCount(string numsJsonArray, int goal,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.NumSubarraysWithSum(nums, goal);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}