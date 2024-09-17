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

using LeetCode.Algorithms.ReverseInteger;

namespace LeetCode.Tests.Algorithms.ReverseInteger;

public abstract class ReverseIntegerTestsBase<T> where T : IReverseInteger, new()
{
    [TestMethod]
    [DataRow(123, 321)]
    [DataRow(-123, -321)]
    [DataRow(120, 21)]
    [DataRow(1534236469, 0)]
    [DataRow(int.MinValue, 0)]
    public void Reverse_IntegerInput_ReturnsExpectedReversedInteger(int x, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Reverse(x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}