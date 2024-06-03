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

namespace LeetCode.Algorithms.PascalsTriangle2;

/// <inheritdoc />
public class PascalsTriangle2DynamicProgramming : IPascalsTriangle2
{
    /// <summary>
    ///     Time complexity - O(rowIndex^2)
    ///     Space complexity - O(rowIndex)
    /// </summary>
    /// <param name="rowIndex"></param>
    /// <returns></returns>
    public IList<int> GetRow(int rowIndex)
    {
        var row = new List<int> { 1 };

        for (var i = 1; i <= rowIndex; i++)
        {
            for (var j = i - 1; j >= 1; j--)
            {
                row[j] += row[j - 1];
            }

            row.Add(1);
        }

        return row;
    }
}