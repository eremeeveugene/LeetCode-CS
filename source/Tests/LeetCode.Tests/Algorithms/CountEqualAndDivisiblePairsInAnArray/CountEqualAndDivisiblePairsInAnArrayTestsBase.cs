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

using LeetCode.Algorithms.CountEqualAndDivisiblePairsInAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountEqualAndDivisiblePairsInAnArray;

public abstract class CountEqualAndDivisiblePairsInAnArrayTestsBase<T>
    where T : ICountEqualAndDivisiblePairsInAnArray, new()
{
    [TestMethod]
    [DataRow("[3,1,2,2,2,1,3]", 2, 4)]
    [DataRow("[1,2,3,4]", 1, 0)]
    public void CountPairs_WithEqualElementsAndIndexProductDivisibleByK_ReturnsTheNumberOfPairs(string numsJson,
        int k, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountPairs(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}