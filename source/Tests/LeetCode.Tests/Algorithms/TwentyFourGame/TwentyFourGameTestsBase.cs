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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TwentyFourGame;

public abstract class TwentyFourGameTestsBase<T> where T : ITwentyFourGame, new()
{
    [TestMethod]
    [DataRow("[4,1,8,7]", true)]
    [DataRow("[1,2,1,2]", false)]
    [DataRow("[1,3,4,6]", true)]
    public void JudgePoint24_WithCardsArray_ReturnsTrueIfExpressionEvaluatesToTwentyFour(string cardsJson,
        bool expectedResult)
    {
        // Arrange
        var cards = JsonHelper.Parse<int[]>(cardsJson);

        var solution = new T();

        // Act
        var actualResult = solution.JudgePoint24(cards);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}