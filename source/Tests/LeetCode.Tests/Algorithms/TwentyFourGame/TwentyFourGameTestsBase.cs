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

using LeetCode.Algorithms.TwentyFourGame;

namespace LeetCode.Tests.Algorithms.TwentyFourGame;

public abstract class TwentyFourGameTestsBase<T> where T : ITwentyFourGame, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 1, 8, 7 }, true)]
    [DataRow(new[] { 1, 2, 1, 2 }, false)]
    [DataRow(new[] { 1, 3, 4, 6 }, true)]
    [DataRow(new[] { 6, 6, 6, 6 }, true)]
    [DataRow(new[] { 1, 1, 1, 1 }, false)]
    [DataRow(new[] { 3, 3, 8, 8 }, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, true)]
    [DataRow(new[] { 6, 6, 4, 4 }, false)]
    [DataRow(new[] { 1, 5, 5, 5 }, true)]
    [DataRow(new[] { 2, 2, 2, 2 }, false)]
    [DataRow(new[] { 1, 1, 4, 6 }, true)]
    [DataRow(new[] { 1, 9, 1, 9 }, false)]
    [DataRow(new[] { 2, 3, 4, 4 }, true)]
    [DataRow(new[] { 1, 2, 8, 9 }, true)]
    [DataRow(new[] { 2, 6, 6, 6 }, true)]
    [DataRow(new[] { 1, 1, 8, 3 }, true)]
    [DataRow(new[] { 5, 5, 5, 1 }, true)]
    [DataRow(new[] { 6, 2, 3, 4 }, true)]
    [DataRow(new[] { 9, 9, 9, 9 }, false)]
    [DataRow(new[] { 4, 6, 6, 6 }, true)]
    public void JudgePoint24_WithCardsArray_ReturnsTrueIfExpressionEvaluatesToTwentyFour(int[] cards, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.JudgePoint24(cards);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}