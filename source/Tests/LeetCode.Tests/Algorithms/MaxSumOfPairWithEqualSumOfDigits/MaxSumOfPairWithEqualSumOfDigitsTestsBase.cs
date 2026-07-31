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

using LeetCode.Algorithms.MaxSumOfPairWithEqualSumOfDigits;

namespace LeetCode.Tests.Algorithms.MaxSumOfPairWithEqualSumOfDigits;

public abstract class MaxSumOfPairWithEqualSumOfDigitsTestsBase<T> where T : IMaxSumOfPairWithEqualSumOfDigits, new()
{
    [TestMethod]
    [DataRow(new[] { 18, 43, 36, 13, 7 }, 54)]
    [DataRow(new[] { 18, 43, 36, 13, 7, 9 }, 54)]
    [DataRow(new[] { 10, 12, 19, 14 }, -1)]
    public void MaximumSum_GivenArrayOfNumbers_ReturnsLargestSumOfDigitPairs(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}