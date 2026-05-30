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

using LeetCode.Algorithms.CountSubarraysOfLengthThreeWithCondition;

namespace LeetCode.Tests.Algorithms.CountSubarraysOfLengthThreeWithCondition;

public abstract class CountSubarraysOfLengthThreeWithConditionTestsBase<T>
    where T : ICountSubarraysOfLengthThreeWithCondition, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 1, 4, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 0)]
    [DataRow(new[] { -1, -4, -1, 4 }, 1)]
    public void CountSubarrays_WithArrayContainingRepeatedElements_ReturnsNumberOfSubarraysLengthThree(
        int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}