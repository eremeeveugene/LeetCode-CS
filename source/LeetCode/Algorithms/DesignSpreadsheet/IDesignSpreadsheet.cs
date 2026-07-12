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

namespace LeetCode.Algorithms.DesignSpreadsheet;

/// <summary>
///     https://leetcode.com/problems/design-spreadsheet/description/
/// </summary>
public interface IDesignSpreadsheet
{
    /// <summary>
    ///     Sets the value of the specified spreadsheet cell.
    /// </summary>
    /// <param name="cell">The cell reference, e.g. "A1".</param>
    /// <param name="value">The value to store in the cell.</param>
    void SetCell(string cell, int value);

    /// <summary>
    ///     Resets the specified spreadsheet cell to 0.
    /// </summary>
    /// <param name="cell">The cell reference, e.g. "A1".</param>
    void ResetCell(string cell);

    /// <summary>
    ///     Evaluates a formula of the form "=X+Y", where X and Y are either cell references or non-negative integers.
    /// </summary>
    /// <param name="formula">The formula to evaluate.</param>
    /// <returns>The value of the evaluated formula.</returns>
    int GetValue(string formula);
}