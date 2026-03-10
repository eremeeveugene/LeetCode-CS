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

using LeetCode.Algorithms.SmallestPairWithDifferentFrequencies;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SmallestPairWithDifferentFrequencies;

public abstract class SmallestPairWithDifferentFrequenciesTestsBase<T>
    where T : ISmallestPairWithDifferentFrequencies, new()
{
    [TestMethod]
    [DataRow("[1,1,2,2,3,4]", "[1,3]")]
    [DataRow("[1,5]", "[-1,-1]")]
    [DataRow("[7]", "[-1,-1]")]
    public void MinDistinctFreqPair_WithInputNums_ReturnsSmallestPairWithDifferentFrequencies(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinDistinctFreqPair(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}