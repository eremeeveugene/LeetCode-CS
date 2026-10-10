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
    [DataRow(0, 0)]
    [DataRow(1, 1)]
    [DataRow(-1, -1)]
    [DataRow(10, 1)]
    [DataRow(-10, -1)]
    [DataRow(100, 1)]
    [DataRow(1000000000, 1)]
    [DataRow(-1000000000, -1)]
    [DataRow(int.MaxValue, 0)]
    [DataRow(1463847412, 2147483641)]
    [DataRow(1463847413, 0)]
    [DataRow(-1463847412, -2147483641)]
    [DataRow(-1563847412, 0)]
    [DataRow(901000, 109)]
    [DataRow(-901000, -109)]
    public void Reverse_WithSigned32BitInteger_ReturnsReversedIntegerOrZeroIfOverflow(int x, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Reverse(x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}