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

using LeetCode.Algorithms.FindThePivotInteger;

namespace LeetCode.Tests.Algorithms.FindThePivotInteger;

public abstract class FindThePivotIntegerTestsBase<T> where T : IFindThePivotInteger, new()
{
    [TestMethod]
    [DataRow(8, 6)]
    [DataRow(1, 1)]
    [DataRow(4, -1)]
    [DataRow(12, -1)]
    [DataRow(2, -1)]
    [DataRow(3, -1)]
    [DataRow(5, -1)]
    [DataRow(6, -1)]
    [DataRow(9, -1)]
    [DataRow(10, -1)]
    [DataRow(35, -1)]
    [DataRow(49, 35)]
    [DataRow(50, -1)]
    [DataRow(288, 204)]
    [DataRow(289, -1)]
    [DataRow(1000, -1)]
    [DataRow(999, -1)]
    [DataRow(100, -1)]
    [DataRow(7, -1)]
    [DataRow(120, -1)]
    public void PivotInteger_WithRangeUpperBound_ReturnsPivotWhereLeftAndRightSumsAreEqualOrMinusOne(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PivotInteger(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}