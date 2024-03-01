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

using LeetCode.Algorithms.MaximumOddBinaryNumber;

namespace LeetCode.Tests.Algorithms.MaximumOddBinaryNumber;

public abstract class MaximumOddBinaryNumberTestsBase<T> where T : IMaximumOddBinaryNumber, new()
{
    [TestMethod]
    [DataRow("010", "001")]
    [DataRow("0101", "1001")]
    public void MaximumOddBinaryNumber_GivenBinaryString_ReturnsMaximumOddBinaryNumber(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumOddBinaryNumber(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}