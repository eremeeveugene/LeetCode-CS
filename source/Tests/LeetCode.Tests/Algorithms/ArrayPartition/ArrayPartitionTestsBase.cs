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

using LeetCode.Algorithms.ArrayPartition;

namespace LeetCode.Tests.Algorithms.ArrayPartition;

public abstract class ArrayPartitionTestsBase<T> where T : IArrayPartition, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 3, 2 }, 4)]
    [DataRow(new[] { 6, 2, 6, 5, 1, 2 }, 9)]
    public void ArrayPairSum_GivenArrayOfIntegers_ReturnsMaximumSumOfMinPairsInEveryPair(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ArrayPairSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}