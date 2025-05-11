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

using LeetCode.Algorithms.GuessNumberHigherOrLower;

namespace LeetCode.Tests.Algorithms.GuessNumberHigherOrLower;

public abstract class GuessNumberHigherOrLowerTestsBase
{
    [TestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(2, 1, 1)]
    [DataRow(10, 6, 6)]
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