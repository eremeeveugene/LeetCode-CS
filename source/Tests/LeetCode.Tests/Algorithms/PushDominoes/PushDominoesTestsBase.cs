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

using LeetCode.Algorithms.PushDominoes;

namespace LeetCode.Tests.Algorithms.PushDominoes;

public abstract class PushDominoesTestsBase<T> where T : IPushDominoes, new()
{
    [TestMethod]
    [DataRow("RR.L", "RR.L")]
    [DataRow(".L.R...LR..L..", "LL.RR.LLRRLL..")]
    public void PushDominoes_WithInitialState_ReturnsFinalDominoState(string dominoes, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PushDominoes(dominoes);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}