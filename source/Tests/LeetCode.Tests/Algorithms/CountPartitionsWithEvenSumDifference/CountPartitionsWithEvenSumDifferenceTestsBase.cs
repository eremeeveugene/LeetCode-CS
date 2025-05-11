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

using LeetCode.Algorithms.CountPartitionsWithEvenSumDifference;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountPartitionsWithEvenSumDifference;

public abstract class CountPartitionsWithEvenSumDifferenceTestsBase<T>
    where T : ICountPartitionsWithEvenSumDifference, new()
{
    [TestMethod]
    [DataRow("[1,2,2]", 0)]
    [DataRow("[2,4,6,8]", 3)]
    [DataRow("[10,10,3,7,6]", 4)]
    public void CountPartitions_WithIntegerArray_ReturnsNumberOfValidPartitions(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountPartitions(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}