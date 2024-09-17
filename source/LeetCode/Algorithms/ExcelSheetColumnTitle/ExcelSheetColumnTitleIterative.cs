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

using System.Text;

namespace LeetCode.Algorithms.ExcelSheetColumnTitle;

/// <inheritdoc />
public class ExcelSheetColumnTitleIterative : IExcelSheetColumnTitle
{
    /// <summary>
    ///     Time complexity - O((log n) ^ 2)
    ///     Time complexity - O(log n)
    /// </summary>
    /// <param name="columnNumber"></param>
    /// <returns></returns>
    public string ConvertToTitle(int columnNumber)
    {
        var stringBuilder = new StringBuilder();

        while (columnNumber > 0)
        {
            stringBuilder.Insert(0, (char)(((columnNumber - 1) % 26) + 'A'));

            columnNumber = (columnNumber - 1) / 26;
        }

        return stringBuilder.ToString();
    }
}