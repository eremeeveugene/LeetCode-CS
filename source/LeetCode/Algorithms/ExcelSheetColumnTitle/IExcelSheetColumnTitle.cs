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

namespace LeetCode.Algorithms.ExcelSheetColumnTitle;

/// <summary>
///     https://leetcode.com/problems/excel-sheet-column-title/description/
/// </summary>
public interface IExcelSheetColumnTitle
{
    /// <summary>
    ///     Converts the column number <paramref name="columnNumber" /> to its corresponding Excel sheet column title.
    /// </summary>
    /// <param name="columnNumber">The Excel sheet column number.</param>
    /// <returns>The column title corresponding to <paramref name="columnNumber" />.</returns>
    string ConvertToTitle(int columnNumber);
}