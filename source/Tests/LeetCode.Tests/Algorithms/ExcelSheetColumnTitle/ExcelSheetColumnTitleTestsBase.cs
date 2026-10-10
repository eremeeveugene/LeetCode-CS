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

using LeetCode.Algorithms.ExcelSheetColumnTitle;

namespace LeetCode.Tests.Algorithms.ExcelSheetColumnTitle;

public abstract class ExcelSheetColumnTitleTestsBase<T> where T : IExcelSheetColumnTitle, new()
{
    [TestMethod]
    [DataRow(1, "A")]
    [DataRow(28, "AB")]
    [DataRow(701, "ZY")]
    [DataRow(2, "B")]
    [DataRow(26, "Z")]
    [DataRow(27, "AA")]
    [DataRow(52, "AZ")]
    [DataRow(53, "BA")]
    [DataRow(676, "YZ")]
    [DataRow(677, "ZA")]
    [DataRow(702, "ZZ")]
    [DataRow(703, "AAA")]
    [DataRow(18278, "ZZZ")]
    [DataRow(18279, "AAAA")]
    [DataRow(475254, "ZZZZ")]
    [DataRow(475255, "AAAAA")]
    [DataRow(12356630, "ZZZZZ")]
    [DataRow(12356631, "AAAAAA")]
    [DataRow(2147483647, "FXSHRXW")]
    [DataRow(1000, "ALL")]
    public void ConvertToTitle_WithColumnNumber_ReturnsCorrespondingExcelColumnTitle(int columnNumber, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ConvertToTitle(columnNumber);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}