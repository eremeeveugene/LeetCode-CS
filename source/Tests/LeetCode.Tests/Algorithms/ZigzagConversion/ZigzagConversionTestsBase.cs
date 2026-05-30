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

using LeetCode.Algorithms.ZigzagConversion;

namespace LeetCode.Tests.Algorithms.ZigzagConversion;

public abstract class ZigzagConversionTestsBase<T> where T : IZigzagConversion, new()
{
    [TestMethod]
    [DataRow("A", 1, "A")]
    [DataRow("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [DataRow("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    public void Convert_WithInputStringAndNumRows_ReturnsZigzagConvertedString(string s, int numRows, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Convert(s, numRows);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}