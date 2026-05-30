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

using LeetCode.Algorithms.CountNumberOfMaximumBitwiseORSubsets;

namespace LeetCode.Tests.Algorithms.CountNumberOfMaximumBitwiseORSubsets;

public abstract class CountNumberOfMaximumBitwiseORSubsetsTestsBase<T>
    where T : ICountNumberOfMaximumBitwiseORSubsets, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1 }, 2)]
    [DataRow(new[] { 2, 2, 2 }, 7)]
    [DataRow(new[] { 3, 2, 1, 5 }, 6)]
    public void CountMaxOrSubsets_GivenArrayOfIntegers_ReturnsNumberOfMaxOrSubsets(int[] nums,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountMaxOrSubsets(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}