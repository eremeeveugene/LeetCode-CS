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

using LeetCode.Algorithms.ExcelSheetColumnTitle;

namespace LeetCode.Tests.Algorithms.ExcelSheetColumnTitle;

public abstract class ExcelSheetColumnTitleTestsBase<T> where T : IExcelSheetColumnTitle, new()
{
    [TestMethod]
    [DataRow(1, "A")]
    [DataRow(28, "AB")]
    [DataRow(701, "ZY")]
    public void ConvertToTitle_GivenColumnNumber_ReturnsExpectedTitle(int columnNumber, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ConvertToTitle(columnNumber);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}