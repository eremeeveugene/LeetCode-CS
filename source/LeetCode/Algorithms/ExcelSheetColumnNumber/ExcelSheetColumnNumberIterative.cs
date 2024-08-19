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

namespace LeetCode.Algorithms.ExcelSheetColumnNumber;

/// <inheritdoc />
public class ExcelSheetColumnNumberIterative : IExcelSheetColumnNumber
{
    private const int ColumnsCount = 26;

    private readonly Dictionary<char, int> _columnsDictionary = new()
    {
        { 'A', 1 },
        { 'B', 2 },
        { 'C', 3 },
        { 'D', 4 },
        { 'E', 5 },
        { 'F', 6 },
        { 'G', 7 },
        { 'H', 8 },
        { 'I', 9 },
        { 'J', 10 },
        { 'K', 11 },
        { 'L', 12 },
        { 'M', 13 },
        { 'N', 14 },
        { 'O', 15 },
        { 'P', 16 },
        { 'Q', 17 },
        { 'R', 18 },
        { 'S', 19 },
        { 'T', 20 },
        { 'U', 21 },
        { 'V', 22 },
        { 'W', 23 },
        { 'X', 24 },
        { 'Y', 25 },
        { 'Z', 26 }
    };

    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    public int TitleToNumber(string columnTitle)
    {
        var number = 0;

        for (var i = columnTitle.Length - 1; i >= 0; i--)
        {
            number += _columnsDictionary[columnTitle[i]] * (int)Math.Pow(ColumnsCount, columnTitle.Length - 1 - i);
        }

        return number;
    }
}