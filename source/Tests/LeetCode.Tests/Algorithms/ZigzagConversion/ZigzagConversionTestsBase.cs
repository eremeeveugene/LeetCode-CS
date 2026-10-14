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
    [DataRow("AB", 1, "AB")]
    [DataRow("AB", 2, "AB")]
    [DataRow("AB", 5, "AB")]
    [DataRow("ABC", 2, "ACB")]
    [DataRow("ABCD", 2, "ACBD")]
    [DataRow("ABCDE", 2, "ACEBD")]
    [DataRow("ABCDEF", 3, "AEBDFC")]
    [DataRow("ABCDEFGHIJ", 1, "ABCDEFGHIJ")]
    [DataRow("ABCDEFGHIJ", 5, "AIBHJCGDFE")]
    [DataRow("ABCDEFGHIJ", 9, "ABCDEFGHJI")]
    [DataRow("ABCDEFGHIJ", 10, "ABCDEFGHIJ")]
    [DataRow("ABCDEFGHIJ", 2, "ACEGIBDFHJ")]
    [DataRow("ABCDEFGHIJ", 3, "AEIBDFHJCG")]
    [DataRow("abc,.def", 3, "a.b,dfce")]
    [DataRow("A.B,C", 2, "ABC.,")]
    [DataRow("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 4, "AGMSYBFHLNRTXZCEIKOQUWDJPV")]
    [DataRow("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 7, "AMYBLNXZCKOWDJPVEIQUFHRTGS")]
    [DataRow("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 25, "ABCDEFGHIJKLMNOPQRSTUVWXZY")]
    [DataRow("ZZZZZZ", 3, "ZZZZZZ")]
    [DataRow("abcdefghijklmnopqrstuvwxyzabcdefghij", 6, "akuebjltvdfcimswcgdhnrxbhegoqyaifpzj")]
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