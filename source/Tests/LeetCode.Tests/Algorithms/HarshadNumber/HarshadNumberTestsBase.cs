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

using LeetCode.Algorithms.HarshadNumber;

namespace LeetCode.Tests.Algorithms.HarshadNumber;

public abstract class HarshadNumberTestsBase<T> where T : IHarshadNumber, new()
{
    [TestMethod]
    [DataRow(18, 9)]
    [DataRow(23, -1)]
    [DataRow(0, -1)]
    public void SumOfTheDigitsOfHarshadNumber_GivenInputNumber_ReturnsSumOrMinusOne(int x, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOfTheDigitsOfHarshadNumber(x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}