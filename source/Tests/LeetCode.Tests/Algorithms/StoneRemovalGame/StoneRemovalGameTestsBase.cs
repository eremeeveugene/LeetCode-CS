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

using LeetCode.Algorithms.StoneRemovalGame;

namespace LeetCode.Tests.Algorithms.StoneRemovalGame;

public abstract class StoneRemovalGameTestsBase<T> where T : IStoneRemovalGame, new()
{
    [TestMethod]
    [DataRow(1, false)]
    [DataRow(2, false)]
    [DataRow(3, false)]
    [DataRow(4, false)]
    [DataRow(5, false)]
    [DataRow(6, false)]
    [DataRow(7, false)]
    [DataRow(8, false)]
    [DataRow(9, false)]
    [DataRow(10, true)]
    [DataRow(11, true)]
    [DataRow(12, true)]
    [DataRow(13, true)]
    [DataRow(14, true)]
    [DataRow(15, true)]
    [DataRow(16, true)]
    [DataRow(17, true)]
    [DataRow(18, true)]
    [DataRow(19, false)]
    [DataRow(20, false)]
    [DataRow(21, false)]
    [DataRow(22, false)]
    [DataRow(23, false)]
    [DataRow(24, false)]
    [DataRow(25, false)]
    [DataRow(26, false)]
    [DataRow(27, true)]
    [DataRow(28, true)]
    [DataRow(29, true)]
    [DataRow(30, true)]
    [DataRow(31, true)]
    [DataRow(32, true)]
    [DataRow(33, true)]
    [DataRow(34, false)]
    [DataRow(35, false)]
    [DataRow(36, false)]
    [DataRow(37, false)]
    [DataRow(38, false)]
    [DataRow(39, false)]
    [DataRow(40, true)]
    [DataRow(41, true)]
    [DataRow(42, true)]
    [DataRow(43, true)]
    [DataRow(44, true)]
    [DataRow(45, false)]
    [DataRow(46, false)]
    [DataRow(47, false)]
    [DataRow(48, false)]
    [DataRow(49, true)]
    [DataRow(50, true)]
    public void CanAliceWin_WithInputN_ReturnsTrueIfAliceWins(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanAliceWin(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}