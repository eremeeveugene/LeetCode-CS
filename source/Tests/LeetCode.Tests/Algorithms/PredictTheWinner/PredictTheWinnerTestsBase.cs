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

using LeetCode.Algorithms.PredictTheWinner;

namespace LeetCode.Tests.Algorithms.PredictTheWinner;

public abstract class PredictTheWinnerTestsBase<T> where T : IPredictTheWinner, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 5, 2 }, false)]
    [DataRow(new[] { 1, 5, 233, 7 }, true)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 7 }, true)]
    [DataRow(new[] { 5, 3 }, true)]
    [DataRow(new[] { 3, 5 }, true)]
    [DataRow(new[] { 1, 1 }, true)]
    [DataRow(new[] { 0, 0 }, true)]
    [DataRow(new[] { 1, 100, 3 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, true)]
    [DataRow(new[] { 0, 0, 0, 0 }, true)]
    [DataRow(new[] { 5, 3, 4, 5 }, true)]
    [DataRow(new[] { 3, 7, 2, 3 }, true)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2 }, true)]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, true)]
    [DataRow(new[] { 1, 0 }, true)]
    [DataRow(new[] { 0, 1 }, true)]
    [DataRow(new[] { 4, 4 }, true)]
    [DataRow(new[] { 1, 2 }, true)]
    [DataRow(new[] { 1, 2, 3 }, true)]
    [DataRow(new[] { 3, 2, 1 }, true)]
    [DataRow(new[] { 9, 1, 1, 1, 9 }, true)]
    [DataRow(new[] { 1, 100, 1, 100, 1 }, false)]
    public void PredictTheWinner_WithGivenNums_ReturnsWhetherFirstPlayerWins(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PredictTheWinner(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}