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

using LeetCode.Algorithms.CountOddNumbersInAnIntervalRange;

namespace LeetCode.Tests.Algorithms.CountOddNumbersInAnIntervalRange;

public abstract class CountOddNumbersInAnIntervalRangeTestsBase<T> where T : ICountOddNumbersInAnIntervalRange, new()
{
    [TestMethod]
    [DataRow(3, 7, 3)]
    [DataRow(8, 10, 1)]
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