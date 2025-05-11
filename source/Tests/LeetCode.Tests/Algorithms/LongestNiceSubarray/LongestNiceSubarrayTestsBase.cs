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

using LeetCode.Algorithms.LongestNiceSubarray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LongestNiceSubarray;

public abstract class LongestNiceSubarrayTestsBase<T> where T : ILongestNiceSubarray, new()
{
    [TestMethod]
    [DataRow("[1,3,8,48,10]", 3)]
    [DataRow("[3,1,5,11,13]", 1)]
    [DataRow("[8,4,2,1]", 4)]
    public void LongestNiceSubarray_WithGivenIntegerArray_ReturnsLengthOfLongestNiceSubarray(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.LongestNiceSubarray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}