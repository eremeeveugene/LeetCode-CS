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

using LeetCode.Algorithms.CountTotalNumberOfColoredCells;

namespace LeetCode.Tests.Algorithms.CountTotalNumberOfColoredCells;

public abstract class CountTotalNumberOfColoredCellsTestSBase<T> where T : ICountTotalNumberOfColoredCells, new()
{
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(2, 5)]
    [DataRow(3, 13)]
    [DataRow(4, 25)]
    [DataRow(5, 41)]
    [DataRow(6, 61)]
    [DataRow(7, 85)]
    [DataRow(8, 113)]
    [DataRow(9, 145)]
    [DataRow(10, 181)]
    [DataRow(15, 421)]
    [DataRow(20, 761)]
    [DataRow(50, 4901)]
    [DataRow(100, 19801)]
    [DataRow(1000, 1998001)]
    [DataRow(10000, 199980001)]
    [DataRow(46341, 4294883881L)]
    [DataRow(50000, 4999900001L)]
    [DataRow(99999, 19999400005L)]
    [DataRow(100000, 19999800001L)]
    public void ColoredCells_WithGridSizeN_ReturnsTotalColoredCells(int n, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ColoredCells(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}