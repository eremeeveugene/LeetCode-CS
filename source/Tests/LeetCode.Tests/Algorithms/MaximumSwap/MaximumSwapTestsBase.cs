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

using LeetCode.Algorithms.MaximumSwap;

namespace LeetCode.Tests.Algorithms.MaximumSwap;

public abstract class MaximumSwapTestsBase<T> where T : IMaximumSwap, new()
{
    [TestMethod]
    [DataRow(2736, 7236)]
    [DataRow(9973, 9973)]
    [DataRow(0, 0)]
    [DataRow(5, 5)]
    [DataRow(10, 10)]
    [DataRow(12, 21)]
    [DataRow(21, 21)]
    [DataRow(98368, 98863)]
    [DataRow(1993, 9913)]
    [DataRow(100, 100)]
    [DataRow(1234, 4231)]
    [DataRow(4321, 4321)]
    [DataRow(9, 9)]
    [DataRow(99999999, 99999999)]
    [DataRow(10000000, 10000000)]
    [DataRow(100000000, 100000000)]
    [DataRow(1099, 9091)]
    [DataRow(99, 99)]
    [DataRow(1, 1)]
    [DataRow(19, 91)]
    public void MaximumSwap_GivenNumber_ReturnsMaxPossibleSwap(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumSwap(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}