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

using LeetCode.Algorithms.ClosestPrimeNumbersInRange;

namespace LeetCode.Tests.Algorithms.ClosestPrimeNumbersInRange;

public abstract class ClosestPrimeNumbersInRangeTestsBase<T> where T : IClosestPrimeNumbersInRange, new()
{
    [TestMethod]
    [DataRow(10, 19, new[] { 11, 13 })]
    [DataRow(4, 6, new[] { -1, -1 })]
    [DataRow(1, 1, new[] { -1, -1 })]
    [DataRow(1, 2, new[] { -1, -1 })]
    [DataRow(1, 3, new[] { 2, 3 })]
    [DataRow(2, 3, new[] { 2, 3 })]
    [DataRow(2, 5, new[] { 2, 3 })]
    [DataRow(2, 7, new[] { 2, 3 })]
    [DataRow(3, 7, new[] { 3, 5 })]
    [DataRow(19, 31, new[] { 29, 31 })]
    [DataRow(1, 100, new[] { 2, 3 })]
    [DataRow(100, 110, new[] { 101, 103 })]
    [DataRow(1, 1000000, new[] { 2, 3 })]
    [DataRow(24, 28, new[] { -1, -1 })]
    [DataRow(5, 5, new[] { -1, -1 })]
    [DataRow(4, 4, new[] { -1, -1 })]
    [DataRow(11, 13, new[] { 11, 13 })]
    [DataRow(20, 37, new[] { 29, 31 })]
    [DataRow(3, 5, new[] { 3, 5 })]
    [DataRow(6, 10, new[] { -1, -1 })]
    public void ClosestPrimes_WithGivenRange_ReturnsClosestPrimePair(int left, int right, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ClosestPrimes(left, right);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}