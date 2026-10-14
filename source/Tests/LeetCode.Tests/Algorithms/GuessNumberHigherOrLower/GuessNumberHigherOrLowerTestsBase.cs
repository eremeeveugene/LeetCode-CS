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

using LeetCode.Algorithms.GuessNumberHigherOrLower;

namespace LeetCode.Tests.Algorithms.GuessNumberHigherOrLower;

public abstract class GuessNumberHigherOrLowerTestsBase
{
    [TestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(2, 1, 1)]
    [DataRow(10, 6, 6)]
    [DataRow(2, 2, 2)]
    [DataRow(3, 1, 1)]
    [DataRow(3, 2, 2)]
    [DataRow(3, 3, 3)]
    [DataRow(4, 4, 4)]
    [DataRow(5, 3, 3)]
    [DataRow(7, 1, 1)]
    [DataRow(7, 7, 7)]
    [DataRow(10, 1, 1)]
    [DataRow(10, 10, 10)]
    [DataRow(100, 37, 37)]
    [DataRow(100, 100, 100)]
    [DataRow(1000, 999, 999)]
    [DataRow(1000, 1, 1)]
    [DataRow(65536, 65535, 65535)]
    [DataRow(1000000, 500000, 500000)]
    [DataRow(2147483647, 2147483647, 2147483647)]
    [DataRow(2147483647, 1, 1)]
    [DataRow(2147483647, 1073741824, 1073741824)]
    [DataRow(2147483647, 2147483646, 2147483646)]
    public void GuessNumber_WithRangeAndPickedValue_ReturnsPickedValue(int n, int pickedNumber, int expectedResult)
    {
        // Arrange
        var solution = GetSolution(pickedNumber);

        // Act
        var actualResult = solution.GuessNumber(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }


    protected abstract IGuessNumberHigherOrLower GetSolution(int pickedNumber);
}