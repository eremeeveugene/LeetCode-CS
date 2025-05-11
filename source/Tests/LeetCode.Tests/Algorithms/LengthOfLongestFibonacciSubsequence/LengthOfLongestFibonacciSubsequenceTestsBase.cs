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

using LeetCode.Algorithms.LengthOfLongestFibonacciSubsequence;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LengthOfLongestFibonacciSubsequence;

public abstract class LengthOfLongestFibonacciSubsequenceTestsBase<T>
    where T : ILengthOfLongestFibonacciSubsequence, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,5,6,7,8]", 5)]
    [DataRow("[1,3,7,11,12,14,18]", 3)]
    public void LenLongestFibSubseq_GivenIntegerArray_ReturnsMaxFibonacciSubsequenceLength(string arrJson,
        int expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int[]>.Parse(arrJson);

        var solution = new T();

        // Act
        var actualResult = solution.LenLongestFibSubseq(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}