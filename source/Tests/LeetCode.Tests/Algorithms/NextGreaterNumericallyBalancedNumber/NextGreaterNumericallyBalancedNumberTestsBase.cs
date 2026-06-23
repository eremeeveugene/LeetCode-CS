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

using LeetCode.Algorithms.NextGreaterNumericallyBalancedNumber;

namespace LeetCode.Tests.Algorithms.NextGreaterNumericallyBalancedNumber;

public abstract class NextGreaterNumericallyBalancedNumberTestsBase<T> where T : INextGreaterNumericallyBalancedNumber, new()
{
    [TestMethod]
    [DataRow(0, 1)]
    [DataRow(1, 22)]
    [DataRow(2, 22)]
    [DataRow(10, 22)]
    [DataRow(21, 22)]
    [DataRow(22, 122)]
    [DataRow(100, 122)]
    [DataRow(122, 212)]
    [DataRow(212, 221)]
    [DataRow(221, 333)]
    [DataRow(333, 1333)]
    [DataRow(999, 1333)]
    [DataRow(1000, 1333)]
    [DataRow(1333, 3133)]
    [DataRow(3000, 3133)]
    [DataRow(3133, 3313)]
    [DataRow(3313, 3331)]
    [DataRow(3331, 4444)]
    [DataRow(4444, 14444)]
    [DataRow(14444, 22333)]
    [DataRow(22333, 23233)]
    [DataRow(44441, 55555)]
    [DataRow(55555, 122333)]
    [DataRow(1000000, 1224444)]
    public void NextBeautifulNumber_WithInteger_ReturnsNextNumericallyBalancedNumber(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NextBeautifulNumber(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}