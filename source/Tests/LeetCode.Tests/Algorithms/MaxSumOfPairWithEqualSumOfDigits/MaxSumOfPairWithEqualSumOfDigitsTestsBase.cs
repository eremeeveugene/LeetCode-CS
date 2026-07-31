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
    [DataRow(new[] { 1, 2, 3, 4, 5 }, -1)]
    [DataRow(new[] { 11, 2, 20 }, 31)]
    [DataRow(new[] { 9, 18, 27 }, 45)]
    [DataRow(new[] { 15, 24, 33, 42 }, 75)]
    [DataRow(new[] { 5, 50, 500 }, 550)]
    [DataRow(new[] { 12, 21 }, 33)]
    [DataRow(new[] { 19, 91, 28, 82 }, 173)]
    [DataRow(new[] { 100, 200, 300 }, -1)]
    [DataRow(new[] { 1, 10, 100, 1000 }, 1100)]
    [DataRow(new[] { 23, 32, 41, 14, 50 }, 91)]
    [DataRow(new[] { 99, 198, 297 }, 495)]
    [DataRow(new[] { 7, 16, 25, 34, 43, 52, 61, 70 }, 131)]
    [DataRow(new[] { 3, 30, 300, 3000 }, 3300)]
    [DataRow(new[] { 1, 2 }, -1)]
    [DataRow(new[] { 11, 22, 33 }, -1)]
    [DataRow(new[] { 1, 19 }, -1)]
    [DataRow(new[] { 123, 321, 213 }, 534)]
    [DataRow(new[] { 45, 54 }, 99)]
    [DataRow(new[] { 6, 60, 600, 6000, 60000 }, 66000)]
    [DataRow(new[] { 8 }, -1)]
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