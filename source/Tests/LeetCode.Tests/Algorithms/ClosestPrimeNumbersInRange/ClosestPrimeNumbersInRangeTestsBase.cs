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