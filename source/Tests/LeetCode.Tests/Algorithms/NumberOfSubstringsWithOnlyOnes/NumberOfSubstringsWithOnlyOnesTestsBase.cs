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

using LeetCode.Algorithms.NumberOfSubstringsWithOnlyOnes;

namespace LeetCode.Tests.Algorithms.NumberOfSubstringsWithOnlyOnes;

public abstract class NumberOfSubstringsWithOnlyOnesTestsBase<T>
    where T : INumberOfSubstringsWithOnlyOnes, new()
{
    [TestMethod]
    [DataRow("0110111", 9)]
    [DataRow("101", 2)]
    [DataRow("111111", 21)]
    public void NumSub_WithBinaryString_ReturnsCountOfAllOneSubstrings(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSub(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}