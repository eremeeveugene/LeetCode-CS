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

using LeetCode.Algorithms.CountOddNumbersInAnIntervalRange;

namespace LeetCode.Tests.Algorithms.CountOddNumbersInAnIntervalRange;

public abstract class CountOddNumbersInAnIntervalRangeTestsBase<T> where T : ICountOddNumbersInAnIntervalRange, new()
{
    [TestMethod]
    [DataRow(3, 7, 3)]
    [DataRow(8, 10, 1)]
    [DataRow(1, 1, 1)]
    [DataRow(2, 2, 0)]
    [DataRow(0, 0, 0)]
    [DataRow(0, 1, 1)]
    [DataRow(1, 2, 1)]
    [DataRow(2, 3, 1)]
    [DataRow(1, 10, 5)]
    [DataRow(0, 10, 5)]
    [DataRow(4, 4, 0)]
    [DataRow(5, 5, 1)]
    [DataRow(7, 9, 2)]
    [DataRow(10, 10, 0)]
    [DataRow(100, 200, 50)]
    [DataRow(1, 1000000000, 500000000)]
    [DataRow(0, 1000000000, 500000000)]
    [DataRow(999999998, 999999999, 1)]
    [DataRow(3, 4, 1)]
    [DataRow(13, 27, 8)]
    public void CountOdds_GivenLowAndHighRange_ReturnsCountOfOddNumbers(int low, int high, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountOdds(low, high);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}