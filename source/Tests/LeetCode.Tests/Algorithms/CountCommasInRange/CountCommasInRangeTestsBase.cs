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

using LeetCode.Algorithms.CountCommasInRange;

namespace LeetCode.Tests.Algorithms.CountCommasInRange;

public abstract class CountCommasInRangeTestsBase<T> where T : ICountCommasInRange, new()
{
    [TestMethod]
    [DataRow(1002, 3)]
    [DataRow(998, 0)]
    [DataRow(1, 0)]
    [DataRow(2, 0)]
    [DataRow(9, 0)]
    [DataRow(10, 0)]
    [DataRow(99, 0)]
    [DataRow(100, 0)]
    [DataRow(500, 0)]
    [DataRow(997, 0)]
    [DataRow(999, 0)]
    [DataRow(1000, 1)]
    [DataRow(1001, 2)]
    [DataRow(1003, 4)]
    [DataRow(1009, 10)]
    [DataRow(1010, 11)]
    [DataRow(1099, 100)]
    [DataRow(1100, 101)]
    [DataRow(1999, 1000)]
    [DataRow(2000, 1001)]
    [DataRow(9999, 9000)]
    [DataRow(10000, 9001)]
    [DataRow(10001, 9002)]
    [DataRow(12345, 11346)]
    [DataRow(50000, 49001)]
    [DataRow(99999, 99000)]
    [DataRow(100000, 99001)]
    public void CountCommas_WithGivenUpperBound_ReturnsTotalNumberOfCommas(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountCommas(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}