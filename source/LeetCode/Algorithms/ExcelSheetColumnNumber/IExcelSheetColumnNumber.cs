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

namespace LeetCode.Algorithms.ExcelSheetColumnNumber;

/// <summary>
///     https://leetcode.com/problems/excel-sheet-column-number/description/
/// </summary>
public interface IExcelSheetColumnNumber
{
    /// <summary>
    ///     Converts the Excel sheet column title <paramref name="columnTitle" /> to its corresponding column number.
    /// </summary>
    /// <param name="columnTitle">The Excel sheet column title.</param>
    /// <returns>The column number corresponding to <paramref name="columnTitle" />.</returns>
    int TitleToNumber(string columnTitle);
}