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

using LeetCode.Algorithms.FindThePivotInteger;

namespace LeetCode.Tests.Algorithms.FindThePivotInteger;

public abstract class FindThePivotIntegerTestsBase<T> where T : IFindThePivotInteger, new()
{
    [TestMethod]
    [DataRow(8, 6)]
    [DataRow(1, 1)]
    [DataRow(4, -1)]
    [DataRow(12, -1)]
    public void PivotInteger_WithInput_ReturnsExpectedPivotOrMinusOne(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PivotInteger(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}