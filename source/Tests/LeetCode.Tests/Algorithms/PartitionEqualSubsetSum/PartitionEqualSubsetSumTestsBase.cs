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

using LeetCode.Algorithms.PartitionEqualSubsetSum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.PartitionEqualSubsetSum;

public abstract class PartitionEqualSubsetSumTestsBase<T> where T : IPartitionEqualSubsetSum, new()
{
    [TestMethod]
    [DataRow("[1,5,11,5]", true)]
    [DataRow("[1,2,3,5]", false)]
    public void CanPartition_WithGivenIntegerArray_ReturnsWhetherItCanBePartitionedIntoEqualSumSubsets(
        string numsJson, bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CanPartition(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}