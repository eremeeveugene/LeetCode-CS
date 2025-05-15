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

using LeetCode.Algorithms.LargestDivisibleSubset;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LargestDivisibleSubset;

public abstract class LargestDivisibleSubsetTestsBase<T> where T : ILargestDivisibleSubset, new()
{
    [TestMethod]
    [DataRow("[1,2,3]", "[1,2]")]
    [DataRow("[1,2,4,8]", "[1,2,4,8]")]
    public void LargestDivisibleSubset_WithArrayOfIntegers_ReturnsSubsetWhereEveryPairIsDivisible(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.LargestDivisibleSubset(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}