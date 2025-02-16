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

using LeetCode.Algorithms.ContinuousSubarrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ContinuousSubarrays;

public abstract class ContinuousSubarraysTestsBase<T> where T : IContinuousSubarrays, new()
{
    [TestMethod]
    [DataRow("[5,4,2,4]", 8)]
    [DataRow("[1,2,3]", 6)]
    public void ContinuousSubarrays_GivenArrayOfIntegers_ReturnsCountOfValidSubarrays(string numsJsonArray,
        long expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ContinuousSubarrays(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}