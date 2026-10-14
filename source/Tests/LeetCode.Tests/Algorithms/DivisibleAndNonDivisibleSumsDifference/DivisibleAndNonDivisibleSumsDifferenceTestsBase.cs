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

using LeetCode.Algorithms.DivisibleAndNonDivisibleSumsDifference;

namespace LeetCode.Tests.Algorithms.DivisibleAndNonDivisibleSumsDifference;

public abstract class DivisibleAndNonDivisibleSumsDifferenceTestsBase<T> where T : IDivisibleAndNonDivisibleSumsDifference, new()
{
    [TestMethod]
    [DataRow(10, 3, 19)]
    [DataRow(5, 6, 15)]
    [DataRow(5, 1, -15)]
    [DataRow(1, 1, -1)]
    [DataRow(1, 2, 1)]
    [DataRow(2, 2, -1)]
    [DataRow(3, 3, 0)]
    [DataRow(4, 2, -2)]
    [DataRow(6, 3, 3)]
    [DataRow(7, 7, 14)]
    [DataRow(8, 9, 36)]
    [DataRow(10, 10, 35)]
    [DataRow(10, 5, 25)]
    [DataRow(10, 2, -5)]
    [DataRow(20, 4, 90)]
    [DataRow(100, 7, 3580)]
    [DataRow(100, 100, 4850)]
    [DataRow(100, 1, -5050)]
    [DataRow(1000, 1, -500500)]
    [DataRow(1000, 1000, 498500)]
    public void DifferenceOfSums_WithRangeAndDivisor_ReturnsDifferenceBetweenNonDivisibleAndDivisibleSums(int n, int m, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DifferenceOfSums(n, m);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}