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

using LeetCode.Algorithms.AddBinary;
using LeetCode.Algorithms.AddStrings;

namespace LeetCode.Tests.Algorithms.AddBinary;

public abstract class AddBinaryTestsBase<T> where T : IAddBinary, new()
{
    [TestMethod]
    [DataRow("11", "1", "100")]
    [DataRow("1010", "1011", "10101")]
    public void AddBinary_WithTwoBinaryStrings_ReturnsCorrectSum(string a, string b, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AddBinary(a, b);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}