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

using LeetCode.Algorithms.ExcelSheetColumnNumber;

namespace LeetCode.Tests.Algorithms.ExcelSheetColumnNumber;

public abstract class ExcelSheetColumnNumberTestsBase<T> where T : IExcelSheetColumnNumber, new()
{
    [TestMethod]
    [DataRow("A", 1)]
    [DataRow("AA", 27)]
    [DataRow("AAA", 703)]
    [DataRow("AAAA", 18279)]
    [DataRow("AAAAA", 475255)]
    [DataRow("Z", 26)]
    [DataRow("ZZ", 702)]
    [DataRow("ZZZ", 18278)]
    [DataRow("ZZZZ", 475254)]
    [DataRow("ZZZZZ", 12356630)]
    [DataRow("AB", 28)]
    [DataRow("ZY", 701)]
    [DataRow("B", 2)]
    [DataRow("Y", 25)]
    [DataRow("AZ", 52)]
    [DataRow("BA", 53)]
    [DataRow("ZA", 677)]
    [DataRow("AAB", 704)]
    [DataRow("CBA", 2081)]
    [DataRow("FXSHRXW", 2147483647)]
    public void TitleToNumber_WithExcelColumnTitle_ReturnsCorrespondingColumnNumber(string columnTitle, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TitleToNumber(columnTitle);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}