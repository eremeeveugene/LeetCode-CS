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

using LeetCode.Algorithms.CheckIfTwoChessboardSquaresHaveTheSameColor;

namespace LeetCode.Tests.Algorithms.CheckIfTwoChessboardSquaresHaveTheSameColor;

public abstract class CheckIfTwoChessboardSquaresHaveTheSameColorTestsBase<T> where T : ICheckIfTwoChessboardSquaresHaveTheSameColor, new()
{
    [TestMethod]
    [DataRow("a1", "c3", true)]
    [DataRow("a1", "h3", false)]
    [DataRow("a1", "a1", true)]
    [DataRow("a1", "b2", true)]
    [DataRow("a1", "b1", false)]
    [DataRow("h8", "a1", true)]
    [DataRow("h8", "a2", false)]
    [DataRow("d4", "f6", true)]
    [DataRow("d4", "e6", false)]
    [DataRow("c7", "f3", false)]
    [DataRow("c7", "h2", true)]
    [DataRow("g5", "e3", true)]
    [DataRow("g5", "e4", false)]
    [DataRow("a8", "h1", true)]
    [DataRow("b1", "c2", true)]
    [DataRow("b1", "a1", false)]
    [DataRow("h7", "g8", true)]
    [DataRow("c3", "c4", false)]
    [DataRow("a2", "a3", false)]
    [DataRow("b3", "d5", true)]
    public void CheckTwoChessboards_WithTwoValidCoordinates_ReturnsTrueIfSameColor(string coordinate1, string coordinate2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckTwoChessboards(coordinate1, coordinate2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}