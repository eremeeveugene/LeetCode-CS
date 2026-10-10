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

using LeetCode.Algorithms.PushDominoes;

namespace LeetCode.Tests.Algorithms.PushDominoes;

public abstract class PushDominoesTestsBase<T> where T : IPushDominoes, new()
{
    [TestMethod]
    [DataRow("RR.L", "RR.L")]
    [DataRow(".L.R...LR..L..", "LL.RR.LLRRLL..")]
    [DataRow("L", "L")]
    [DataRow("R", "R")]
    [DataRow(".", ".")]
    [DataRow("LR", "LR")]
    [DataRow("RL", "RL")]
    [DataRow(".L", "LL")]
    [DataRow("R.", "RR")]
    [DataRow("..", "..")]
    [DataRow("L.R", "L.R")]
    [DataRow("R.L", "R.L")]
    [DataRow("R..L", "RRLL")]
    [DataRow("R...L", "RR.LL")]
    [DataRow(".L.R", "LL.R")]
    [DataRow("L...", "L...")]
    [DataRow("...R", "...R")]
    [DataRow("R.R.L", "RRR.L")]
    [DataRow("LL.RR", "LL.RR")]
    [DataRow("..R..L..", "..RRLL..")]
    [DataRow("L.L.R.R.", "LLL.RRRR")]
    [DataRow("R.L.R.L.", "R.L.R.L.")]
    [DataRow(".R.L.", ".R.L.")]
    [DataRow("R...", "RRRR")]
    [DataRow("...L", "LLLL")]
    [DataRow("RL.RL", "RL.RL")]
    [DataRow("L..R..L..R", "L..RRLL..R")]
    [DataRow("..R.L..", "..R.L..")]
    [DataRow("R.....L", "RRR.LLL")]
    [DataRow(".R....L.", ".RRRLLL.")]
    [DataRow("LRLRLR", "LRLRLR")]
    [DataRow(".......", ".......")]
    public void PushDominoes_WithInitialState_ReturnsFinalDominoState(string dominoes, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PushDominoes(dominoes);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void PushDominoes_WithMaxLengthState_ReturnsFinalDominoState()
    {
        // Arrange
        var solution = new T();

        var dominoes = new char[100000];
        var expectedResult = new char[100000];

        for (var i = 0; i < dominoes.Length; i++)
        {
            dominoes[i] = '.';
            expectedResult[i] = i < 50000 ? 'R' : 'L';
        }

        dominoes[0] = 'R';
        dominoes[99999] = 'L';

        // Act
        var actualResult = solution.PushDominoes(new string(dominoes));

        // Assert
        Assert.AreEqual(new string(expectedResult), actualResult);
    }
}