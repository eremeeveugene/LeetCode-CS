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

using LeetCode.Algorithms.CountSubarraysOfLengthThreeWithCondition;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountSubarraysOfLengthThreeWithCondition;

public abstract class CountSubarraysOfLengthThreeWithConditionTestsBase<T>
    where T : ICountSubarraysOfLengthThreeWithCondition, new()
{
    [TestMethod]
    [DataRow("[1,2,1,4,1]", 1)]
    [DataRow("[1,1,1]", 0)]
    [DataRow("[-1,-4,-1,4]", 1)]
    public void CountSubarrays_WithArrayContainingRepeatedElements_ReturnsNumberOfSubarraysLengthThree(
        string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}