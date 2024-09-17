// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CanIWin;

namespace LeetCode.Tests.Algorithms.CanIWin;

public abstract class CanIWinTestsBase<T> where T : ICanIWin, new()
{
    [TestMethod]
    [DataRow(10, 11, false)]
    [DataRow(10, 0, true)]
    [DataRow(20, 0, true)]
    [DataRow(10, 1, true)]
    [DataRow(1, 1, true)]
    [DataRow(1, 2, false)]
    [DataRow(20, 210, false)]
    [DataRow(20, 211, false)]
    [DataRow(20, 1, true)]
    [DataRow(20, 20, true)]
    [DataRow(20, 19, true)]
    [DataRow(2, 3, false)]
    [DataRow(7, 16, true)]
    public void CanIWin_WithMaxChoosableIntegerAndDesiredTotal_ReturnsWhetherPlayerCanWin(int maxChoosableInteger,
        int desiredTotal, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanIWin(maxChoosableInteger, desiredTotal);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}