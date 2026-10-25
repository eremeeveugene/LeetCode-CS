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

using LeetCode.Algorithms.ThreeFibonacciSum;

namespace LeetCode.Tests.Algorithms.ThreeFibonacciSum;

public abstract class ThreeFibonacciSumTestsBase<T> where T : IThreeFibonacciSum, new()
{
    [TestMethod]
    [DataRow(16, true)]
    [DataRow(8, false)]
    [DataRow(2, true)]
    [DataRow(1, false)]
    [DataRow(3, false)]
    [DataRow(4, true)]
    [DataRow(5, false)]
    [DataRow(6, true)]
    [DataRow(7, false)]
    [DataRow(10, true)]
    [DataRow(12, false)]
    [DataRow(13, false)]
    [DataRow(26, true)]
    [DataRow(34, false)]
    [DataRow(42, true)]
    [DataRow(68, true)]
    [DataRow(100, false)]
    [DataRow(110, true)]
    [DataRow(178, true)]
    [DataRow(288, true)]
    [DataRow(466, true)]
    [DataRow(754, true)]
    [DataRow(1220, true)]
    [DataRow(1222, false)]
    [DataRow(635622, true)]
    [DataRow(1664080, true)]
    [DataRow(866988874, true)]
    [DataRow(866988876, false)]
    [DataRow(999999999, false)]
    [DataRow(1000000000, false)]
    public void ThreeFibonacciSum_WithN_ReturnsTrueIfNIsSumOfThreeConsecutiveFibonacciTerms(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ThreeFibonacciSum(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}